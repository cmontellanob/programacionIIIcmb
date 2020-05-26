using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static Examen e = new Examen(10);
        static ThreadStart hilo1 = new ThreadStart(iniciarexamen);
        static Thread t1 = new Thread(hilo1);
        static ThreadStart hilo2 = new ThreadStart(contarexamen);
        static Thread t2 = new Thread(hilo2);

        static void Main(string[] args)
        {
            
            e.insertarPregunta("3+4","7");
            e.insertarPregunta("1+1","2");
            e.insertarPregunta("4-4","0");
            e.insertarPregunta("5*1","5");

            //arrancar el primer hilo
            t1.Start();
            //arrencar el segundo hilo
            t2.Start();
            //t1.Abort();
            
        }
        static void iniciarexamen()
        {
            e.iniciarExamen();
            t2.Abort();
            Console.ReadKey();
        }
        static void contarexamen()
        {
            e.contar();
            t1.Abort();
            Console.ReadKey();
        }

        

    }
}
