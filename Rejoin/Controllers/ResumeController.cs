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
    public class ResumeController : BaseController
    {
        private readonly IAuth _auth;
        private readonly RejoinDbContext _context;
        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hosting;

        public ResumeController(RejoinDbContext context, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hosting, IAuth auth) : base(context)
        {
            _auth = auth;
            _context = context;
            _hosting = hosting;
        }

        public IActionResult Index()
        {
            if (Request.Cookies["token"] == null)
            {
                return RedirectToAction("login", "account");
            }
            else
            {
                ResumeIndexViewModel data = new ResumeIndexViewModel();
                data.Breadcumb = new BreadcumbViewModel
                {
                    Path = new Dictionary<string, string>()
                };
                if (_auth.User.HasResume == true)
                {
                    data.Breadcumb.Title = "Edit Resume";
                }
                else
                {
                    data.Breadcumb.Title = "Create Resume";
                }
                data.Breadcumb.Path.Add("index", "Home");
                data.Breadcumb.Path.Add(data.Breadcumb.Title, null);

                ViewBag.Partial = data.Breadcumb;
             
                return View();
            }
        }

        [HttpPost]
        public JsonResult Create(ResumeModel model)
        {
            //if (model.Upload != null)
            //{
            //    try
            //    {
            //        candidate.Photo = _fileManager.Upload(model.Upload);

            //    }
            //    catch (Exception e)
            //    {
            //        return Json(new
            //        {
            //            status = "OK",
            //            StatusCode = 500,
            //            message = "melumatlar yanlisdir",
            //            data = candidate.Photo
            //        });
            //    }
            //}

            UserResume candidate = new UserResume();

            candidate.JobProfession = model.JobProfession;
            candidate.ExpierenceYear = model.ExperienceYear;
            candidate.UserId = _auth.User.UserId;
            candidate.PersonalSkill = model.PersonalSkill;

            _context.UserResumes.Add(candidate);
            _context.Users.Find(_auth.User.UserId).HasResume = true;
            _context.SaveChanges();

            if (model.Works != null)
            {
                for (var i = 0; i < model.Works.Count; i++)
                {

                    Work experience = new Work
                    {
                        CompanyName = model.Works[i].CompanyName,
                        StartWorkYear = model.Works[i].StartWork,
                        EndWorkYear = model.Works[i].EndWork,
                        ResumeId = candidate.ResumeId,
                        Position = model.Works[i].Position,
                    };
                    _context.Works.Add(experience);
                    _context.SaveChanges();
                }
            }

            if (model.Educations != null)
            {
                for (var i = 0; i < model.Educations.Count; i++)
                {
                    Education education = new Education
                    {
                        SchoolName = model.Educations[i].SchoolName,
                        StartEducationYear = model.Educations[i].StartSchool,
                        EndEducationYear = model.Educations[i].EndSchool,
                        ResumeId = candidate.ResumeId,
                        Qualification = model.Educations[i].Qualification
                    };
                    _context.Educations.Add(education);
                    _context.SaveChanges();
                }
            }
            return Json(new
            {

                status = "OK",
                code = 200,
                message = "added Cv",
                data = model,
                redirectUrl = Url.Action("Index", "Home"),
                isRedirect = true
            });

        }
    }
}