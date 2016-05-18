using System;

namespace AdivinaNumero
{
    internal class Jugador
    {
        public string Nombre { get; internal set; }
        public int Puntaje { get; set; }
        public int NumeroSeleccionado { get; set; }

        internal void IncrementarPuntaje()
        {
            this.Puntaje++;
        }
    }
}