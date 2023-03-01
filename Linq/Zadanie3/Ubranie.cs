using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    public class Ubranie
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Producent { get; set; }
        public decimal Cena { get; set; }
        public string Kategoria { get; set; }
        public string Podkategoria { get; set; }

        public Ubranie(int id, string kod, string producent, decimal cena, string kategoria, string podkategoria)
        {
            Id = id;
            Kod = kod;
            Producent = producent;
            Cena = cena;
            Kategoria = kategoria;
            Podkategoria = podkategoria;
        }

        public Ubranie()
        {

        }

        public override string ToString()
        {
            return $"{Id} \t {Kod} \t {Producent} \t {Cena} \t {Kategoria} \t {Podkategoria}";
        }
    }
}
