using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // crear un arreglo de int, double y char
            int[] intArray = { 3, 6, 1, 4, 2, 5 };
            Console.WriteLine("Arreglo inicial:");
            Mostrar(intArray);
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'O', 'L', 'A' };
            Console.WriteLine("Arreglo ordenado:");
            Ordenar(intArray);
            Mostrar(intArray);
            //Console.WriteLine("doubleArray contiene:");
            //MuestraArreglo(doubleArray);
            //Console.WriteLine("charArray contiene:");
            //MuestraArreglo(charArray);
            Console.ReadKey();
        }
        private static void Mostrar(int[] arreglo)
        {
            foreach (int element in arreglo)
                Console.Write(element + " ");
            Console.WriteLine("\n");
        }
        private static void Ordenar(int[] a)
        {
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length-1-j; i++)
                {
                    if (a[i].CompareTo(a[i+1]) < 0)
                    {
                        int aux = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = aux;
                    }
                }
            }
        }
    }
}
