using System;

namespace ConsoleDrawer
{
    public class Lista<T>
    {
        private readonly T[] _items;
        public int Count { get; private set;}
        public Lista(int limit)
        {
            _items = new T[limit];
            Count = 0;
        }

        public void Add (T item)
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
    }

}
