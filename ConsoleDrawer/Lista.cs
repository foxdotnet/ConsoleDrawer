using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleDrawer
{
    public class Lista<T> : ILista<T>, ILista
    {
        private readonly T[] _items;
        public int Count { get; private set; }
        public Lista(int limit)
        {
            _items = new T[limit];
            Count = 0;
        }

        public void Add(T item)
        {
            if (this.Count == _items.Length)
            {
                throw new InvalidOperationException();
            }
            _items[this.Count] = item;
            this.Count++;
        }

        public T GetAt(int idx)
        {
            return _items[idx];

        }


        void ILista.Add(object item)
        {
            Add((T)item);
        }

        object ILista.GetAt(int idx)
        {
            return _items[idx];

        }
        #region  IEnumerable<T>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new ListaEnumerator<T>(this);
        }

        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }

       
        #endregion
    }

}
