using System;

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
                    var dibujo = new Dibujo();
                    dibujo.AddFigura(new Texto ("texto0", 23,8, "Antes del factory"));
                    for (int i = 0; i < 9; i++)
                    {
                        dibujo.AddFigura(FiguraFactory.Instance.GetCuadrado (i  , 3 * i));
                    }
                    dibujo.Dibujar();
                    //Probando indíce
                    dibujo.GetByNombre<IFigura>("texto0").Dibujar();
                    //Guadar a Newtonsoft.Json
                    dibujo.Guardar( @"dibujo.json"); 
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


