using System;

namespace Delegados4
{
    delegate void Mdelegate(int x, int y);
    public class Oper
    {
        public static void Sumar(int x, int y)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        }
        public static void Restar(int x, int y)
        {
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        }
    }
    public class CSharpApp
    {
        static void Main()
        {
            Mdelegate del = new Mdelegate(Oper.Sumar);
            del += new Mdelegate(Oper.Restar);
            del(6, 4);
            Console.ReadKey();
        }
    }
}
