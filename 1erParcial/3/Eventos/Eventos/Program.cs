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
            Console.WriteLine("Introduzca a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca c");
            int c = int.Parse(Console.ReadLine());

            Operaciones o = new Operaciones();
            o.CuandoDiscirminanteMenor0 += RecibeImaginario;// nos estamos suscribiendo a eventoy mandandoalmanejador de eventos
            o.Raices(a, b, c);
            Console.ReadKey();
        }
        static void RecibeImaginario() // Manejador de Evento
        {
            Console.WriteLine("raiz imaginaria");
        }
    }
}
