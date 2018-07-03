using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDrawer
{
    public class FiguraFactory
    {
        private int _numCuadrados;
        private int _numTextos;

        private static FiguraFactory _instance;
        public static FiguraFactory Instance {
            get { return _instance; }
        }
        static FiguraFactory()
        {
            _instance = new FiguraFactory();
        }
        private FiguraFactory()
        {
            _numCuadrados = 0;
            _numTextos = 0;
        }
        public Cuadrado GetCuadrado(int fila, int columna)
        {
            return new Cuadrado($"Cuadrado_{_numCuadrados++} en fila {fila} y columna {columna}", fila, columna);
        }
        public Texto GetTexto(int fila, int columna, string texto)
        {
            return new Texto($"Texto{_numTextos++} en fila {fila} y columna {columna}", fila, columna,texto);
        }
    }
}
