using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication38
{
    public class Plik
    {
        public string tresc { get; set; }
        public Plik() 
        { 
            
        }

        public void Zapisz(string path, int a,int b)
        {

            StreamWriter sw = new StreamWriter(path);
            for(int i =a; i<=b; i++)
            {
                sw.WriteLine("{0};{1}", i, i * i);
            }
            sw.Close();
        }
        public void Odczytaj(string path) //readalltext
        {
            if (File.Exists(path) != false)
            {
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            else
                Console.WriteLine("Plik nie istnieje");
        }
        //public void Odczytaj(string path) //streamreader
        //{
        //    StreamReader sr = new StreamReader(path);
        //    string linia;
        //    string[] wartosc;
        //    while((linia=sr.ReadLine())!= null)
        //    {
        //        wartosc = linia.Split(';');
        //        Console.WriteLine("Wartosc {0} do kwadratu wynosi {1}", wartosc[0], wartosc[1]);
        //    }
        //    sr.Close();
        //}
        public void Modyfikuj (string path)
        {
            if (File.Exists(path) != false)
            {
                
                string nowytekst;
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
                Console.WriteLine("Podaj nową zawartość pliku");
                nowytekst = Console.ReadLine();
                StreamWriter sw = new StreamWriter(path);
                sw.Write(nowytekst);
                sw.Close();
                Console.WriteLine("Dane zostały zmodyfikowane.");
            }
            else
                Console.WriteLine("Plik nie istnieje");

        }
    }

}
