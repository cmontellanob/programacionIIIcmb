using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Parqueo solar = new Parqueo("El Solar", new Ubicacion("Camargo ", 71), 3, 10);
            // DAtos inciales
            solar.ingresarAuto(Color.rojo, Marca.Fiat, Tipo.camioneta, "2355-TUP");
            solar.ingresarAuto(Color.negro, Marca.Toyota, Tipo.auto, "2178-UPX");
            solar.ingresarAuto(Color.azul, Marca.Nissan, Tipo.vagonenta, "1138-TAI");

            while (opcion != 5)
            {
                Console.Clear();
                Console.WriteLine("************************************************");
                Console.WriteLine(solar);
                Console.WriteLine("************************************************");

                Console.WriteLine("1. Ingresar al Parqueo");
                Console.WriteLine("2. Salir del Parqueo");
                Console.WriteLine("3. Mostrar Parqueo");
                Console.WriteLine("4. Historial de Funcionamiento");

                Console.WriteLine("5. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca Color[rojo,azul,negro,blanco]");
                        String srtColor = Console.ReadLine();
                        Color color;
                        Enum.TryParse(srtColor, out color);

                        Console.WriteLine("Introduzca Marca[ Toyota, Nissan, Susuki,Ford, Fiat]");
                        String srtMarca = Console.ReadLine();
                        Marca marca;
                        Enum.TryParse(srtMarca, out marca);

                        Console.WriteLine("introduzca Tipo[vagonenta, camioneta,auto,camion,motocicleta]");
                        String strTipo = Console.ReadLine();
                        Tipo tipo;
                        Enum.TryParse(strTipo, out tipo);

                        Console.WriteLine("introduzca Placa");
                        String placa = Console.ReadLine();

                        Console.WriteLine(solar.ingresarAuto(color, marca, tipo, placa));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("introduzca Placa");
                        String p = Console.ReadLine();
                        Console.WriteLine(solar.SalirAuto(p));
                        Console.ReadKey();
                        break;
                    case 3:
                        solar.getDatos();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("introduzca el nrode puesto del cual obtener el historial");
                        int indice = int.Parse(Console.ReadLine());
                        solar.getHistorial(indice);
                        Console.ReadKey();
                        break;

                }

            }
        }
    }
}
