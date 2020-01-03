using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rejoin.Data;
using Rejoin.Injections;
using Rejoin.Models;
using Rejoin.ViewModels;

namespace Rejoin.Controllers
{
    public class JobController : BaseController
    {
        private readonly IAuth _auth;
        private readonly RejoinDbContext _context;
        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hosting;

        public JobController(RejoinDbContext context, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hosting, IAuth auth) : base(context)
        {
            _auth = auth;
            _context = context;
            _hosting = hosting;
        }

        public IActionResult Create()
        {
            if (Request.Cookies["token"] == null)
            {
                return RedirectToAction("login", "account");
            }
            else
            {

                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(JobIndexViewModel job)
        {
            if (ModelState.IsValid)
            {
                User LoggedUser = _context.Users.Find(_auth.User.UserId);

                Job newJob = new Job
                {
                    Title = job.JobCreate.Title,
                    Jobtype = job.JobCreate.Jobtype,
                    Role = job.JobCreate.Role,
                    Salary = job.JobCreate.Salary,
                    ExpierenceYear = job.JobCreate.ExpierenceYear,
                    City = job.JobCreate.City,
                    Location = job.JobCreate.Location,
                    JobDescription = job.JobCreate.JobDescription,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UserId = _auth.User.UserId,
                };

                LoggedUser.HasJobSubmit = true;

                _context.Jobs.Add(newJob);
                _context.Entry(LoggedUser).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("myjob", "job");
            }
            else
            {
                JobIndexViewModel data = new JobIndexViewModel()
                {
                    JobCreate = job.JobCreate
                };

                return View("~/Views/Job/Index.cshtml");
            }



        }

        public IActionResult Myjob()
        {
            if (Request.Cookies["token"] == null)
            {
                return RedirectToAction("login", "account");
            }
            else
            {
                ViewBag.AllJobs = _context.Jobs.Where(j => j.UserId == _auth.User.UserId).ToList();
                ViewBag.ActiveJobs = _context.Jobs.Where(j => j.UserId == _auth.User.UserId && j.IsActive == true).Count();
                ViewBag.DeactiveJobs = _context.Jobs.Where(j => j.UserId == _auth.User.UserId && j.IsActive != true).Count();

                return View();
            }
        }

        public IActionResult Edit(int Id)
        {
            Job job = _context.Jobs.Find(Id);
            if (job == null)
            {
                return NotFound();
            }
            else
            {
                ViewBag.Job = job;
                return View();
            }

        }

        [HttpPost]
        public IActionResult Edit(JobIndexViewModel job, int id)
        {

            if (ModelState.IsValid)
            {
                Job EditedJob = _context.Jobs.Find(id);


                EditedJob.Title = job.JobCreate.Title;
                EditedJob.Jobtype = job.JobCreate.Jobtype;
                EditedJob.Role = job.JobCreate.Role;
                EditedJob.Salary = job.JobCreate.Salary;
                EditedJob.ExpierenceYear = job.JobCreate.ExpierenceYear;
                EditedJob.City = job.JobCreate.City;
                EditedJob.Location = job.JobCreate.Location;
                EditedJob.JobDescription = job.JobCreate.JobDescription;

                _context.Entry(EditedJob).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("myjob", "job");
            }
            else
            {
                JobIndexViewModel data = new JobIndexViewModel()
                {
                    JobCreate = job.JobCreate
                };

                return View("~/Views/Job/Index.cshtml");
            }

        }

        public IActionResult Deactivate(int id)
        {
            Job DeactiveJob = _context.Jobs.Find(id);

            if(DeactiveJob == null)
            {
                return NotFound();
            }
            else
            {
                DeactiveJob.IsActive = false;
                _context.Entry(DeactiveJob).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("myjob", "job");
            }
        }

        public IActionResult Activate(int id)
        {
            Job ActivateJob = _context.Jobs.Find(id);

            if (ActivateJob == null)
            {
                return NotFound();
            }
            else
            {
                ActivateJob.IsActive = true;
                _context.Entry(ActivateJob).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("myjob", "job");
            }
        }


    }
}