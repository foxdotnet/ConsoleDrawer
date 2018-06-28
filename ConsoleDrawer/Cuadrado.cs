using System;

namespace ConsoleDrawer
{

    public class Cuadrado : Figura, IFigura
    {
        public int Lado {get;private set;}
        public Cuadrado(int fila, int columna, int lado) : base(fila, columna)
        {
            this.Lado = lado;
        }
 

        public override void Dibujar()
        {
            Console.SetCursorPosition(this.Posicion.X, this.Posicion.Y);
            Console.WriteLine("Dibujar un cuadrado");//TODO
        }
    }
}
