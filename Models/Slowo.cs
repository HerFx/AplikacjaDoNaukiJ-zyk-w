using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacjaDoNaukiJęzyków.Models
{
    public class Slowo
    {
        /*private string nazwaSlowo;
        private string poziomSlowa;
        private string slowoPol;
        private string slowoAng;
        private string slowoAra;
        */

        private string NazwaSlowo { get; set; }
        public string SlowoPol { get; set; }
        public string SlowoAng { get; set; }
        public string SlowoAra { get; set; }

        public Slowo(string slowoPol, string slowoAng, string slowoAra, string poziom)
        {
            this.NazwaSlowo = slowo;
            this.PoziomSlowa = poziom;
            this.SlowoPol = slowoPol;
            this.SlowoAng = slowoAng;
            this.SlowoAra = slowoAra;
        }
    }
}
