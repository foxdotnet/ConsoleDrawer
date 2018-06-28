
namespace ConsoleDrawer
{
    public abstract class Figura
    {
        //public long Fila { get; }
        //public long Columna { get; }
        public Coordenada Posicion { get;}
        public Figura(int fila, int columna)
        {

            Posicion = new Coordenada(fila, columna);
        }
        public abstract void Dibujar();

    }
}
