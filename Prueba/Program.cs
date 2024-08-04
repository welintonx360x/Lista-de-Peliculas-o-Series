using System;
using System.Collections.Generic;

namespace Prueba
{
    class pelis
    {
        static void Main(string[] args)
        {
            List<string> movie = new List<string>();

            Console.WriteLine("Lista de 10 peliculas");
            Console.WriteLine();

            movie.Add(new Pelis() { PartName = "crank arm", PartId = 01 });
            movie.Add(new Pelis() { PartName = "chain ring", PartId = 02 });
            movie.Add(new Pelis() { PartName = "regular seat", PartId = 03 });
            movie.Add(new Pelis() { PartName = "banana seat", PartId = 04 });
            movie.Add(new Pelis() { PartName = "cassette", PartId = 05 });
            movie.Add(new Pelis() { PartName = "shift lever", PartId = 06 });
            movie.Add(new Pelis() { PartName = "crank arm", PartId = 07 });
            movie.Add(new Pelis() { PartName = "crank arm", PartId = 08 });
            movie.Add(new Pelis() { PartName = "crank arm", PartId = 09 });
            movie.Add(new Pelis() { PartName = "crank arm", PartId = 1 });

            Console.WriteLine();
            foreach (var Pelis in moviee)
            {
                Console.WriteLine(Pelis);
            }
            Console.WriteLine("\nContains(\"1734\"): {0}",
            movie.Contains(new Pelis { PartId = 11, PartName = "" }));

            // Insert a new item at position 2.
            Console.WriteLine("\nInsert(2, \"02.2\")");
            movie.Insert(2, new Pelis() { PartName = "Dragon Ball super: Broly", PartId = 02.2 });

            //Console.WriteLine();
            foreach (var Pelis in movie)
            {
                Console.WriteLine(Pelis);
            }

            Console.WriteLine("\nParts[3]: {0}", movie[3]);

            Console.WriteLine("\nRemove(\"03\")");

            // This will remove part 1534 even though the PartName is different,
            // because the Equals method only checks PartId for equality.
            movie.Remove(new Pelis() { PartId = 06, PartName = "cogs" });

            Console.WriteLine();
            foreach (var Pelis in movie)
            {
                Console.WriteLine(Pelis);
            }
            Console.WriteLine("\nRemoveAt(3)");
            // This will remove the part at index 3.
            movie.RemoveAt(3);

            Console.WriteLine();
            foreach (var Pelis in movie)
            {
                Console.WriteLine(Pelis);
            }
        }
    }
}
