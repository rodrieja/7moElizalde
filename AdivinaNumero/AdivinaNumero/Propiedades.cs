using System;
using System.IO;

namespace AdivinaNumero
{
    internal class Propiedades
    {
        public int MaxNum { get; set; }
        public int Distancia { get; set; }
        public string NombreRecord { get; set; }
        public int PuntajeRecord { get; set; }
        private int _PuntajeOriginal;

        const string _archPropiedades = "juego.properties";

        public Propiedades()
        {
            StreamReader sr = File.OpenText(_archPropiedades);

            string linea;

            while ((linea = sr.ReadLine()) != null)
            {
                string[] p = linea.Split('=');

                if (p[0].ToUpper() == "MAXNUM")
                    MaxNum = Convert.ToInt32(p[1]);
                else if (p[0].ToUpper() == "DISTANCIA")
                    Distancia = Convert.ToInt32(p[1]);
                else if (p[0].ToUpper() == "NOMBRERECORD")
                    NombreRecord = p[1];
                else if (p[0].ToUpper() == "PUNTAJERECORD")
                {
                    PuntajeRecord = Convert.ToInt32(p[1]);
                    _PuntajeOriginal = PuntajeRecord;
                }
            }

            sr.Close();
        }

        internal void ActualizarRecord()
        {
            if (this.PuntajeRecord != this._PuntajeOriginal)
            {
                File.Delete(_archPropiedades);
                StreamWriter sw = File.CreateText(_archPropiedades);

                sw.WriteLine("MAXNUM={0}", this.MaxNum);
                sw.WriteLine("DISTANCIA={0}", this.Distancia);
                sw.WriteLine("NOMBRERECORD={0}", this.NombreRecord);
                sw.WriteLine("PUNTAJERECORD={0}", this.PuntajeRecord);

                sw.Close();
            }
        }
    }
}