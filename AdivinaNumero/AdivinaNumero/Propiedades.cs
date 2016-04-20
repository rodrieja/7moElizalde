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
                    PuntajeRecord = Convert.ToInt32(p[1]);
            }

            sr.Close();
        }
    }
}