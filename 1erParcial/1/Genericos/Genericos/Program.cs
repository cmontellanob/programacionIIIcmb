using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,d;
            a = 2;
            b = 3;
            c = 4;
            d = Multiplicar(a, b, c);
            double aa, bb, cc, dd;
            aa = 3.1;
            bb = 4.6;
            cc = 2.3;
            dd = Multiplicar(aa, bb, cc);
            Console.WriteLine(dd);
            aa = -4;
            bb = -3.2;
            cc = -6;
            dd = Multiplicar(aa, bb, cc);
            Console.WriteLine(dd);

        }
        static T Multiplicar<T>(T a,T b, T c)
        {
            
            return a;
        }
    }
}
