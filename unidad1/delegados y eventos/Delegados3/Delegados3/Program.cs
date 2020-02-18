using System;

namespace Delegados3
{
    class Program
    {
        delegate int Aritmetica(int x, int y);

        public class CSharpApp
        {
            static void Main(string[] args)
            {
                Aritmetica DoOperacion = new Aritmetica(Multiplicacion);
                Console.WriteLine(DoOperacion(10, 2));
                DoOperacion = Division;
                Console.WriteLine(DoOperacion(10, 2));
                DoOperacion = Suma;
                Console.WriteLine(DoOperacion(10, 2));
                DoOperacion = Resta;
                Console.WriteLine(DoOperacion(10, 2));
                Console.ReadKey();
            }


            static int Suma(int x, int y)
            {
                return x + y;
            }

            static int Resta(int x, int y)
            {
                return x - y;
            }

            static int Multiplicacion(int x, int y)
            {
                return x * y;
            }

            static int Division(int x, int y)
            {
                return x / y;
            }
        }

    }
}
