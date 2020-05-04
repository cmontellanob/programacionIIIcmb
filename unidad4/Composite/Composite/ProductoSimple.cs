using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class ProductoSimple:AbstractProducto
    {
        protected String marca;

        public ProductoSimple(string nombre, double precio,string marca)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
        }

        public String getMarca()
        {
            return marca;
        }

        public override double getPrecio()
        {
            return this.precio;
        }

        public void setMarca(String marca)
        {
            this.marca = marca;
        }
    }
}
