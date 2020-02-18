using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Website.Models;
using Website.StaticData;

namespace Website.Controllers
{
    public class UserController : Controller
    {
        public static bool sessionState { get; private set;}
        private readonly MyDbContext _db;

        public UserController(MyDbContext db)
        {
            _db = db;
        }
        public IActionResult Register()
        {
            var user = new UserModel();
            return View(user);
        }
        //this is only for testing
        public IActionResult test()
        {
            var val = _db.Users.ToList();
            return View(val);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register([Bind("Id", "Email", "FullName", "Password", "Role")]UserModel register)
        {
            Console.WriteLine(UserModel.EmailExists(register.Email, _db));
             if (ModelState.IsValid && !UserModel.EmailExists(register.Email, _db))
            {
                //create
                string hashed_password = SecurePasswordHasherHelper.Hash(register.Password);
                register.Password = hashed_password;

                _db.Users.Add(register);
                _db.SaveChanges();

                return Redirect("login");
            }

            return View("Register", register);
        }

        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
         public IActionResult Login([Bind("Id", "Email", "Password")]UserModel login)
        {
            if (login.Email == null || login.Password == null) 
                return View();

            string Email = login.Email;
            var user = _db.Users.FirstOrDefault(p => p.Email == Email);

            if (user == null)
                return View("Register");
            
            string userPassword = user.Password;
            
            if(SecurePasswordHasherHelper.Verify(login.Password,userPassword))
            {
                HttpContext.Session.SetInt32("ID", user.Id);
                sessionState = true;
                return Redirect("../Home/");
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            sessionState = false;
            return Redirect("Login");
        }
        
    }
    
}