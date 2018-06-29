using System.Collections.Generic;

namespace ConsoleDrawer
{
    public interface ILista<T>:IEnumerable<T>
    {
        int Count { get; }
        void Add(T item);
        T GetAt(int idx);
        IEnumerable<T> FindPredicate(IPredicate<T> predicate);
        IEnumerable<T> FindDelegate(PredicateDelegate<T> predicate);
    }

    public interface ILista
    {
        int Count { get; }
        void Add(object item);
        object GetAt(int idx);
       
    }
    
}
