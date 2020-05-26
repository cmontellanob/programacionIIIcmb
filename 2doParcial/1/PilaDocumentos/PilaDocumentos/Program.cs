using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaDocumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            pila<Documento> p = new pila<Documento>();
            FabricaDocumento f = new FabricaDocumento();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Que tipo de documento quiere insertar (Carta,Circular,Memorandum)");
                        String tipodocumento = Console.ReadLine();
                        Console.WriteLine("Introduzca fecha");
                        String fecha = Console.ReadLine();
                        Console.WriteLine("Introduzca asunto ");
                        String asunto = Console.ReadLine();
                        String de="";
                        String para="";
                        switch (tipodocumento)
                        {
                            case "Carta":
                                Console.WriteLine("Introduzca origen ");
                                de = Console.ReadLine();
                                break;
                            case "Circular":
                                Console.WriteLine("Introduzca De  ");
                                de = Console.ReadLine();
                                Console.WriteLine("Introduzca Para  ");
                                para = Console.ReadLine();
                                break;
                            case "Memorandum":
                                Console.WriteLine("Introduzca Para  ");
                                para = Console.ReadLine();
                                break;

                        }
                        Documento x = f.crarDocumento(tipodocumento, de, fecha, para, asunto);
                        p.insertar(x);
                        break;
                    case 2:
                        Documento y = p.eliminar();
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
