using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Meteorologo b = Meteorologo.getInstancia();

            while (opcion != 3)
            {
                Console.Clear();
                Console.WriteLine("1. Colocar Temperatura");
                Console.WriteLine("2. Mostrar Temperatura");
                Console.WriteLine("3. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ciudad ");
                        String ciudad = Console.ReadLine();
                        Console.WriteLine("temperatura");
                        int temperatura = int.Parse(Console.ReadLine());
                        b.colocar(ciudad,temperatura);
                        break;
                    case 2:
                        Console.WriteLine("ciudad ");
                        ciudad = Console.ReadLine();
                        Console.WriteLine(b.mostrar(ciudad));
                        Console.ReadKey();
                        break;
                }

            }
        }
    }
}
