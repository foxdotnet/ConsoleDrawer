using System;

namespace ConsoleDrawer
{
    public class Lista
    {
        private readonly object[] _items;
        public int Count { get; private set;}
   
        public Lista(int limit)
        {
            _items = new object[limit];
            Count = 0;
        }

        public void Add (object item)
        {
            if (this.Count == _items.Length)
            {
                throw new InvalidOperationException();
            }
            _items[this.Count] = item;
            this.Count++;
         }

        public object GetAt(int idx)
        {
            return _items[idx];
        }
    }
}
