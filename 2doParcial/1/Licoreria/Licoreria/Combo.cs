using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licoreria
{
    class Combo : Producto
    {
        List<Producto> listaproductos;

        public Combo(string nombre)
        {
            this.nombre = nombre;
            listaproductos = new List<Producto>();

        }

        public override double getPrecio()
        {
            Double aux = 0;
            foreach (Producto producto in listaproductos)
            {
                aux+=producto.getPrecio();
            }
            return aux;
        }
        public void insertarProducto(Producto producto)
        {
            this.listaproductos.Add(producto);
        }
    }
}
