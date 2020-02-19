using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motivacion
{
    class Operaciones
    {
        public static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public static int Sumatoria(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum+= i;
            }
            return sum;
        }


    }
}
