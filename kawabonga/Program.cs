using System;
using System.Collections.Generic;
public class Pelis : IEquatable<Pelis>
{
    public string PartName { get; set; }

    public int PartId { get; set; }

    public override string ToString()
    {
        return "ID: " + PartId + "   Name: " + PartName;
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        Pelis objAsPart = obj as Pelis;
        if (objAsPart == null) return false;
        else return Equals(objAsPart);
    }
    public override int GetHashCode()
    {
        return PartId;
    }
    public bool Equals(Pelis other)
    {
        if (other == null) return false;
        return (this.PartId.Equals(other.PartId));
    }
    // Should also override == and != operators.
}
public class Example
{
    public static void Main()
    {
        // Create a list of parts.
        List<Pelis> movie = new List<Pelis>();

        movie.Add(new Pelis() { PartName = "La Otra Mussy", PartId = 1234 });
        movie.Add(new Pelis() { PartName = "Orgullo y Prjucio", PartId = 1334 });
        movie.Add(new Pelis() { PartName = "La Princesa Y el Sapo", PartId = 1434 });
        movie.Add(new Pelis() { PartName = "Alerta Roja", PartId = 1444 });
        movie.Add(new Pelis() { PartName = "Cara Cortada", PartId = 1534 });
        movie.Add(new Pelis() { PartName = "John Wick", PartId = 1634 });
        movie.Add(new Pelis() { PartName = "El Padrino", PartId = 1734 });
        movie.Add(new Pelis() { PartName = "Scram", PartId = 1834 });
        movie.Add(new Pelis() { PartName = "El Cisne Negro", PartId = 1934 });
        movie.Add(new Pelis() { PartName = "El Viaje de Chihiro", PartId = 2034 });
        Console.WriteLine();
        foreach (Pelis cine in movie)
        {
            Console.WriteLine(cine);
        }

        // Insert a new item at position 2.
        Console.WriteLine();
        Console.WriteLine("Inserte una pelicula");
        Console.WriteLine("\nInsert(2, \"1834\")");
        movie.Insert(2, new Pelis() { PartName = "brake lever", PartId = 1834 });

        //Console.WriteLine();
        foreach (Pelis cine in movie)
        {
            Console.WriteLine(cine);
        }

        Console.WriteLine("\nPelis[3]: {0}", movie[3]);

        Console.WriteLine("\nRemove(\"1534\")");

        Console.WriteLine();

        Console.WriteLine("\nContains(\"2134\"): {0}",
movie.Contains(new Pelis { PartId = 2134, PartName = "" }));
        Console.WriteLine();
        foreach (Pelis cine in movie)
        {
            movie.Remove(new Pelis() { PartId = 1534, PartName = "cogs" });
        }

        Console.WriteLine();
        foreach (Pelis cine in movie)
        {
            Console.WriteLine(cine);
        }
        Console.WriteLine("\nRemoveAt(3)");
        // This will remove the part at index 3.
        movie.RemoveAt(3);

        Console.WriteLine();
        foreach (Pelis cine in movie)
        {
            Console.WriteLine(cine);
        }
    }
}