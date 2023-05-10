namespace VMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarritoDeCompras carrito = new CarritoDeCompras();
            VistaCarritoDeCompras vista = new VistaCarritoDeCompras(carrito);
            ControladorCarritoDeCompras controlador = new ControladorCarritoDeCompras(vista);
            controlador.Ejecutar();
        }
    }
}
