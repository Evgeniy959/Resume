using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Resume.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutMe()
        {
            Person person = new Person();
            person.Age = 39;
            person.Name = "Evgeniy";
            person.Surname = "Pilipenko";
            return View(person);
        }

        public IActionResult Skills()
        {
            Skills skills = new Skills();
            skills.KeySkills = "Construction, finishing, electrics, manufacture of built-in cabinet furniture.";
            return View(skills);
        }
        public IActionResult Hobby()
        {
            Hobby hobby = new Hobby();
            hobby.MyHobby = "Sport, hunting, fishing, reading books, programming.";
            return View(hobby);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
