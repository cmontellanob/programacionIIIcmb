using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            BancoCentral b = BancoCentral.getInstancia();

            while (opcion != 3)
            {
                Console.Clear();
                Console.WriteLine("1. Colocar Cotizacion Dolar");
                Console.WriteLine("2. Mostrar Cotizacion Dolar");
                Console.WriteLine("3. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Fecha ");
                        String fecha = Console.ReadLine();
                        Console.WriteLine("Monto");
                        Double monto = double.Parse(Console.ReadLine());
                        b.colocar(fecha, monto);
                        break;
                    case 2:
                        Console.WriteLine("Fecha ");
                        fecha = Console.ReadLine();
                        Console.WriteLine(b.mostrar(fecha));
                        Console.ReadKey();
                        break;
                }

            }
        }
    }
}
