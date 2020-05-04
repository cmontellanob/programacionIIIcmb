using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class ProductoCompuesto:AbstractProducto
    {
        private List<AbstractProducto> productos = new List<AbstractProducto>();

        public ProductoCompuesto(String nombre)
        {
            this.nombre = nombre;

        }


    
    public void setPrice(double price)
        {
            
        }

        public void insertarProducto(AbstractProducto product)
        {
            this.productos.Add(product);
        }

        public bool eliminarProductos(AbstractProducto producto)
        {
            return this.productos.Remove(producto);
        }

        public override double getPrecio()
        {
            double precio = 0;
            foreach (AbstractProducto producto in productos)
            {
                precio += producto.getPrecio();
            }
            return precio;

        }

    }
}
