using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El factorial de 3  es {0}",Factorial(3));
            Console.WriteLine("El factorial recursivo de 3  es {0}", FactorialRecursivo(3));

            Console.ReadKey();
        }
        static int  Factorial(int n)
        {
            int aux = 1;
            for (int  i=1;i<=n;i++)
            {
                aux = aux * i;
            }
            return aux;
        }
        static int FactorialRecursivo(int n)
        {
            if (n == 0)
                return 1;
            else
                return n*FactorialRecursivo(n-1);
        }

    }
}
