using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_2
{
    class Program
    {
        static void Main(string[] args)

        {   /* a)
            List<string> biegacze =
            new List<string> { "Ania", "Tomek", "Jola", "Adam", "Jan" };
            List<string> plywacy =
            new List<string> { "Tomek", "Adam", "Robert", "Tomek" };

            IEnumerable<string> both = biegacze.Intersect(plywacy);

            foreach (string id in both)
                Console.WriteLine(id);

        
        */
            /* b)
            List<string> biegacze =
           new List<string> { "Ania", "Tomek", "Jola", "Adam", "Jan" };
            List<string> plywacy =
            new List<string> { "Tomek", "Adam", "Robert", "Tomek" };

            IEnumerable<string> both = biegacze.Except(plywacy);

            foreach (string id in both)
                Console.WriteLine(id);
        
           */ //c)
            List<string> biegacze =
            new List<string> { "Ania", "Tomek", "Jola", "Adam", "Jan" };
            List<string> plywacy =
            new List<string> { "Tomek", "Adam", "Robert", "Tomek" };


            var dziewczyny = from elements in biegacze
                            where elements.EndsWith("a")
                            select elements;

            IEnumerable<string> both = dziewczyny.Union(plywacy);

            var dziewczyny2 = dziewczyny
            .OrderBy(word => word);

            var chlopacy2 = plywacy.Distinct().ToList()
            .OrderBy(word => word);

            Console.WriteLine("Dziewczyny:");
            foreach (string id in dziewczyny2)
            {
               
                Console.WriteLine(id);
            }
            Console.WriteLine("==============");
            Console.WriteLine("Chłopacy:");
            foreach (string id in chlopacy2)
            {
               
                Console.WriteLine(id);
            }
           
        }
    }
}
