using System;

namespace Delegados
{
    delegate void Mdelegado();
    class Program
    {
        static void Main(string[] args)
        {
            Mdelegado del = new Mdelegado(Metodo2);
            del();
            Console.ReadKey();
        }
        static void Metodo(string p)
        {
            Console.WriteLine("Ejecutando Metodo");

        }
        static void Metodo1()
        {
            Console.WriteLine("Ejecutando Metodo 1");

        }
        static void Metodo2()
        {
            Console.WriteLine("Ejecutando Metodo 2");

        }

    }
}


