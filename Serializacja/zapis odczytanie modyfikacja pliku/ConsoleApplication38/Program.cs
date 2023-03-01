using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
            string path = @"C:\Users\Filip\Desktop\sheets\dane.txt";
            Plik p = new Plik();
            p.Zapisz(path, 1, 5);
            p.Modyfikuj(path);
            
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
