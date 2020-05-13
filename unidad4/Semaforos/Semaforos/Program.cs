using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaforos
{
    class Program
    {
        static void Main(string[] args)
        {
            Semaforo s = new Semaforo(new Verde());
            s.imprimirestado();
            s.estadoactual = new Rojo();
            s.imprimirestado();
            Console.ReadKey();
        }
    }
}
