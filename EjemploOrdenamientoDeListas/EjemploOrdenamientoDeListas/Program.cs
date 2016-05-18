using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploOrdenamientoDeListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Puntaje> puntajes = new List<Puntaje>();

            puntajes.Add(new Puntaje("pepe", 60));
            puntajes.Add(new Puntaje("juan", 9));
            puntajes.Add(new Puntaje("pedro", 25));
            puntajes.Add(new Puntaje("jose", 10));
            
            foreach (var p in puntajes)
            {
                Console.WriteLine("{0}: {1}", p.nombre, p.valor);
            }

            Console.WriteLine("PUNTAJE ORDENADO ASCENDENTE");

            foreach (var p in puntajes.OrderBy(pepe => pepe.valor).ToList())
            {
                Console.WriteLine("{0}: {1}", p.nombre, p.valor);
            }

            Console.WriteLine("PUNTAJE ORDENADO DESCENDENTE");

            foreach (var p in puntajes.OrderByDescending(pepe => pepe.valor).ToList())
            {
                Console.WriteLine("{0}: {1}", p.nombre, p.valor);
            }

            Console.ReadKey();
        }
    }
}
