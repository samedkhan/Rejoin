using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rejoin.Data;
using Rejoin.ViewModels;
using Rejoin.Models;
using CryptoHelper;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Rejoin.Controllers
{
    public class AccountController : BaseController
    {
        private readonly RejoinDbContext _context;
        //private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hosting;

        public AccountController(RejoinDbContext context /*Microsoft.AspNetCore.Hosting.IWebHostEnvironment hosting*/):base(context)
        {
            _context = context;
            //_hosting = hosting;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(AccountRegisterModel register)
        {
            
            if (ModelState.IsValid)
            {
                if (!_context.Users.Any(u => u.Email == register.Email))
                {

                    User user = new User
                    {
                        Email = register.Email,
                        Username = register.Username,
                        Password = Crypto.HashPassword(register.Password),
                        CreatedAt = DateTime.Now,
                        Token = Guid.NewGuid().ToString(),
                        IsCompany = register.IsCompany
                        

                    };

                    _context.Users.Add(user);
                    _context.SaveChanges();

                    Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                    {
                        Expires = DateTime.Now.AddYears(1),
                        HttpOnly = true
                    });
                    return RedirectToAction("profile", "account");
                }

                else
                {
                    ModelState.AddModelError("Email", "This user is already in registered");
                }

            }

            AccountIndexViewModel data = new AccountIndexViewModel
            {
                Register = register
            };

            return View("~/Views/Account/Register.cshtml", data);

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AccountLoginModel login)
        {
            if (ModelState.IsValid)
            {
                User user = _context.Users.FirstOrDefault(u => u.Username == login.Username);

                if (user != null)
                {
                    if (Crypto.VerifyHashedPassword(user.Password, login.Password))
                    {
                        user.Token = Guid.NewGuid().ToString();
                        _context.SaveChanges();

                        Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                        {
                            Expires = DateTime.Now.AddYears(1),
                            HttpOnly = true
                        });

                        return RedirectToAction("index", "home");
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Username or Password is not correct");
                }
            }

            AccountIndexViewModel data = new AccountIndexViewModel
            {
                Login = login
            };

            return View("~/Views/Account/Login.cshtml", data);
        }

        public IActionResult Logout()
        {
            var token = Request.Cookies["token"];
            User LoggedUser = _context.Users.FirstOrDefault(u => u.Token == token);
            LoggedUser.Token = null;
            _context.SaveChanges();
            Response.Cookies.Append("token", token, new Microsoft.AspNetCore.Http.CookieOptions
            {
                Expires = DateTime.Now.AddDays(-1),
                HttpOnly = true
            });
            return RedirectToAction("index", "home");
        }

        public IActionResult Profile()
        {
            if (Request.Cookies["token"] == null)
            {
                return RedirectToAction("index", "home");
            }
            else
            {
             
                return View();
            }
            
        }

        [HttpPost]
        public IActionResult Profile(AccountProfileModel profile)
        {

            if (ModelState.IsValid)
            {
                //string FileName = null;
                var token = Request.Cookies["token"];
                User LoggedUser = _context.Users.FirstOrDefault(u => u.Token == token);

                LoggedUser.FirstName = profile.FirstName;
                LoggedUser.LastName = profile.LastName;
                LoggedUser.Country = profile.Country;
                LoggedUser.City = profile.City;
                LoggedUser.Adress = profile.Adress;
                LoggedUser.ZipCode = profile.ZipCode;
                LoggedUser.Phone = profile.Phone;
                LoggedUser.Facebook = profile.Facebook;
                LoggedUser.Twitter = profile.Twitter;
                LoggedUser.Pinterest = profile.Pinterest;
                LoggedUser.Google = profile.Google;
                LoggedUser.AboutMe = profile.AboutMe;

                //if(profile.Photo != null)
                //{
                //    string UploadsFolder = Path.Combine(/*_hosting.WebRootPath, */"Uploads", "users");
                //    FileName = Guid.NewGuid() + "_" + profile.Photo.FileName;
                //    string FilePath = Path.Combine(UploadsFolder, FileName);
                //    profile.Photo.CopyTo(new FileStream(FilePath, FileMode.Create));
                //}

                //LoggedUser.Image = FileName;

                _context.Entry(LoggedUser).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("index", "home");

            }
            else
            {
                AccountIndexViewModel data = new AccountIndexViewModel
                {
                    Profile = profile
                };

                return View("~/Views/Account/Profile.cshtml", data);

            }

        }
    }
}