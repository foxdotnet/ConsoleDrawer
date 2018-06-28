using System.Diagnostics;
namespace ConsoleDrawer
{
    public class Dibujo
    {
        private ILista<IFigura> _figuras;

        public Dibujo()
        {
            _figuras = new Lista<IFigura>(10);
            //_figuras[0] = new Texto(10, 5, "Dibujando texto en consola...");
            _figuras.Add(new Texto(10, 5));
            _figuras.Add(new Cuadrado(20, 30, 4));

            this.Dibujar();
        }
    
        public void Dibujar()
        {
            //for (int i = 0; i < _figuras.Count; i++)
            //{
            //    Debug.WriteLine("i = " + i);
            //    ((Figura)_figuras.GetAt(i)).Dibujar();
            //}

            foreach (Figura figura in _figuras)
            {
                figura?.Dibujar();
            }
            Debug.Flush();
        }
    }
}
