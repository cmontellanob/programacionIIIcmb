using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[] { 54, 26, 93, 17, 77, 31, 44, 55, 20, 65 };
            Array.Sort(valores);
            //{17, 20, 26, 31, 44, 55, 65,77, 93}
            Console.WriteLine(BusquedaBinaria(valores,4124));
            Console.ReadKey();
        }
        static int BusquedaBinaria(int [] arreglo,int elemento)
        {
            int inicio = 0;
            int fin = arreglo.Length-1;
            int centro = (fin-inicio) / 2;
            while (fin > inicio)
            {
                if (elemento == arreglo[centro])
                    return centro;
                else
                {
                    if (elemento > arreglo[centro])
                        inicio = centro;
                    else
                        fin = centro;
                }
                centro = (fin - inicio) / 2;
            }
              return -1;
        }
        
    }
}
