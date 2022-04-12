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
            List<Jezyk> jezyki = new List<Jezyk>();
            jezyki.Add(new Jezyk("Angielski", "Podstawowy", 
                "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Flag_of_the_United_Kingdom_%283-5%29.svg/1280px-Flag_of_the_United_Kingdom_%283-5%29.svg.png",
                "Język z grupy zachodniej rodziny języków germańskich, powszechnie używany w Wielkiej Brytanii, jej terytoriach zależnych oraz w wielu byłych koloniach i dominiach, m.in. Stanach Zjednoczonych, Irlandii, Kanadzie, RPA, Australii i Nowej Zelandii. Pełni funkcję języka oficjalnego bądź półoficjalnego w ponad 60 krajach."));
            jezyki.Add(new Jezyk("Ukraiński", "Podstawowy", 
                "http://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Flag_of_Ukraine.svg/640px-Flag_of_Ukraine.svg.png",
                "Język należący do grupy języków wschodniosłowiańskich. Posługuje się nim 41–45 mln ludzi, głównie na Ukrainie, gdzie ma status języka urzędowego. Używany jest również przez Ukraińców w Rosji, Stanach Zjednoczonych, Kanadzie, Mołdawii, Polsce i na Białorusi. Współczesny alfabet ukraiński stanowi odmianę cyrylicy, a obecna postać ortografii wypracowana została zasadniczo na początku XX wieku."));
            jezyki.Add(new Jezyk("Arabski", "Podstawowy",
                "https://flagcdn.com/w2560/sa.png",
                "Język z rodziny języków semickich, w której zaliczany jest do grupy języków południowo-zachodnich według klasycznego podziału, bądź grupy języków zachodnich, centralnych według podziału Hetzrona i Voigta. Zapisywany jest alfabetycznym pismem arabskim typu abdżad, od strony prawej do lewej."));
            jezyki.Add(new Jezyk("Arabski", "Podstawowy",
                "https://flagcdn.com/w2560/sa.png",
                "Język z rodziny języków semickich, w której zaliczany jest do grupy języków południowo-zachodnich według klasycznego podziału, bądź grupy języków zachodnich, centralnych według podziału Hetzrona i Voigta. Zapisywany jest alfabetycznym pismem arabskim typu abdżad, od strony prawej do lewej."));

            return View(jezyki);
        }

        public IActionResult Jezyk(string nazwaJezyka)
        {
            ViewData["Nazwa"] = "Język " + nazwaJezyka;

            return View();
        }

        public IActionResult Jezyk(string nazwaJezyka)
        {
            ViewData["Nazwa"] = "Język " + nazwaJezyka;

            return View();
        }
    }
}
