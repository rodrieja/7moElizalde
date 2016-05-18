namespace EjemploOrdenamientoDeListas
{
    internal class Puntaje
    {
        public int valor { get; set; }
        public string nombre { get; set; }

        public Puntaje(string nombre, int valor)
        {
            this.valor = valor;
            this.nombre = nombre;
        }
    }
}