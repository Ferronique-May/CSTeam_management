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
    public class PersonController : Controller
    {
        private readonly MyDbContext _db;
        [BindProperty]
        public Person People { get; set; }
        // private readonly ILogger<PersonController> _logger;
        public PersonController(MyDbContext db)//ILogger<PersonController> logger)
        {
        //     _logger = logger;
                _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int? id)
        {
            List<Person> ex = new List<Person>();
            if (!id.HasValue)
                return NotFound(); //Notfound is the 404 error page?

            var person = _db.People.FirstOrDefault(p => p.Id == id.Value);

            // if (person == null)
            //     return NotFound();
            return View(person); //Changed details to be fine with null (if/else)
        }
        public IActionResult Add(int? id)
        {
            People = new Person();
            return View(People);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add()
        {
            if (ModelState.IsValid)
            {
                //create
                _db.People.Add(People);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(People);
        }
        public IActionResult UseDefaults()
        {
            List<Person> defaults = PersonData.People;
            foreach(Person Dude in defaults) {
                _db.People.Add(Dude);
            }
            _db.SaveChanges();
            return View();
        }

    }
}