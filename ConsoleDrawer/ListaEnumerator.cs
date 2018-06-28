using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDrawer
{
    public class ListaEnumerator<T> : IEnumerator<T>, IEnumerator
    {
        private readonly Lista<T> _lista;
        private int _indice;

        public ListaEnumerator(Lista<T> lista)
        {
            _lista = lista;
            _indice = -1;
        }

        public T Current
        {
            get
            {
                return _lista.GetAt(_indice);
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
       
        public bool MoveNext()
        {
            return  _indice++ < _lista.Count;
        }

        public void Reset()
        {
            _indice = 0;
        }

        public void Dispose()
        {

        }
    }
}
