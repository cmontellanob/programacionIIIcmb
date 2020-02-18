using System;

namespace Delegados
{
    delegate int Aritmetica(int x, int y);
    public class CSharpApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoOperacion(Multiplicacion, 10, 2));
            Console.WriteLine(DoOperacion(Division, 10, 2));
            Console.ReadKey();
        }
        static int DoOperacion(Aritmetica op, int x, int y)
        {
            return (op(x, y));
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


