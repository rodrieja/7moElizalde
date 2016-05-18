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
        Jugador jugador;
        private int _numeroGenerado;

        internal void InicializarJuego()
        {
            //Cargar archivo de parametría
            //Crear objeto Propiedades y completar los valores.
            prop = new Propiedades();
            jugador = new Jugador();
            _numeroGenerado = this.generarNumero();
        }

        private int generarNumero()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            return rnd.Next(prop.MaxNum);
        }

        internal void ComenzarJuego()
        {
            Console.Write("Ingrese Nombre del Jugador: ");
            jugador.Nombre = Console.ReadLine();
            jugador.Puntaje = 0;

            Console.Clear();
            Console.WriteLine("Bienvenido {0}", jugador.Nombre);
        }

        internal int SeleccionarOpcion()
        {
            int opcion = 0;
            bool respValida;

            do
            {
                MostrarOpciones();

                respValida = true;

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    respValida = false;
                }

                if (respValida)
                {
                    if (opcion > Enumeracion.GetInstance().OpcionesCount())
                    {
                        respValida = false;
                    }
                }

                if (!respValida)
                {
                    Console.Write("EL VALOR INGRESADO NO CORRESPONDE A UNA OPCION VALIDA...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!respValida);

            return (opcion - 1);
        }

        private static void MostrarOpciones()
        {
            Console.WriteLine("{0}- {1}", (int)Enumeracion.Opciones.IntentarNuevamente + 1, Enumeracion.Opciones.IntentarNuevamente);
            Console.WriteLine("{0}- {1}", (int)Enumeracion.Opciones.MostrarAyuda + 1, Enumeracion.Opciones.MostrarAyuda);
            Console.WriteLine("{0}- {1}", (int)Enumeracion.Opciones.MostrarMejorPuntaje + 1, Enumeracion.Opciones.MostrarMejorPuntaje);
            Console.WriteLine("{0}- {1}", (int)Enumeracion.Opciones.Rendirse + 1, Enumeracion.Opciones.Rendirse);
        }

        internal void RegistrarPuntaje()
        {
            if (jugador.Puntaje > prop.PuntajeRecord)
            {
                prop.PuntajeRecord = jugador.Puntaje;
                prop.NombreRecord = jugador.Nombre;
            }
        }

        internal void Finalizar()
        {
            prop.ActualizarRecord();
        }

        internal void MostrarAyuda()
        {
            Console.WriteLine("Valor a adivinar: {0}", this._numeroGenerado);
            if (jugador.NumeroSeleccionado < this._numeroGenerado)
                Console.Write("El valor ingresado es menor al número a adivinar");
            else
                Console.Write("El valor ingresado es mayor al número a adivinar");

            if (Math.Abs(jugador.NumeroSeleccionado - this._numeroGenerado) < prop.Distancia)
                Console.WriteLine(" y se encuentra a menos de {0} numeros.", prop.Distancia);
            else
                Console.WriteLine();

        }

        internal void MostrarMejorPuntaje()
        {
            Console.WriteLine("MEJOR PUNTAJE {0}: {1}", prop.NombreRecord, prop.PuntajeRecord);
        }

        internal bool AdivinarNumero()
        {
            bool _acerto = false;

            Console.Write("Ingrese el numero que cree se genero: ");
            jugador.NumeroSeleccionado = Convert.ToInt32(Console.ReadLine());

            jugador.IncrementarPuntaje();

            if (jugador.NumeroSeleccionado == this._numeroGenerado)
                _acerto = true;

            return _acerto;
        }

        internal void Reiniciar()
        {
            jugador.Puntaje = 0;
        }
    }
}
