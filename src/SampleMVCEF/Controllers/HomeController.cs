using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleMVCEF.Models;

namespace SampleMVCEF.Controllers
{
    public class HomeController : Controller
    {
        private PersonDBContext context;
        public HomeController(PersonDBContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var data = context.Person.ToList();
            return View(data);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
