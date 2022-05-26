using AplikacjaDoNaukiJęzyków.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacjaDoNaukiJęzyków.Controllers
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

        /*
        [Route("Home/Index/{poziom:int}")]
        public IActionResult Index(int poziom = 1)
        {
            switch (poziom)
            {
                case 1:
                    ViewData["poziom"] = "Podstawowy";
                    break;
                case 2:
                    ViewData["poziom"] = "Średniozaawansowany";
                    break;
                case 3:
                    ViewData["poziom"] = "Zaawansowany";
                    break;
            }
            return View();
        }
        */
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult SetViewBag(string value)
        {
            ViewBag.Poziom = value;
            return new EmptyResult();
        }
    }
}
