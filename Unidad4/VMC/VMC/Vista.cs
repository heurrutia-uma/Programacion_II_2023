using System;

namespace VMC
{
    public class VistaCarritoDeCompras
    {
        private CarritoDeCompras _carrito;

        public VistaCarritoDeCompras(CarritoDeCompras carrito)
        {
            _carrito = carrito;
        }

        public void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("Carrito de compras.");
            Console.WriteLine("-------------------");
            var productos = _carrito.ObtenerProductos();
            for (int i = 0; i < productos.Count; i++)
            {
                var linea = $"{i + 1}. {productos[i].Nombre} - " +
                    $"{productos[i].Cantidad} x " +
                    $"{productos[i].Precio:c}";
                Console.WriteLine(linea);
            }
            Console.WriteLine("-------------------");
        }

        public void PreguntarProducto()
        {
            Console.Write("Nombre del producto: ");
            var nombre = Console.ReadLine();
            Console.Write("Precio: ");
            var precio = decimal.Parse(Console.ReadLine());
            Console.Write("Cantidad: ");
            var cantidad = int.Parse(Console.ReadLine());

            var producto = new Producto()
            {
                Nombre = nombre,
                Precio = precio,
                Cantidad = cantidad
            };

            _carrito.AgregarProducto(producto);
        }

        public void PreguntarEliminar()
        {
            Console.Write("Indice del producto a eliminar: ");
            var indiceStr = Console.ReadLine();

            if (!int.TryParse(indiceStr, out int index))
            {
                Console.WriteLine("El indice ingresado no es un numero valido.");
                Console.ReadLine();
                return;
            }

            if (index <= 0 || index > _carrito.ObtenerProductos().Count)
            {
                Console.WriteLine("El indice ingresado esta fuera del rango de productos");
                Console.ReadLine();
                return;
            }

            _carrito.EliminarProducto(index - 1);
        }
    }
}
