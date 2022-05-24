using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacjaDoNaukiJęzyków.Models
{
    public class Slowo
    {
        /*
        private string nazwaSlowo;
        private string poziomSlowa;
        private string slowoPol;
        private string slowoAng;
        private string slowoAra;
        */

        public int ID { get; set; }
        public string PoziomSlowa { get; set; }
        public string SlowoPol { get; set; }
        public string SlowoAng { get; set; }
        public string SlowoAra { get; set; }
        public string SlowoUkr { get; set; }


        /*public Slowo(string slowoPol, string slowoAng, string slowoAra, string slowoUkr, string poziom)
        {

            this.PoziomSlowa = poziom;
            this.SlowoPol = slowoPol;
            this.SlowoAng = slowoAng;
            this.SlowoAra = slowoAra;
            this.SlowoUkr = slowoUkr;
        }*/
    }
}
