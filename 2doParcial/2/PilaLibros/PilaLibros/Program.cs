using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaLibros
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            pila<Libro> p = new pila<Libro>();
            FabricaLibro f = new FabricaLibro();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                Libro x;
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Que tipo de libro quiere insertar (Enciclopedia,Revista,Novela)");
                        String tipolibro = Console.ReadLine();
                        switch (tipolibro)
                        {
                            case "Enciclopedia":
                                Console.WriteLine("Introduzca Nombre");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Editorial");
                                string editorial = Console.ReadLine();
                                Console.WriteLine("Tema");
                                string tema = Console.ReadLine();
                                x=f.crearLibro("Enciclopedia", nombre, editorial, tema, "", "", Genero.romance,0);
                                break;
                            case "Novela":
                                Console.WriteLine("Introduzca Titulo");
                                string titulo = Console.ReadLine();
                                Console.WriteLine("Autor");
                                string autor = Console.ReadLine();
                                Console.WriteLine("Genero");
                                string generocadena = Console.ReadLine();
                                Enum.TryParse(generocadena, out Genero genero);
                                x = f.crearLibro("Novela", "", "", "", titulo, autor, genero,0);
                                break;
                            case "Revista":
                                Console.WriteLine("Introduzca Titulo");
                                titulo = Console.ReadLine();
                                Console.WriteLine("Nro paginas");
                                int nropaginas= int.Parse(Console.ReadLine());
                                x = f.crearLibro("Revista", "", "", "", titulo, "", Genero.romance, nropaginas);
                                break;

                        }
                        p.insertar(x);
                        break;
                    case 2:
                        Libro y = p.eliminar();
                        Console.WriteLine("El elemento eliminado es {0}", y.mostrar());
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
