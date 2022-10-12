using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery
{
    public class Produs 
    {
        public string denumire;
        public float pret;
        //internal object[] produse;

        public Produs(string _denumire, float _pret)
        {
            denumire = _denumire;
            pret = _pret;
        }

        public Produs() { denumire = "Noname"; pret = 0; }

        public string Denumire
        {
            get => denumire;
            set => denumire = value;
        }

        public float Pret
        {
            get => pret;
            set => pret = value;
        }

        public Produs Clone()
        {
            return this.MemberwiseClone() as Produs;
        }

        public static Produs operator +(Produs p1, Produs p2)
        {
            return new Produs() { denumire = p1.denumire + p2.denumire, pret = p1.pret + p2.pret };
        }

        
    }
}
