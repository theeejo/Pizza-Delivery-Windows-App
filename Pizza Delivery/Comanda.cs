using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery
{
    public class Comanda : ICloneable
    {
        public Client client;
        public List<Produs> produse = new List<Produs>();


       // public event EventHandler ev_modificare;

        public Comanda() { client = new Client(); produse = new List<Produs>(); }
        public Comanda(Client _client, List<Produs> _produse) 
        {
            client = _client;
            produse = _produse;
        }

        public int Numar_comenzi => produse.Count;

        public Comanda(Comanda cob)
        {
            produse = new List<Produs>();
            foreach (Produs temp in cob.produse) cob.Add(temp.Clone());
        }

        public void Add(object p)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            return new Comanda(this);
        }

        public static Comanda operator+(Comanda cf, Produs ps)
        {
            cf.produse.Add(ps);
            return cf;
        }

        public Produs this[int k]
        {
            get
            {
                if (k > produse.Count) throw new IndexOutOfRangeException();
                return produse[k];
            }
            set
            {
                if (k >= produse.Count) throw new IndexOutOfRangeException();
                if (produse[k] != value)
                {
                    produse[k] = value;
                    
                }
            }
        }

        public void sterge_produs(int k)
        {
            if (k >= produse.Count) throw new IndexOutOfRangeException();
            produse.RemoveAt(k);
            if (k == produse.Count) k--;
            
        }

        


    }

    
}
