
namespace ConsoleDrawer
{
    public abstract class Figura
    {
        //public long Fila { get; }
        //public long Columna { get; }
        public Coordenada Posicion { get; }
        public string  Nombre { get; }

        public Figura(string nombre, int fila, int columna)
        {
            Nombre = nombre;
            Posicion = new Coordenada(fila, columna);
        }
        public abstract void Dibujar();

    }
}
