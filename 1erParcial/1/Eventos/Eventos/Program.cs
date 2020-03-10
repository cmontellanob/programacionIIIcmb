using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones o = new Operaciones();
            o.CuandoRecibaMultiplosCuatro += RecibeMultiploCuatro;// nos estamos suscribiendo a eventoy mandandoalmanejador de eventos
            
            int a, b,c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int res = o.Promedio(a, b,c);
            Console.WriteLine("El Promedio es = {0}", res);
            Console.ReadKey();
        }

        private static void RecibeMultiploCuatro()
        {
            Console.WriteLine("suma multiplo de 4 ");

        }
    }
}
