using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;
            String x = "";
            Arbol a = new Arbol ();
            a.insertar("F");
            a.insertar("B");
            a.insertar("A");
            a.insertar("D");
            a.insertar("C");
            a.insertar("E");
            a.insertar("H");
            a.insertar("G");
            a.insertar("I");


            while (opcion != 6)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar preoden");
                Console.WriteLine("4. Mostrar inoden");
                Console.WriteLine("5. Mostrar posorden");
                Console.WriteLine("6. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca un elemento");
                        x = Console.ReadLine();
                        a.insertar(x);
                        break;
                    case 2:
                        Console.WriteLine("que elemnto quiere eliminar");
                        x = Console.ReadLine();
                        a.eliminar(x);
                        Console.ReadKey();
                        break;
                    case 3:
                        a.mostrarPreOrden();
                        Console.ReadKey();
                        break;

                    case 4:
                        a.mostrarInOrden();
                        Console.ReadKey();
                        break;
                    case 5:
                        a.mostrarPosOrden();
                        Console.ReadKey();
                        break;

                }
            }
        }
    }
}
