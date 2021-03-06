﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rejoin.Data;
using Rejoin.Injections;
using Rejoin.Models;
using Rejoin.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Rejoin.Controllers
{
    public class JobController : BaseController
    {
        private readonly IRelativeTime _relativetime;
        private readonly IAuth _auth;
        private readonly RejoinDbContext _context;
        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hosting;

        public JobController(RejoinDbContext context, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hosting, IAuth auth, IRelativeTime relativetime) : base(context)
        {
            _relativetime = relativetime;
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
                JobIndexViewModel data = new JobIndexViewModel();
                data.Breadcumb = new BreadcumbViewModel
                {
                    Title = "Submit Job",
                    Path = new Dictionary<string, string>()
                };
                data.Breadcumb.Path.Add("index", "Home");
                data.Breadcumb.Path.Add("My Dashboard", null);
                data.Breadcumb.Path.Add("Submit Job", null);

                ViewBag.Partial = data.Breadcumb;
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
                    Category = job.JobCreate.Category,
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
                ViewBag.AllJobs = _context.Jobs.Where(j => j.UserId == _auth.User.UserId).OrderByDescending(j => j.CreatedAt).ToList();
                ViewBag.ActiveJobs = _context.Jobs.Where(j => j.UserId == _auth.User.UserId && j.IsActive == true).OrderByDescending(j => j.CreatedAt).ToList();
                ViewBag.DeactiveJobs = _context.Jobs.Where(j => j.UserId == _auth.User.UserId && j.IsActive != true).OrderByDescending(j => j.CreatedAt).ToList();
                JobIndexViewModel data = new JobIndexViewModel();
                data.Breadcumb = new BreadcumbViewModel
                {
                    Title = "My Jobs",
                    Path = new Dictionary<string, string>()
                };
                data.Breadcumb.Path.Add("index", "Home");
                data.Breadcumb.Path.Add("My Dashboard", null);
                data.Breadcumb.Path.Add("My Jobs", null);

                ViewBag.Partial = data.Breadcumb;

                return View();
            }
        }

        public IActionResult Edit(int Id)
        {
            if (Request.Cookies["token"] == null)
            {
                return RedirectToAction("login", "account");
            }
            else
            {
                Job job = _context.Jobs.Where(j => j.JobId == Id && j.UserId == _auth.User.UserId).FirstOrDefault();
                if (job == null)
                {
                    return NotFound();
                }
                else
                {
                    JobIndexViewModel data = new JobIndexViewModel();
                    data.Breadcumb = new BreadcumbViewModel
                    {
                        Title = "Edit Job",
                        Path = new Dictionary<string, string>()
                    };
                    data.Breadcumb.Path.Add("index", "Home");
                    data.Breadcumb.Path.Add("Edit Job", null);

                    ViewBag.Partial = data.Breadcumb;
                    ViewBag.Job = job;
                    return View();
                }
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
                EditedJob.Category = job.JobCreate.Category;

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

        public IActionResult Deactivate(int Id)
        {
            if (Request.Cookies["token"] == null)
            {
                return RedirectToAction("login", "account");
            }
            else
            {
                Job DeactiveJob = _context.Jobs.Where(j => j.JobId == Id && j.UserId == _auth.User.UserId).FirstOrDefault();

                if (DeactiveJob == null)
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

        }

        public IActionResult Activate(int Id)
        {
            if (Request.Cookies["token"] == null)
            {
                return RedirectToAction("login", "account");
            }
            else
            {
                Job ActivateJob = _context.Jobs.Where(j => j.JobId == Id && j.UserId == _auth.User.UserId).FirstOrDefault();

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

        public IActionResult Details(string Title, int id)
        {
            Job JobDetail = _context.Jobs.Include(j => j.user).Include("Appliers").Where(j => j.JobId == id).FirstOrDefault();

            if (JobDetail == null)
            {
                return NotFound();
            }
            else
            {

                ViewBag.JobDetail = JobDetail;
                ViewBag.User = JobDetail.user;

                JobIndexViewModel data = new JobIndexViewModel();
                data.Breadcumb = new BreadcumbViewModel
                {
                    Title = "Job Details",
                    Path = new Dictionary<string, string>()
                };
                data.Breadcumb.Path.Add("index", "Home");
                data.Breadcumb.Path.Add("myjob", "Job");
                data.Breadcumb.Path.Add("Job Details", null);

                ViewBag.Partial = data.Breadcumb;

                return View();
            }
        }

        public IActionResult Alljobscompany(int id)
        {
            List<Job> AllJobs = _context.Jobs.Include(j => j.user).Where(j => j.user.UserId == id).ToList();
            ViewBag.Jobs = AllJobs;
            ViewBag.User = _context.Users.Find(id);

            if (ViewBag.User == null)
            {
                return NotFound();
            }
            else
            {
                JobIndexViewModel data = new JobIndexViewModel();
                data.Breadcumb = new BreadcumbViewModel
                {
                    Title = "Active Vacancies",
                    Path = new Dictionary<string, string>()
                };
                data.Breadcumb.Path.Add("index", "Home");
                data.Breadcumb.Path.Add("Active Vacancies", null);

                ViewBag.Partial = data.Breadcumb;
                return View();
            }
        }

        public IActionResult Alljobs()
        {

            List<Job> Jobs = _context.Jobs.Include(j => j.user).Include("Appliers").Where(j => j.IsActive == true).OrderByDescending(j => j.CreatedAt).ToList();
            ViewBag.Jobs = Jobs;
            JobIndexViewModel data = new JobIndexViewModel();
            data.Breadcumb = new BreadcumbViewModel
            {
                Title = "Jobs",
                Path = new Dictionary<string, string>()
            };
            data.Breadcumb.Path.Add("index", "Home");
            data.Breadcumb.Path.Add("Pages", null);
            data.Breadcumb.Path.Add("Jobs", null);

            ViewBag.Partial = data.Breadcumb;
            return View();
        }

        public IActionResult Find(string? Category, string? Title)
        {
            List<Job> FindedJobs;
            if (Category == "All" && Title == "")
            {
                FindedJobs = _context.Jobs.Include(j => j.user).Where(j => j.IsActive == true).OrderByDescending(j => j.CreatedAt).ToList();

            }
            else
            {
                FindedJobs = _context.Jobs.Include(j => j.user).Where(j => j.IsActive == true && (j.Category.Contains(Category) || j.Title.Contains(Title))).OrderByDescending(j => j.CreatedAt).ToList();
            }

            ViewBag.Jobs = FindedJobs;
            JobIndexViewModel data = new JobIndexViewModel();
            data.Breadcumb = new BreadcumbViewModel
            {
                Title = "Jobs",
                Path = new Dictionary<string, string>()
            };
            data.Breadcumb.Path.Add("index", "Home");
            data.Breadcumb.Path.Add("Pages", null);
            data.Breadcumb.Path.Add("Jobs", null);

            ViewBag.Partial = data.Breadcumb;
            return View();
        }

        public IActionResult Apply(int JobId, int? UserId)
        {

            if (_auth.User.UserId != UserId || UserId==null)
            {
                return RedirectToAction("login", "account");
            }
            else
            {

                Job FindedJob = _context.Jobs.Include("Appliers").Where(j => j.JobId == JobId).FirstOrDefault();
                if (FindedJob == null)
                {
                    return NotFound();
                }
                else
                {
                    Apply NewApplier = new Apply
                    {
                        UserId = _auth.User.UserId,
                        JobId = FindedJob.JobId,
                    };
                    _context.Appliers.Add(NewApplier);
                    _context.SaveChanges();
                    return RedirectToAction("Alljobs", "job");
                }
            }

        }
       

    }
}