using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleDrawer
{
    public delegate bool PredicateDelegate<T> (T item);

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
            //return new ListaEnumerator<T>(this);
            foreach (var item in _items)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<T> FindPredicate( IPredicate<T> predicado)
        {
           foreach (var item in _items)
            {
                if (item != null && predicado.Match(item))
                {
                    yield return item;
                }
            }
        }

        public IEnumerable<T> FindDelegate(PredicateDelegate<T> predicado)
        {
            foreach (var item in _items)
            {
                if (item != null && predicado(item))
                {
                    yield return item;
                }
            }
        }

        public IEnumerable<T> FindFunc(Func<T,bool> predicado)
        {
            foreach (var item in _items)
            {
                if (item != null && predicado(item))
                {
                    yield return item;
                }
            }
        }

        #endregion
        //Indizador
        public T this [int idx]
        {
            get { return _items[idx]; }
        }
    }

}
