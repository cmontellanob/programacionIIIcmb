using System;

namespace Delegados
{
    delegate void Mdelegado();
    delegate void Mdelegado2(String a);
    class Program
    {
        static void Main(string[] args)
        {
            Mdelegado del = new Mdelegado(Metodo2);
            del();
            del = Metodo1;
            del();
            Mdelegado2 del2 = new Mdelegado2(Metodo);
            del2("cadena");
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


