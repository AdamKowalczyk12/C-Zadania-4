using System;
using System.Collections.Generic;
using System.Linq;

namespace ling_zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            a)
            int[] tab = { 1, 12, 32, 12, 32, 4, 11, 23, 4, 19, 22, 85, 68, 45, 66, 5, 76, 56, 90, 10, 28 };
            int max;
            int min;
            int MaxIMin = tab.Length;
            max = tab[0];
            min = tab[0];
            foreach (int i in tab)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }
           
            IEnumerable<int> sekwencjaA =
                tab.Where(n => max - n < 25) 
                .OrderBy(n => -n);
            
            foreach (int tekst in sekwencjaA)
            {
                Console.Write(tekst + " ");
                // Wypisze: dwa pi�� dziesi�� dziewi�� pi�tna�cie
            }
            Console.ReadKey();
            //*/
            
            //int[] tab = { 1, 12, 32, 12, 32, 4, 11, 23, 4, 19, 22, 85, 68, 45, 66, 5, 76, 56, 90, 10, 28 };
           
            //IEnumerable<int> sekwencjaA
            //    = tab.AsQueryable().Distinct()
            //    .OrderBy(n => n)
            //    .Take(10);

            //foreach (int tekst in sekwencjaA)
            //{
            //    Console.Write(tekst + " ");
            //    // Wypisze: dwa pi�� dziesi�� dziewi�� pi�tna�cie
            //}

          
            int[] tab = { 1, 12, 32, 12, 32, 4, 100, 23, 4, 19, 22, 85, 68, 45, 66, 5, 76, 56, 90, 10, 28 };

            var grupy=
            tab.GroupBy(n => n.ToString().Length)
            .Select(n => n.ToList().OrderBy(num => num))
            .ToList();

            grupy.ForEach(numslist =>
            {
                Console.WriteLine(numslist.First().ToString().Length + ":");
                numslist.ToList().ForEach(num =>
                {
                    Console.WriteLine(num);
                });
                Console.WriteLine("----------------------------------");
            });
            
        }
    }
}
