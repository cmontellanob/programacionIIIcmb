using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class AbstractProducto
    {
        protected String nombre;
        protected double precio;

    
        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public abstract double getPrecio();
       

        public void setPrice(double precio)
        {
            this.precio = precio;
        }
    }
}
