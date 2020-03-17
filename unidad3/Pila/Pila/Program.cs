using System;

namespace Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            
            pila<Alumno> p = new pila<Alumno>();
            while (opcion !=4)
            {
                Console.Clear();
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca NOmbre");
                        String nombre = Console.ReadLine();
                        Console.WriteLine("introduzca Apellido");
                        String apellido = Console.ReadLine();
                        Alumno x = new Alumno(nombre, apellido);
                        p.push(x);
                        break;
                    case 2:
                        Alumno y = p.pop();
                        Console.WriteLine("El elemento eliminado es {0}", y.ToString());
                        Console.ReadKey();
                        break;
                    case 3:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }

            }

        }
    }
}
