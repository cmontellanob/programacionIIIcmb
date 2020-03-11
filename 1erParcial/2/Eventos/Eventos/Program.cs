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
            o.CuandoRecibaMultiplosTres += RecibeMultiploTres;// nos estamos suscribiendo a eventoy mandandoalmanejador de eventos
            
            int a, b,c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int res = o.Multiplicar(a, b,c);
            Console.WriteLine("El Producto es = {0}", res);
            Console.ReadKey();
        }

        private static void RecibeMultiploTres()
        {
            Console.WriteLine(" multiplo de 3 ");

        }
    }
}
