using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacjaDoNaukiJęzyków.Models
{
   public class Jezyk
    {
        public string nazwaJezyka;
        public string poziomJezyka;


        public string NazwaJezyka
        {
            get
            {
                return nazwaJezyka;
            }

            set
            {
                nazwaJezyka = value;
            }
        }

        public string PoziomJezyka
        {
            get
            {
                return poziomJezyka;
            }

            set
            {
                poziomJezyka = value;
            }
        }

        public Jezyk(string nazwa, string poziom)
        {
            this.NazwaJezyka = nazwa;
            this.PoziomJezyka = poziom;
        }
    }
}
