using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObervadorPatron
{
    class Program
    {
        static void Main(string[] args)
        {
            Sujeto subject = new Sujeto();
            new SolObservador(subject);
            new PesoARGObservador(subject);
            new PesoMXObservador(subject);
            new MonedaBoliviana(subject);

            Console.WriteLine("Si desea cambiar 10 dólares obtendrá : ");
            subject.setMontocambio(10);
            Console.WriteLine("-----------------");
            Console.WriteLine("Si desea cambiar 100 dólares obtendrá : ");
            subject.setMontocambio(100);
            Console.ReadLine();
        }
    }
}
