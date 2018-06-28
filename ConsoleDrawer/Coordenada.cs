
namespace ConsoleDrawer
{
    public struct Coordenada
    {
        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }
        public  Coordenada(int x)
        {
            X = x;
            Y = 0;//TODO
        }
        public int X { get; set; }
        public int Y { get; set; }

        public void Validar()
        {
            return;
        }
    }
}