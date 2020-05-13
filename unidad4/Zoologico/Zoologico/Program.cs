using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamifero f = new Mamifero();
            f.nombre = "carlos";
            Console.WriteLine(f.nombre);
            Console.ReadKey();
        }
    }
}
