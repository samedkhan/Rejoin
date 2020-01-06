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
using Rejoin.Injections;

namespace Rejoin.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IAuth _auth;
        private readonly RejoinDbContext _context;
        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hosting;

        public AccountController(RejoinDbContext context, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hosting, IAuth auth) :base(context)
        {
            _auth = auth;
            _context = context;
            _hosting = hosting;
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
                    ModelState.AddModelError("", "Username or Password is not correct");
                }
            }

            AccountIndexViewModel data = new AccountIndexViewModel
            {
                Login = login
            };

            return View("~/Views/Account/Login.cshtml");
        }

        public IActionResult Logout()
        {
            var token = Request.Cookies["token"];
            User LoggedUser = _context.Users.Find(_auth.User.UserId);
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
                return RedirectToAction("login", "account");
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
                string FileName = null;
                User LoggedUser = _context.Users.Find(_auth.User.UserId);

                if (profile.Photo != null)
                {
                    if (profile.Photo.Length > 100000)
                    {
                        ModelState.AddModelError("", "Volume must be low than 1 mb");
                        ViewBag.PhotoName = profile.Photo.FileName;
                        return View();
                    }
                    string UploadsFolder = Path.Combine(_hosting.WebRootPath, "images", "users");
                    FileName = Guid.NewGuid() + "_" + profile.Photo.FileName;
                    string FilePath = Path.Combine(UploadsFolder, FileName);
                    profile.Photo.CopyTo(new FileStream(FilePath, FileMode.Create));
                    LoggedUser.Image = FileName;
                }

                LoggedUser.FirstName = profile.FirstName;
                if (LoggedUser.IsCompany != true)
                {
                    LoggedUser.LastName = profile.LastName;
                }
                LoggedUser.Country = profile.Country;
                LoggedUser.City = profile.City;
                LoggedUser.Adress = profile.Adress;
                LoggedUser.ZipCode = profile.ZipCode;
                LoggedUser.Phone = profile.Phone;
                LoggedUser.Facebook = profile.Facebook;
                LoggedUser.Google = profile.Google;
                LoggedUser.AboutMe = profile.AboutMe;

                _context.Entry(LoggedUser).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

                if (LoggedUser.IsCompany == true)
                {
                    if (LoggedUser.HasJobSubmit != true)
                    {
                        return RedirectToAction("create", "job", new { id = LoggedUser.UserId });
                    }
                }
                else 
                {
                    if(LoggedUser.HasResume != true)
                    {
                        return RedirectToAction("index", "resume", new { id = LoggedUser.UserId });
                    }
                    
                }

                return RedirectToAction("index", "home");

            }
            else
            {
                AccountIndexViewModel data = new AccountIndexViewModel
                {
                    Profile = profile
                };
               
                return View("~/Views/Account/Profile.cshtml");

            }

        }
    }
}