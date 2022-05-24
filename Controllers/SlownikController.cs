using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacjaDoNaukiJęzyków.Controllers
{
    public class SlownikController : Controller
    {
        public IActionResult Slownik()
        {
            return View();
        }
    }
}
