using System;

namespace Ennumerados1
{
    class Program
    {
        enum Modalidad
        {
            Treboles = 1, Rombos, Corazones, Picas
        }

        static void Main(string[] args)
        {
                Modalidad m = Modalidad.Treboles;
                System.Console.WriteLine((int)m); // Visualiza Treboles
            Console.ReadKey();

        }

    }
}

