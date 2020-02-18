using System;

namespace Eventos3
{
    class Program
    {
        static void Main(string[] args)
        {

            rectangulo r = new rectangulo();
            r.Changed += r_Changed; //suscribirse al evento
            r.Longitud = 10;
            r.Longitud = 20;
            Console.ReadKey();
        }
        static void r_Changed (object sender,EventArgs e)
        {
            rectangulo r = (rectangulo)sender;
            Console.WriteLine("El valor cambio a {0}",r.Longitud);
        }
    }
}
