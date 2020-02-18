using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Website.Models;
using Website.StaticData;

namespace Website.Controllers
{
    public class ProjectController : Controller
    {
        private readonly MyDbContext _db;

        [BindProperty]
        public ProjectModel Project {get; set;}
        public ProjectController(MyDbContext db)//ILogger<PersonController> logger)
        {
        //     _logger = logger;
                _db = db;
        }

        public IActionResult Index()
        {
            List<ProjectModel> project = new List<ProjectModel>();
            for(int i = 1; i < 11; i++){
                project.Add(_db.Projects.FirstOrDefault(p => p.Id == i));
            }
            return View("ViewAll", project);
        }

        public IActionResult Add(int? id)
        {
            Project = new ProjectModel();
            return View(Project);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add()
        {
            if (ModelState.IsValid)
            {
                _db.Projects.Add(Project);
                _db.SaveChanges();
            }
            Project = new ProjectModel();
            return View(Project);
        }
    }
}