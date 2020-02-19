using System;

namespace ExpresionesLambda
{
    class Program
    {
        delegate int Mdelegate(int a, int b);
        static void Main(string[] args)
        {
            Mdelegate del = (int a, int b)=>
            { return a + b; };

            Console.WriteLine(del(4, 5));
            Console.ReadKey();
        }
    }
}
