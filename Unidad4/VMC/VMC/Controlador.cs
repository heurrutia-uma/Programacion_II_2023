using System;

namespace VMC
{
    public class ControladorCarritoDeCompras
    {
        private VistaCarritoDeCompras _vista;

        public ControladorCarritoDeCompras(VistaCarritoDeCompras vista)
        {
            _vista = vista;
        }

        public void Ejecutar()
        {
            bool seguirComprando = true;

            while (seguirComprando)
            {
                _vista.Mostrar();
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Salir");
                var opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        _vista.PreguntarProducto();
                        break;
                    case 2:
                        _vista.PreguntarEliminar();
                        break;
                    default:
                        seguirComprando = false;
                        break;
                }
            }
        }
    }
}
