using System;

namespace Ennumerados
{
    class Program
    {
        enum DiasSemana
        {
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado,
            Domingo
        }

        static void Main(string[] args)
        {
        Console.WriteLine( DiasSemana.Lunes);
        Console.WriteLine((int) DiasSemana.Viernes);
        }
    }
}
