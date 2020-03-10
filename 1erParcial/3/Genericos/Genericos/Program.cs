using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] enteros = Menor12(3, 4, 5);
            Console.WriteLine("Menor de {0}, {1} y {2} es {3} y {4}\n",
                   3, 4, 5, enteros[0], enteros[1]);
            double[] decimales = Menor12(6.6, 8.8, 7.7);
            Console.WriteLine("Menor de {0}, {1} y {2} es {3} y {4}\n",
               6.6, 8.8, 7.7, decimales[0], decimales[1]);
            String[] cadenas = Menor12("pera", "manzana", "naranja");
            Console.WriteLine("Menor de {0}, {1} y {2} es {3} y {4}\n",
               "pera", "manzana", "naranja", cadenas[0], cadenas[1]);
            Console.ReadKey();
        }
        private static T[] Menor12<T>(T a, T b, T c)
            where T : IComparable<T>
        {
            T[] aux = new T[2];
            if (a.CompareTo(b) < 0)
                if (b.CompareTo(c) < 0)
                { // sabemos que a es el mayor
                    // b es el segundo mayor
                    aux[0] = a;
                    aux[1] = b;
                }
                else
                {
                    if (a.CompareTo(c) < 0)
                    {
                        aux[0] = a;
                        aux[1] = c;
                    }
                    else
                    {
                        aux[0] = c;
                        aux[1] = a;
                    }
                }
            else
                if (b.CompareTo(c) < 0)
                if (a.CompareTo(c) < 0)
                {
                    aux[0] = b;
                    aux[1] = a;
                }
                else
                {
                    aux[0] = b;
                    aux[1] = c;
                }
            else
            {
                aux[0] = c;
                aux[1] = b;
            }
            return aux; // regresa el objeto mayor
        }
    }
   
}
