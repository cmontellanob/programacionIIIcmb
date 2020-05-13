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

        static void Main(string[] args)
        {
            Examen e = new Examen(10);
            e.insertarPregunta("3+4","7");
            e.insertarPregunta("1+1","2");
            e.insertarPregunta("4-4","0");
            e.insertarPregunta("5*1","5");

            ThreadStart hilo1 = new ThreadStart(e.iniciarExamen);
            Thread t1 = new Thread(hilo1);
            ThreadStart hilo2 = new ThreadStart(e.contar);
            Thread t2 = new Thread(hilo2);
            //arrancar el primer hilo
            t1.Start();
            //arrencar el segundo hilo
            t2.Start();
            
        }

        

    }
}
