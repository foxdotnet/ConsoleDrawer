using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDrawer
{
    public static  class ListaExtensions
    {
        public static object GetFirst<T>(this ILista<T> lista)
        {
            if (lista == null)
            {
                return default(T);
            }
            return lista.GetAt(0);
        }
    }
}
