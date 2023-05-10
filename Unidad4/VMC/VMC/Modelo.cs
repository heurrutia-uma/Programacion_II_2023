using System.Collections.Generic;

namespace VMC
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
    }

    public class CarritoDeCompras
    {
        private List<Producto> _productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            _productos.Add(producto);
        }

        public void EliminarProducto(int index)
        {
            _productos.RemoveAt(index);
        }

        public List<Producto> ObtenerProductos()
        {
            return _productos;
        }
    }
}
