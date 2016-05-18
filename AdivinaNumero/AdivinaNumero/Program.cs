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
            
            juego.InicializarJuego();
            juego.ComenzarJuego();

            bool finalizar = juego.AdivinarNumero();
            int opcion;

            if (finalizar)
            {
                Console.WriteLine("FELICITACIONES. ACERTASTE EN EL PRIMER INTENTO...");
            }

            while (!finalizar)
            {
                opcion = juego.SeleccionarOpcion();
                switch (opcion)
                {
                    case (int)Enumeracion.Opciones.MostrarAyuda:
                        juego.MostrarAyuda();
                        break;
                    case (int)Enumeracion.Opciones.MostrarMejorPuntaje:
                        juego.MostrarMejorPuntaje();
                        break;
                    case (int)Enumeracion.Opciones.Rendirse:
                        finalizar = true;
                        break;
                    case (int)Enumeracion.Opciones.IntentarNuevamente:
                        finalizar = juego.AdivinarNumero();
                        break;
                    default:
                        break;
                }

                if (finalizar)
                {
                    juego.RegistrarPuntaje();

                    Console.WriteLine("Desea volver a Jugar? (SI/NO)");
                    if (Console.ReadLine().ToUpper() == "SI")
                    {
                        finalizar = false;
                        juego.Reiniciar();
                    }
                }
            }

            juego.Finalizar();

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
