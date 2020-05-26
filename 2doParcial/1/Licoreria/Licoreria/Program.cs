using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licoreria
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida cerveza = new Bebida("cerveza", 10);
            Bebida ron = new Bebida("ron", 70);
            Bebida wisky = new Bebida("wisky", 100);
            Bebida cocacola = new Bebida("Coca cola", 13);
            Combo cajacerveza = new Combo("Caja Cerveza");
            cajacerveza.insertarProducto(cerveza);
            cajacerveza.insertarProducto(cerveza);
            cajacerveza.insertarProducto(cerveza);
            cajacerveza.insertarProducto(cerveza);
            cajacerveza.insertarProducto(cerveza);
            cajacerveza.insertarProducto(cerveza);
            cajacerveza.insertarProducto(cerveza);
            cajacerveza.insertarProducto(cerveza);
            cajacerveza.insertarProducto(cerveza);
            cajacerveza.insertarProducto(cerveza);
            cajacerveza.insertarProducto(cerveza);
            cajacerveza.insertarProducto(cerveza);
            Console.WriteLine(cajacerveza.getPrecio().ToString());
            Combo combocarnavalero = new Combo("Combo Carnavalero");
            combocarnavalero.insertarProducto(ron);
            combocarnavalero.insertarProducto(cocacola);
            Console.WriteLine(combocarnavalero.getPrecio().ToString());

            Console.ReadKey();

        }
    }
}
