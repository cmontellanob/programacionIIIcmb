using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int x = 0;
            List<int> l = new List<int>();
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
                        x = int.Parse(Console.ReadLine());
                        l.Add(x);
                        break;
                    case 2:
                        Console.WriteLine("que elemnto quiere eliminar");
                        x = int.Parse(Console.ReadLine());
                        l.Remove(x);
                        Console.ReadKey();
                        break;
                    case 3:
                        foreach (int o in l)
                        {
                            Console.Write("{0}     ", o);
                        }

                        Console.ReadKey();
                        break;

                }
            }
        }
    }
}
