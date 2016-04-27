using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaNumero
{
    class Juego
    {
        Propiedades prop;

        internal void InicializarJuego()
        {
            //Cargar archivo de parametría
            //Crear objeto Propiedades y completar los valores.
            prop = new Propiedades();
        }

        internal void ComenzarJuego(Jugador jugador)
        {
            Console.Write("Ingrese Nombre del Jugador: ");
            jugador.Nombre = Console.ReadLine();
            jugador.Puntaje = 0;
        }

        internal int SeleccionarOpcion()
        {
            Console.WriteLine("{0}- {1}",(int)Opciones.IntentarNuevamente + 1, Opciones.IntentarNuevamente);
            Console.WriteLine("{0}- {1}", (int)Opciones.MostrarAyuda + 1, Opciones.MostrarAyuda);
            Console.WriteLine("{0}- {1}", (int)Opciones.MostrarMejorPuntaje + 1, Opciones.MostrarMejorPuntaje);
            Console.WriteLine("{0}- {1}", (int)Opciones.Rendirse + 1, Opciones.Rendirse);

            return (Convert.ToInt32(Console.ReadLine()) - 1); 
        }

        internal void MostrarAyuda()
        {
            throw new NotImplementedException();
        }

        internal void MostrarMejorPuntaje()
        {
            Console.WriteLine("MEJOR PUNTAJE {0}: {1}", prop.NombreRecord, prop.PuntajeRecord);
        }

        internal bool AdivinarNumero(Jugador j)
        {
            throw new NotImplementedException();
        }

        internal void Reiniciar(Jugador jugador)
        {
            throw new NotImplementedException();
        }
    }
}
