using System;

namespace Delegados2
{
    public delegate void NombreDelegado(string msg);

    public class Persona
    { 
        public string primerNombre;
        public string segundoNombre;

        public Persona(string primerNombre, string segundoNombre)
        {
            this.primerNombre= primerNombre;
            this.segundoNombre = segundoNombre;
        }

        public void MostrarPrimerNombre(string msg)
        {
            Console.WriteLine(msg + this.primerNombre);
        }

        public void MostrarSegundoNombre(string msg)
        {
            Console.WriteLine(msg + this.segundoNombre);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                Persona per = new Persona("Fabiana", "Ricarda");

                NombreDelegado nDelegate = new NombreDelegado(per.MostrarPrimerNombre);
                nDelegate("Llamada 1: ");

                nDelegate = new NombreDelegado(per.MostrarSegundoNombre);
                nDelegate("Llamada 2: ");
            Console.ReadKey();
            }
    }
}
