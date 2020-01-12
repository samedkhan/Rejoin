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
            UserResume candidate = new UserResume();

            candidate.JobProfession = model.JobProfession;
            candidate.ExpierenceYear = model.ExperienceYear;
            candidate.UserId = _auth.User.UserId;
            candidate.PersonalSkill = model.PersonalSkill;

            _context.UserResumes.Add(candidate);
            _auth.User.HasResume = true;
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


        [HttpPost]
        public JsonResult Edit(ResumeModel model)
        {
            UserResume candidate = _context.UserResumes.Find(_auth.User.Resumes.ResumeId);

            candidate.JobProfession = model.JobProfession;
            candidate.ExpierenceYear = model.ExperienceYear;
            candidate.UserId = _auth.User.UserId;
            candidate.PersonalSkill = model.PersonalSkill;

            _context.SaveChanges();

            var Works = _context.Works.Where(e => e.ResumeId == _auth.User.Resumes.ResumeId).ToList();
            if (model.Works != null)
            {
                if (model.Works.Count == Works.Count)
                {
                    for (var j = 0; j < Works.Count; j++)
                    {
                        Works[j].CompanyName = model.Works[j].CompanyName;
                        Works[j].StartWorkYear = model.Works[j].StartWork;
                        Works[j].EndWorkYear = model.Works[j].EndWork;
                        Works[j].ResumeId = candidate.ResumeId;
                        Works[j].Position = model.Works[j].Position;
                    }
                }
                else if (model.Works.Count > Works.Count)
                {
                    for (var j = 0; j < Works.Count; j++)
                    {
                        Works[j].CompanyName = model.Works[j].CompanyName;
                        Works[j].StartWorkYear = model.Works[j].StartWork;
                        Works[j].EndWorkYear = model.Works[j].EndWork;
                        Works[j].Position = model.Works[j].Position;
                    }
                    for (var k = Works.Count; k < model.Works.Count; k++)
                    {
                        Work experience = new Work
                        {
                            CompanyName = model.Works[k].CompanyName,
                            StartWorkYear = model.Works[k].StartWork,
                            EndWorkYear = model.Works[k].EndWork,
                            ResumeId = candidate.ResumeId,
                            Position = model.Works[k].Position
                        };
                        _context.Works.Add(experience);
                        
                    }
                }
                else if (Works.Count > model.Works.Count)
                {

                    for (var j = 0; j < model.Works.Count; j++)
                    {
                        Works[j].CompanyName = model.Works[j].CompanyName;
                        Works[j].StartWorkYear = model.Works[j].StartWork;
                        Works[j].EndWorkYear = model.Works[j].EndWork;
                        Works[j].ResumeId = candidate.ResumeId;
                        Works[j].Position = model.Works[j].Position;
                    }
                    for (var t = model.Works.Count; t < Works.Count; t++)
                    {
                        _context.Works.Remove(Works[t]);
                    }

                }

            }
            else if (model.Works == null)
            {
                for (var t = 0; t < Works.Count; t++)
                {
                    _context.Works.Remove(Works[t]);
                }
            }


            //Educations of resume
            var educations = _context.Educations.Where(e => e.ResumeId == _auth.User.Resumes.ResumeId).ToList();
            if (model.Educations != null)
            {
                if (model.Educations.Count == educations.Count)
                {
                    for (var j = 0; j < educations.Count; j++)
                    {
                        educations[j].SchoolName = model.Educations[j].SchoolName;
                        educations[j].StartEducationYear = model.Educations[j].StartSchool;
                        educations[j].EndEducationYear = model.Educations[j].EndSchool;
                        educations[j].ResumeId = candidate.ResumeId;
                        educations[j].Qualification = model.Educations[j].Qualification;
                    }
                }
                else if (model.Educations.Count > educations.Count)
                {
                    for (var j = 0; j < educations.Count; j++)
                    {
                        educations[j].SchoolName = model.Educations[j].SchoolName;
                        educations[j].StartEducationYear = model.Educations[j].StartSchool;
                        educations[j].EndEducationYear = model.Educations[j].EndSchool;
                        educations[j].Qualification = model.Educations[j].Qualification;
                    }
                    for (var k = educations.Count; k < model.Educations.Count; k++)
                    {
                        Education education = new Education
                        {
                            SchoolName = model.Educations[k].SchoolName,
                            StartEducationYear = model.Educations[k].StartSchool,
                            EndEducationYear = model.Educations[k].EndSchool,
                            ResumeId = candidate.ResumeId,
                            Qualification = model.Educations[k].Qualification,
                        };
                        _context.Add(education);
                    }

                }
                else if (educations.Count > model.Educations.Count)
                {
                    for (var j = 0; j < model.Educations.Count; j++)
                    {
                        educations[j].SchoolName = model.Educations[j].SchoolName;
                        educations[j].StartEducationYear = model.Educations[j].StartSchool;
                        educations[j].EndEducationYear = model.Educations[j].EndSchool;
                        educations[j].Qualification = model.Educations[j].Qualification;
                    }
                    for (var t = model.Educations.Count; t < educations.Count; t++)
                    {
                        _context.Educations.Remove(educations[t]);
                    }

                }

            }
            else if (model.Educations == null)
            {
                for (var t = 0; t < educations.Count; t++)
                {
                    _context.Educations.Remove(educations[t]);
                }
            }

            _context.SaveChanges();
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