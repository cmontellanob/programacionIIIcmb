using System;

namespace ExpresionesLambda1
{
    class Program
    {
        delegate int Aritmetica(int a, int b);
        static void Main(string[] args)
        {
            Aritmetica del = (int a, int b) =>
            { return a + b; };

            Console.WriteLine(del(4, 5));

            del = (int a, int b) =>
            { return a - b; };

            Console.WriteLine(del(4, 5));


            Console.ReadKey();
        }
    }
}
