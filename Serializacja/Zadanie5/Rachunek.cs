using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    public class Rachunek
    {
        public string Numer { get; set; }
        public DateTime Data { get; set; }

        public List<Towar> listaTowarow { get; set; }
    }
}
