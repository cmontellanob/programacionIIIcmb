using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            String x = "";
            Lista l = new Lista();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");


                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca un elemento");
                        x = Console.ReadLine();
                        l.Insertar(x);
                        break;
                    case 2:
                        Console.WriteLine("que elemnto quiere eliminar");
                        x = Console.ReadLine();
                        l.Eliminar(x);
                        Console.ReadKey();
                        break;
                    case 3:
                        l.Mostrar();
                        Console.ReadKey();
                        break;

                }
            }
    }
}
