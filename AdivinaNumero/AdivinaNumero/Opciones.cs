using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaNumero
{
    public class Enumeracion
    {
        private static Enumeracion instance = null;

        private int _OpcionesCount;

        private Enumeracion()
        {
            this._OpcionesCount = 4;
        }
        
        public static Enumeracion GetInstance()
        {
            if (instance == null)
            {
                instance = new Enumeracion();
            }

            return instance;
        }

        public int OpcionesCount()
        {
            return _OpcionesCount;
        }

        public enum Opciones
        {
            IntentarNuevamente,
            MostrarAyuda,
            MostrarMejorPuntaje,
            Rendirse
        }
    }
}
