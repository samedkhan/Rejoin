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

                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(ResumeIndexViewModel resume)
        {
            User LoggedUser = _context.Users.Find(_auth.User.UserId);

            LoggedUser.JobProfession = resume.Resume.JobProfession;
            LoggedUser.ExperienceYear = resume.Resume.ExperienceYear;
            LoggedUser.ExperienceMonth = resume.Resume.ExperienceMonth;
            LoggedUser.PersonalSkills = resume.Resume.PersonalSkills;


            return View();
        }
    }
}