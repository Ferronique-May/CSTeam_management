using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Website.Models;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            //loggin errors or something? Made by the default dotnet new mvc
            _logger = logger;
        }
        public IActionResult Index()
        {
            // HttpContext.Session.SetString("Hello", "<br> This will be caused by a session :D");
            // HttpContext.Session.SetInt32("Hello", 12);
            return View();
        }

        public IActionResult Privacy()
        {
            // ViewBag.Message =  HttpContext.Session.GetString("Hello");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
