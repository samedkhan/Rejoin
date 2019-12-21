using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rejoin.Data;
using Rejoin.ViewModels;
using Rejoin.Models;
using CryptoHelper;


namespace Rejoin.Controllers
{
    public class AccountController : Controller
    {
        private readonly RejoinDbContext _context;

        public AccountController(RejoinDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Register(AccountRegisterModel user)
        {
           
            if (ModelState.IsValid)
            {
                if(!_context.Users.Any(u => u.Email == user.Email))
                {
                    User newUser = new User
                    {
                        Email = user.Email,
                        Username = user.Username,
                        Password = Crypto.HashPassword(user.Password),
                        CreatedAt = DateTime.Now,
                        Token = Guid.NewGuid().ToString()
                    };

                    _context.Users.Add(newUser);
                    _context.SaveChanges();

                    Response.Cookies.Append("token", newUser.Token, new Microsoft.AspNetCore.Http.CookieOptions {
                        Expires = DateTime.Now.AddYears(1),
                        HttpOnly = true
                    });

                    return RedirectToAction("index", "home");
                }


                ModelState.AddModelError("Email", "This user is already in registered");
            }

            AccountIndexViewModel data = new AccountIndexViewModel
            {
                register = user
            };

            return View("~/Views/Account/Register.cshtml", data);

        }

        
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}