using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\Filip\Desktop\sheets\osoby.xml";
                Pracownik p1 = new Pracownik("Filip", "Kubat", "12", "5");
                Pracownik p2 = new Pracownik("Filip", "kowalski", "12", "5");
                Pracownik p3 = new Pracownik("Filip", "nowak", "12", "5");
                Pracownik p4 = new Pracownik("Filip", "Kubat", "12", "5");
                List<Osoba> pracownicy = new List<Osoba>();
                pracownicy.Add(p1);
                pracownicy.Add(p2);
                pracownicy.Add(p3);
                pracownicy.Add(p4);
                OsobaKontener ok = new OsobaKontener();
                ok.osoby = pracownicy;
                ok.Zapisz(path);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
