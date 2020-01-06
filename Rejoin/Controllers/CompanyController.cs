using System;
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
    public class CompanyController : BaseController
    {
        private readonly IRelativeTime _relativetime;
        private readonly IAuth _auth;
        private readonly RejoinDbContext _context;
        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hosting;

        public CompanyController(RejoinDbContext context, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hosting, IAuth auth, IRelativeTime relativetime) : base(context)
        {
            _relativetime = relativetime;
            _auth = auth;
            _context = context;
            _hosting = hosting;
        }

        public IActionResult AllCompanies()
        {
            List<User> Companies = _context.Users.Include("Jobs").Where(u => u.IsCompany == true).OrderByDescending(u => u.CreatedAt).ToList();
            ViewBag.Companies = Companies;
            
            return View();
        }

        public IActionResult Details(int id)
        {
            User Company = _context.Users.Include("Jobs").Where(u => u.UserId == id && u.IsCompany == true).FirstOrDefault();
            ViewBag.Company = Company;
            if(ViewBag.Company == null)
            {
                return NotFound();
            }
            else
            {
                return View();
            }
           
        }


    }
}