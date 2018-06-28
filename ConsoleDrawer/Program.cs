﻿using System;

namespace ConsoleDrawer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resp = false;
            do
            {
                resp = DrawMenu();
            } while (!resp);
            Console.WriteLine("FIN APP MAIN");
            Console.Read();
        }

        static bool DrawMenu()
        {
            Console.WriteLine("1- Nuevo dibujo");
            Console.WriteLine("2- Salir");

            ConsoleKeyInfo info = Console.ReadKey();
            bool resp = true;
            switch (info.Key)
            {
                case (ConsoleKey.NumPad1):
                    new Dibujo();
                        break;
                case (ConsoleKey.NumPad2):
                    Console.WriteLine("DOS");
                    break;
                default:
                    Console.WriteLine("Pulsar la tecla [1,2] "); 
                    resp = false;
                    break;
            }
            return resp;
        }
    }
}

