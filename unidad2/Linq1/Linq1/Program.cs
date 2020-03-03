using System;
using System.Linq;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 4, 2, 6, 3, 8, 3, 1 }; //3.84
            double promedio = nums.Take(6).Average();
            var encima = from n in nums        //consulta todos aquellos numeros queseanmayores a 3.84
                        where n > promedio
                        select n;
            foreach (int elemento in encima)
            {
                Console.WriteLine(elemento);
            }
            Console.ReadKey();
        }
    }
}
