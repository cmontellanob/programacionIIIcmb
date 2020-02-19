using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motivacion
{
    class Program
    {
        public delegate int Delegado(int n);
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Delegado del = (int num) =>
              {
                  int fact = 1;
                  for (int i = 1; i <= num; i++)
                  {
                      fact = fact * i;
                  }
                  return fact;
              };

            
            Console.WriteLine("El factorial es {0}",del(n));
            Console.WriteLine("El factorial es {0}", del(n+2));
            Console.WriteLine("La Sumatoria es {0}",Operaciones.Sumatoria(n));
            Console.ReadKey();
        }
    }
}
