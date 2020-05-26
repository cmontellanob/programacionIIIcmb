using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licoreria
{
    class Bebida : Producto
    {
        public Bebida(string nombre, double precio) 
        {
            this.nombre = nombre;
            this.precio = precio;
        }


        public override double getPrecio()
        {
            return precio;
        }
    }
}
