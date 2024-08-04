using System;
using System.Collections.Generic;

namespace Lista_de_Peliculas_o_Series
{
    class program

    {
        static void Main(string[] args)
        {
            List<string> Pelis = new List<string>();

            Console.WriteLine("Lista de Peliculas");

            Pelis.Add("Alerta Roja");
            Pelis.Add("La Momia 3");
            Pelis.Add("El Elegido");
            Pelis.Add("El Dragon");
            Pelis.Add("Avenger: Infinite War");
            Pelis.Add("John Wick: Parabellum");
            Pelis.Add("El Viaje de Chihiro");
            Pelis.Add("Orgullo y Prejucio");
            Pelis.Add("Scream");
            Pelis.Add("La Otra Missy");
            Console.WriteLine();
            foreach (string movie in Pelis)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();
            Console.WriteLine("insertar una pelicula en la posicion #2 de la lista");
            Console.WriteLine();
            Pelis.Insert(1, Console.ReadLine());
            Console.WriteLine("****************************");

            Console.WriteLine();
            foreach (string cine in Pelis)
            {
                Console.WriteLine(cine);
            }
            Console.WriteLine();
            Console.WriteLine("*****************************");
            Console.WriteLine("Busca una pelicula");
            Console.WriteLine("\nPelicula a encontrar (\"Piratas del Caribe\")");
            Console.WriteLine(Pelis.Contains("Piratas del Caribe"));
            Console.WriteLine();
            //Nota: trate de que este paso me lo pidera por taclado pero no pude, no encontre ningun metodo para hacerlo.
            //Asi que lo hice mas o menos como lo enseñó en clase.
            Console.WriteLine("**************************");
            foreach (string cine in Pelis)
            {
                Console.WriteLine(cine);
            }
            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine("Deseas Eliminar una pelicula elemento? si=1 No=2");
            int si = Convert.ToInt32(Console.ReadLine());

            if (si <= 1)
            {
                Console.WriteLine("Que pelicula deceas eliminar?");
                Pelis.Remove(Console.ReadLine());
                Console.WriteLine("El elemento ha sido eliminado");
            }
            else
            {
                Console.WriteLine("Ninguna pelicula se ha eliminado");
            }
            

            Console.WriteLine();
            Console.WriteLine("****************************");
            foreach (string cine in Pelis)
            {
                Console.WriteLine(cine);
            }
        }
    }
}
