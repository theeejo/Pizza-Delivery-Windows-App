using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery
{
    public interface IComanda
    {
        float calculeaza_comanda(List<Pizza>comanda);
    }
}
