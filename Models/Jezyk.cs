using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacjaDoNaukiJęzyków.Models
{

   public class Jezyk
    {
        private string nazwaJezyka;
        private string poziomJezyka;
        private string imageUrl;
        private string opis;

        public string NazwaJezyka { get; set; }
        public string PoziomJezyka { get; set; }
        public string ImageUrl { get; set; }
        public string Opis { get; set; }

        public Jezyk(string nazwa, string poziom, string ImageUrl = "", string opis = "Jezyk")
        {
            this.NazwaJezyka = nazwa;
            this.PoziomJezyka = poziom;
            this.ImageUrl = ImageUrl;
            this.Opis = opis;
        }
    }
}
