using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacjaDoNaukiJęzyków.Models
{

   public class Jezyk
    {

        public string NazwaJezyka { get; private set; }
        public string PoziomJezyka { get; private set; }
        public string ImageUrl { get; private set; }
        public string Opis { get; private set; }

        public Jezyk(string nazwa, string poziom, string ImageUrl = "", string opis = "Jezyk")
        {
            this.NazwaJezyka = nazwa;
            this.PoziomJezyka = poziom;
            this.ImageUrl = ImageUrl;
            this.Opis = opis;
        }
    }
}
