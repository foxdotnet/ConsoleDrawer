using System;

namespace ConsoleDrawer
{

    public class Texto : Figura, IFigura
    {
        private readonly string _texto;

        public Texto(int fila, int columna, string texto = "Inserte su texto aquí...") : base(fila, columna)
        {
            _texto = texto ?? string.Empty;
        }


        public override void Dibujar()
        {
            Console.SetCursorPosition(this.Posicion.X, this.Posicion.Y);
            Console.WriteLine(_texto);
        }
    }
}
