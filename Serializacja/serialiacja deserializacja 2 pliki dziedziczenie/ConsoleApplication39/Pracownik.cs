using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    public class Pracownik : Osoba
    {
        public List<string> PrzeczytaneKsiazki { get; set; }
        public string StazPracy { get; set; }
        public Pracownik() { }
        public Pracownik(string imie, string nazwisko, string wiek, string stazpracy ): base(imie, nazwisko, wiek)
        {
            this.StazPracy = stazpracy;
            this.PrzeczytaneKsiazki = new List<string>();
        }
        public void DodajKsiazke(params string[] ksiazka)
        {
            List<string> lst = this.PrzeczytaneKsiazki;
            lst.AddRange(ksiazka);
            this.PrzeczytaneKsiazki = lst;
        }
    }
}
