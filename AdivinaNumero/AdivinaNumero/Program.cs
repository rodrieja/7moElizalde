using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();
            Jugador jugador = new Jugador();

            juego.InicializarJuego();
            juego.ComenzarJuego(jugador);

            bool continuar = true;
            int opcion;

            while (continuar)
            {
                opcion = juego.SeleccionarOpcion();
                switch (opcion)
                {
                    case (int)Opciones.MostrarAyuda:
                        juego.MostrarAyuda();
                        break;
                    case (int)Opciones.MostrarMejorPuntaje:
                        juego.MostrarMejorPuntaje();
                        break;
                    case (int)Opciones.Rendirse:
                        continuar = false;
                        break;
                    case (int)Opciones.IntentarNuevamente:
                        continuar = juego.AdivinarNumero(jugador);
                        break;
                    default:
                        break;
                }

                if (!continuar)
                {
                    Console.WriteLine("Desea volver a Jugar? (SI/NO)");
                    if (Console.ReadLine().ToUpper() == "SI")
                    {
                        continuar = true;
                        juego.Reiniciar(jugador);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
