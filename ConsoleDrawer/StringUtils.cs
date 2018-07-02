using System;
using System.Text;

namespace ConsoleDrawer
{
    public static class StringUtils
    {
        public static bool IsNumber(this string cadena)
        {
            if (string.IsNullOrEmpty(cadena)) return false;
            foreach (Char c in cadena)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
