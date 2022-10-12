using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Delivery 
{
    public class Pizza : ICloneable, IComparable
    {
        public string denumire;
        public string[] extra_topping;

        public Pizza()
        {
            denumire = "NoName";
            extra_topping = null;
        }

        public Pizza(string _denumire, string[] topping)
        {
            denumire = _denumire;
            extra_topping = new string[topping.Length];
            for(int i = 0; i < extra_topping.Length; i++)
            {
                extra_topping[i] = topping[i];
            }

        }

        public string Denumire
        {
            get => denumire;
            set { if (value != null)
                    denumire = value;
            }
        }

        public float calculeaza_dupa_nume()
        {
            float pret = 0.0f; //default
            if (this.denumire == "Margherita") pret = 23;
            else if (this.denumire == "Diavola") pret = 35;
            else if (this.denumire == "Quattro Formaggi") pret = 33;
            else if (this.denumire == "Carnivora") pret = 30;
            else if (this.denumire == "Capricciosa") pret = 32.5f;
            else if (this.denumire == "Romana") pret = 28;

            return pret;
        }

        public string[] Extra_Topping
        {
            get => extra_topping;
            set { if(value != null)
                    extra_topping = value;
                }
        }

        public int numar_topping()
        {
            int numar_toppinguri = 0;
            foreach(string topping in this.extra_topping)
            {
                numar_toppinguri++;
            }
            return numar_toppinguri;
        }

        public object Clone()
        {
            Pizza clone = (Pizza)this.MemberwiseClone();
            string[] topping_nou = (string[])extra_topping.Clone();
            clone.extra_topping = topping_nou;
            return clone;
        }

        // se compara dupa pret
        public int CompareTo(object obj)
        {
            Pizza p = (Pizza)obj;
            if (this.calculeaza_dupa_nume() > p.calculeaza_dupa_nume()) return 1;
            else if (this.calculeaza_dupa_nume() < p.calculeaza_dupa_nume()) return -1;
            else return 0;
        }
        public float calculeaza_total()
        {
            float pret = 0.0f;
            pret += this.calculeaza_dupa_nume();
            for(int i = 0; i < this.extra_topping.Length; i++)
            {
                if (this.extra_topping[i] == "Bacon") pret += 5;
                if (this.extra_topping[i] == "Ciuperci") pret += 3;
                if (this.extra_topping[i] == "Masline") pret += 4.5f;
                if (this.extra_topping[i] == "Porumb") pret += 4;
                if (this.extra_topping[i] == "Jalapeno") pret += 6;

            }
            return pret;
        }

        public string ToString()
        {
            string rez = "Pizza " + this.denumire + " cu extra toppinguri: ";
            for(int i = 0; i < this.extra_topping.Length; i++)
            {
                rez += extra_topping[i] + " ";
            }
            rez += "." + "\nPret: " + this.calculeaza_total();
            return rez;
        }

        //supraincarcarea operatorului+ pentru adaugarea toppingurilor
        public static Pizza operator+(Pizza p, String topping)
        {
            string[] topping_nou = new string[p.extra_topping.Length + 1];
            for(int i=0; i < p.extra_topping.Length; i++)
            {
                topping_nou[i] = p.extra_topping[i];
            }
            topping_nou[p.extra_topping.Length + 1] = topping;
            p.extra_topping = topping_nou;
            return p;
        }

        public string this[int index]
        {
            get
            {
                if (extra_topping != null && index >= 0 && index < extra_topping.Length)
                    return extra_topping[index];
                else return null;
            }
            set
            {
                if (value != null)
                {
                    extra_topping[index] = value;
                }
            }
        }
        
        public void sterge_pizza(int k, ListView lv)
        {
            if (k >= lv.Items.Count) throw new IndexOutOfRangeException();
            lv.Items.RemoveAt(k);
            if (k == lv.Items.Count) k--;
            
        }
    }
}
