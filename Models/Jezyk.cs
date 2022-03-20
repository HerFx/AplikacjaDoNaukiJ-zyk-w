using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacjaDoNaukiJęzyków.Models
{
   class Jezyk
    {
        private string nazwaJezyka;
        private string poziomJezyka;

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
            this.nazwaJezyka = nazwa;
            this.poziomJezyka = poziom;
        }
    }
}
