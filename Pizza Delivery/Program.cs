using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Delivery
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Pizza p1 = new Pizza("Margherita", new string[1] { "Masline" });
            float pret1 = p1.calculeaza_dupa_nume();
            float pret = p1.calculeaza_total();
            Console.WriteLine(pret1 + " " +pret);

            Pizza p2 = (Pizza)p1.Clone();

            List<Pizza> comanda = new List<Pizza>();
            Client c1 = new Client("Theo", "Cash", "0785537274", comanda);
            comanda = c1.plaseaza_comanda(new Pizza[2] { p1, p2 });
            foreach(Pizza p in comanda)
            {
                Console.WriteLine(p.ToString());
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
