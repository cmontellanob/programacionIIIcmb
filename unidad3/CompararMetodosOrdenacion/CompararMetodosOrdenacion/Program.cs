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
            int[] arreglo=new int[16];

            LlenarArreglo(arreglo, 16);

            TimeSpan Incio = new TimeSpan(DateTime.Now.Ticks);

            //MEtodo de Ordenacion

            TimeSpan Final = new TimeSpan(DateTime.Now.Ticks);
            
            double DuracionQuiackSort =Final.Subtract(Incio).TotalMilliseconds;




        }

        private static void LlenarArreglo(int[] arreglo, int n)
        {
            // llenar el arreglo con numeros aleatorios
            Random numero = new Random();
            for (int i=0;i<n;i++)
            {
                arreglo[i] = numero.Next(0, n);
            }

        }
    }
}
