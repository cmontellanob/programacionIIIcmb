using System;

namespace Eventos2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[5]; 
            Console.WriteLine("Introduzca valores");
            for (int i=0; i<5;i++)
            {
                arreglo[i] = int.Parse(Console.ReadLine());
            }
        }
        static void MostrarVector(int[] arreglo)
        {
            foreach (int elemento in arreglo)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
