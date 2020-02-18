using System;

namespace Eventos1
{
    class Program
    {
        public static void NotificarCambioNombre(string msg)
        {
            //imprimos mensaje aviso.
            Console.WriteLine("¡El nombre del empleado ha cambiado!");
            Console.WriteLine(msg);
        }

        public static void Main(string[] args)
        {
            Empleado MiEmpleado = new Empleado("Ramiro");
            MiEmpleado.NombreCambiado +=NotificarCambioNombre; //suscribiendo
            Console.Write("Nombre empleado: ");
            MiEmpleado.setNombre(Console.ReadLine());

            Console.Write("Pulsa cualquier tecla para continuar . . . ");
            Console.ReadKey(true);
        }
    }
}
