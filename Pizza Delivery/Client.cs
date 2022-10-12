using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery
{
   public class Client : IComanda
    {
        public string nume;
        public string telefon;
        public string tip_plata;
        public List<Pizza> comanda;

        public Client()
        {
            nume = "NoName";
            tip_plata = "";
            telefon = "";
            comanda = null;
        }

        public Client(string _nume, string tip, string _tel, List<Pizza> pizza)
        {
            nume = _nume;
            tip_plata = tip;
            telefon = _tel;
            comanda = pizza;
        }

        public string Nume
        {
            get => nume;
            set { if (value!=null) nume = value; }
        }

        public string Tip_Plata
        {
            get => tip_plata;
            set => tip_plata = value;
        }

        public string Telefon
        {
            get => telefon;
            set { if (value != null && value.Length == 10)
                    telefon = value;
            }
        }

        public string toString()
        {
            return "Clientul " + this.nume + ", cu numarul de telefon " + this.telefon + " plateste: " + this.tip_plata;
        }

        public List<Pizza> plaseaza_comanda(Pizza[] p)
        {
            List<Pizza> comanda = new List<Pizza>();
            for(int i = 0; i < p.Length; i++)
            {
                comanda.Add(p[i]);
            }
            return comanda;
        }

        public float calculeaza_comanda(List<Pizza> comanda)
        {
            float valoare = 0.0f;
            foreach(Pizza p in comanda)
            {
                valoare += p.calculeaza_total();
            }

            return valoare;
        }
        
    }
}
