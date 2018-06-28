using System.Diagnostics;
namespace ConsoleDrawer
{
    public class Dibujo
    {
        private Lista<IFigura> _figuras;

        
        public Dibujo()
        {
            _figuras = new Lista<IFigura> (10);
            //_figuras[0] = new Texto(10, 5, "Dibujando texto en consola...");
            _figuras.Add( new Texto(10, 5));
            var lista2 = new Lista<Texto>(29);
            lista2.Add(new Texto(55, 44, ""));
            this.Foo(lista2);
            this.Dibujar();

           }
        public int Foo(Lista<IFigura> param)
        {
            return param.Count;
        }
        public void Dibujar()
        {
            for ( int i = 0; i < _figuras.Count; i++)
            {
                Debug.WriteLine("i = " + i);
                ((Figura)_figuras.GetAt(i)).Dibujar();
            }

            //foreach (Figura figura in _figuras)
            //{
            //    figura?.Dibujar();
            //}
            Debug.Flush();
        }
    }
}
