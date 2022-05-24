using AplikacjaDoNaukiJęzyków.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacjaDoNaukiJęzyków.Controllers
{
    public class SlownikController : Controller
    {
        private DatabaseContext context;
        public SlownikController(DatabaseContext context)
        {
            this.context = context;
        }
        public IActionResult Slownik()
        {
            var slowa = context.Slowa;
            return View(slowa);
        }

        public void Sprawdz(string slowo)
        {

        }
    }
}
