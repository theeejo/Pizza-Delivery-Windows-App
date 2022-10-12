using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery
{
    public class Adresa
    {
        public string strada;
        public int numar;

        public Adresa()
        {
            strada = "NoName";
            numar = 0;
        }

        public Adresa(string _strada, int nr)
        {
            strada = _strada;
            numar = nr;
        }

        public string Strada
        {
            get => strada;
            set { if (value != null) strada = value; }
        }

        public int Numar
        {
            get => numar;
            set
            {
                if (value > 0)
                    numar = value;
            }
        }

        public string toString()
        {
            return "Str. " + this.strada + ", nr. " + this.numar;
        }
    }
}
