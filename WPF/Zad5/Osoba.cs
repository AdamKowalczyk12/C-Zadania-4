using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Osoba
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }

        public Osoba(int id, string imie, string nazwisko, int wiek)
        {
            this.ID = id;
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}, {2} ({3} lat)", this.ID, this.Nazwisko, this.Imie, this.Wiek);
        }
    }
}