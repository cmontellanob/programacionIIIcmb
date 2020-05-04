using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductoSimple ram4gb = new ProductoSimple("Memoria RAM 4GB", 750, "KingStone");
            ProductoSimple ram8gb = new ProductoSimple("Memoria RAM 8GB", 1000, "KingStone");

            ProductoSimple disco500gb = new ProductoSimple("Disco Duro 500GB", 1500, "ACME");
            ProductoSimple disco1tb = new ProductoSimple("Disco Duro 1TB", 2000, "ACME");

            ProductoSimple cpuAMD = new ProductoSimple("AMD phenon", 4000, "AMD");
            ProductoSimple cpuIntel = new ProductoSimple("Intel i7", 4500, "Intel");

            ProductoSimple pequeCabinete = new ProductoSimple("Gabinete Pequeño", 2000, "ExCom");
            ProductoSimple granCabinete = new ProductoSimple("Gabinete Grande", 2200, "ExCom");

            ProductoSimple monitor20pulgadas = new ProductoSimple("Monitor 20'", 1500, "HP");
            ProductoSimple monitor30pulgadas = new ProductoSimple("Monitor 30'", 2000, "HP");

            ProductoSimple simpleMouse = new ProductoSimple("Raton Simple", 150, "Genius");
            ProductoSimple gammerMouse = new ProductoSimple("Raton Gammer", 750, "Alien");

            //Computadora para Gammer que incluye 8gb de ram,disco de 1tb, procesador Intel i7
            //gabinete grande,monitor de 30' y un mouse gammer.
            ProductoCompuesto gammerPC = new ProductoCompuesto("Gammer PC");
            gammerPC.insertarProducto(ram8gb);
            gammerPC.insertarProducto(disco1tb);
            gammerPC.insertarProducto(cpuIntel);
            gammerPC.insertarProducto(granCabinete);
            gammerPC.insertarProducto(monitor30pulgadas);
            gammerPC.insertarProducto(gammerMouse);

            //Computadora para Casa que incluye 4gb de ram,disco de 500gb, procesador AMD Phenon
            //gabinete chico,monitor de 20' y un mouse simple.
            ProductoCompuesto casaPC = new ProductoCompuesto("Casa PC");
            casaPC.insertarProducto(ram4gb);//
            casaPC.insertarProducto(disco500gb);
            casaPC.insertarProducto(cpuAMD);
            casaPC.insertarProducto(pequeCabinete);
            casaPC.insertarProducto(monitor20pulgadas);
            casaPC.insertarProducto(simpleMouse);

            //Paque compuesto de dos paquetes, El paquete Gammer PC y casa PC
            ProductoCompuesto pc2x1 = new ProductoCompuesto("Paquete PC Gammer + Casa");
            pc2x1.insertarProducto(gammerPC);
            pc2x1.insertarProducto(casaPC);

            OrdenCompra gammerOrden = new OrdenCompra(1, "Juan Perez");
            gammerOrden.insertarProducto(gammerPC);
            gammerOrden.imprimirOrden();

            OrdenCompra casaOrden = new OrdenCompra(2, "Marcos Guerra");
            casaOrden.insertarProducto(casaPC);
            casaOrden.imprimirOrden();

            OrdenCompra comboOrden = new OrdenCompra(3, "Paquete 2x1 en PC");
            comboOrden.insertarProducto(pc2x1);
            comboOrden.imprimirOrden();

            OrdenCompra personalizadoOrden = new OrdenCompra(4, "Oscar Blancarte");
            personalizadoOrden.insertarProducto(casaPC);
            personalizadoOrden.insertarProducto(ram8gb);
            personalizadoOrden.insertarProducto(ram4gb);
            personalizadoOrden.insertarProducto(monitor30pulgadas);
            personalizadoOrden.insertarProducto(gammerMouse);
            personalizadoOrden.imprimirOrden();

            Console.ReadKey();

        }
    }
}
