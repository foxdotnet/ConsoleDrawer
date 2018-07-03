
namespace ConsoleDrawer
{
    public interface IFigura
    {
        void Dibujar();
        Coordenada Posicion  { get; }
        string Nombre { get; }
    }
}
