using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompararMetodosOrdenacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo;

            LlenarArreglo(arreglo, 16);

            TimeSpan Incio = new TimeSpan(DateTime.Now.Ticks);

            QuickSort();

            TimeSpan Final = new TimeSpan(DateTime.Now.Ticks);
            
            double DuracionQuiackSort =Final.Subtract(Incio).TotalMilliseconds;




        }

        private static void LlenarArreglo(int[] arreglo, int n)
        {
            // llenar el arreglo con numeros aleatorios
        }
    }
}
