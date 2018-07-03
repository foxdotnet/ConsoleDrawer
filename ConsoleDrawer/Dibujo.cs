﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace ConsoleDrawer
{
    public class Dibujo
    {
        private List<IFigura> _figuras;

        public Dibujo()
        {
            //this.Pruebas()
            _figuras = new List<IFigura>(10);
            Dibujar();
        }

        public void AddFigura(IFigura figura)
        {
            _figuras.Add(figura);
        }

        public void Dibujar()
        {
            foreach (Figura figura in _figuras)
            {
                figura?.Dibujar();
            }
        }

        private void Pruebas()
        {
            Console.WriteLine("Lista enteros:");
            var listaInt = new Lista<int>(8);
            listaInt.Add(4);
            listaInt.Add(13);
            listaInt.Add(9);
            listaInt.Add(25);
            listaInt.Add(14);
            //Búsqueda con delegado de función nombrada
            this.BuscarImpares(listaInt);
            //Búsqueda con delegado a función anónima
            this.BuscarPares(listaInt);
            //Métodos de extensión
            string texto = "a2321";
            Console.WriteLine("Es numero: " + StringUtils.IsNumber(texto).ToString());
            Console.WriteLine("Es numero: " + texto.IsNumber().ToString());
            Console.WriteLine("Primer numero par: " + listaInt.GetFirst().ToString());
            Console.WriteLine("Por indice (2): " + listaInt[2]);
        }

        private void BuscarImpares(Lista<int> lista)
        {
            ////Delegado de función declarada en la clase PredicateIntOdd
            //var listaImpares = lista.FindPredicate(new PredicateIntOdd());

            ////Delegado a  una función IsOdd, declarada en la clase actual
            //var listaImpares = lista.FindDelegate(IsOdd);

            ////Delegado anónimo
            //PredicateDelegate<int> _isOdd = delegate (int i) { return i % 2 != 0;};
            //var listaImpares = lista.FindDelegate(_isOdd);

            ////Delegado con lambda
            ////PredicateDelegate<int> _isOdd = i => i % 2 != 0;
            ////var listaImpares = lista.FindDelegate(_isOdd);
            //var listaImpares = lista.FindDelegate(i => i % 2 != 0);

            //Delegado generico Func
            //Func<int, bool> _isOdd = i => i % 2 != 0;
            //var listaImpares = lista.FindDelegate(_isOdd);
            var listaImpares = lista.FindFunc(i => i % 2 != 0);
            Console.WriteLine("Impares:");
            foreach (var item in listaImpares)
            {
                Console.WriteLine("- " + item.ToString());
            }

        }

        private bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        private void BuscarPares(Lista<int> lista)
        {
            //Delegado anónimo
            PredicateDelegate<int> paresDelegate = delegate (int i) { return i % 2 == 0; };
            var listaPares = lista.FindDelegate(paresDelegate);
            Console.WriteLine("Pares:");
            foreach (var item in listaPares)
            {
                Console.WriteLine("- " + item.ToString());
            }
        }

       
    }
}
