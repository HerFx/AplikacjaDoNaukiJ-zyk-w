using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplikacjaDoNaukiJęzyków.Models;

namespace AplikacjaDoNaukiJęzyków.Controllers
{
    public class JezykWybController : Controller
    {
        public IActionResult JezykWyb()
        {
            ViewData["Jezyk"] = new Jezyk("Angielski", "Podstawowy");

            return View();
        }

        public IActionResult Jezyk(string nazwaJezyka)
        {
            ViewData["Nazwa"] = "Język " + nazwaJezyka;

            return View();
        }
    }
}
