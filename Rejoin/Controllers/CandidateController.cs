using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rejoin.Data;
using Rejoin.Injections;
using Rejoin.Models;
using Rejoin.ViewModels;

namespace Rejoin.Controllers
{
    public class CandidateController : BaseController
    {
        private readonly IRelativeTime _relativetime;
        private readonly IAuth _auth;
        private readonly RejoinDbContext _context;
        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hosting;

        public CandidateController(RejoinDbContext context, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hosting, IAuth auth, IRelativeTime relativetime) : base(context)
        {
            _relativetime = relativetime;
            _auth = auth;
            _context = context;
            _hosting = hosting;
        }

        public IActionResult Index()
        {
            List<Job> Jobs = _context.Jobs.Include(j => j.user).Where(j => j.IsActive == true).OrderByDescending(j => j.CreatedAt).ToList();
            ViewBag.Jobs = Jobs;
            List<User> Candidates = _context.Users.Include(u => u.Resumes).Where(u => u.HasResume == true).ToList();
            ViewBag.Candidates = Candidates;
            CandidateIndexViewModel data = new CandidateIndexViewModel();
            data.Breadcumb = new BreadcumbViewModel
            {
                Title = "Candidates",
                Path = new Dictionary<string, string>()
            };
            data.Breadcumb.Path.Add("index", "Home");
            data.Breadcumb.Path.Add("Pages", null);
            data.Breadcumb.Path.Add("Candidates", null);

            ViewBag.Partial = data.Breadcumb;

            return View();
        }

        public IActionResult Appliers(int JobId)
        {
            CandidateIndexViewModel data = new CandidateIndexViewModel();
            data.Breadcumb = new BreadcumbViewModel
            {
                Title = "Appliers",
                Path = new Dictionary<string, string>()
            };
            data.Breadcumb.Path.Add("index", "Home");
            data.Breadcumb.Path.Add("My Jobs", null);
            data.Breadcumb.Path.Add("Appliers", null);

            ViewBag.Partial = data.Breadcumb;

            List<Apply> applies = _context.Appliers.Include(a=>a.user).Where(a=>a.JobId==JobId).ToList();

            List<User> Appliers = new List<User>();

            foreach (Apply item in applies)
            {
                User Finded = _context.Users.Include(u=>u.Resumes).Where(u => u.UserId == item.UserId).FirstOrDefault();
                Appliers.Add(Finded);
            }

            ViewBag.Candidates = Appliers;

            return View();

        }
    }   
}