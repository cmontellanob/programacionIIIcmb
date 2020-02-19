using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motivacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("El factorial es {0}",Operaciones.Factorial(n));
            Console.WriteLine("La Sumatoria es {0}",Operaciones.Sumatoria(n));
            Console.ReadKey();
        }
    }
}
