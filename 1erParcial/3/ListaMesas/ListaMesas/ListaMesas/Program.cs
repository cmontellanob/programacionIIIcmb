using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaMesas
{
    class Program
    {
        static void Main(string[] args)
        {
            Mesa[] listamesas = new Mesa[4];
            InsertarTodos(listamesas);
            ListaMesasEleccionCiudadMesa(listamesas);
            ListaMesasJuntos20(listamesas);
            CantidadVotosDiputadosCiudad(listamesas);
            CantidadVotosEleccion20(listamesas);
            ListaMesasCrecerGano(listamesas);

            Console.ReadKey();
        }
        static void InsertarTodos(Mesa[] listamesas)
        {
            listamesas[0] = new Mesa(41, "Presidente", "Sucre", 35, 46, 15, 5);
            listamesas[1] = new Mesa(24, "Diputado", "La Paz", 33, 11, 20, 6);
            listamesas[2] = new Mesa(13, "Diputado", "Sucre", 36, 60, 18, 78);
            listamesas[3] = new Mesa(14, "Presidente", "Sucre", 40, 20, 20, 8);

        }
        static void ListaMesasEleccionCiudadMesa(Mesa[] listamesas)
        {
            Console.WriteLine("a) Lista de mesas ordenadas por ciudad luego por mesa");
            var todos = from l in listamesas
                        orderby l.Ciudad,l.NroMesa
                        select l;

            foreach (Mesa a in todos)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", a.NroMesa, a.Eleccion, a.Ciudad, a.MAS, a.CC,a.Juntos,a.Crecer);
            }

        }
        static void ListaMesasJuntos20(Mesa[] listamesas)
        {
            Console.WriteLine("b) Lista de mesas donde la votacion de Juntos  es menor a 20 ordenados por su eleccion");
            var todos = from l in listamesas
                        where l.Juntos<20
                        orderby l.Eleccion
                        select l;

            foreach (Mesa a in todos)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", a.NroMesa, a.Eleccion, a.Ciudad, a.MAS, a.CC, a.Juntos, a.Crecer);
            }

        }
        static void CantidadVotosDiputadosCiudad(Mesa[] listamesas)
        {
            Console.WriteLine("c) Cantidad de Votos Diputados agrupados por Ciudad");
            var votos = from l in listamesas
                        where l.Eleccion=="Diputado"
                        group l by l.Ciudad into eleccion
                        select new
                        {
                            Eleccion = eleccion.Key,
                            CantidadMAS = eleccion.Sum(p => p.MAS),
                            CantidadCC = eleccion.Sum(p => p.CC),
                            CantidadJuntos = eleccion.Sum(p => p.Juntos),
                            CantidadCrecer = eleccion.Sum(p => p.Crecer)
                        };
            Console.WriteLine("Ciudad       MAS    CC     Juntos     Crecer");

            foreach (var grupoeleccion in votos)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} ", grupoeleccion.Eleccion, grupoeleccion.CantidadMAS,grupoeleccion.CantidadCC,grupoeleccion.CantidadJuntos,grupoeleccion.CantidadCrecer);

            }

        }
        static void CantidadVotosEleccion20(Mesa[] listamesas)
        {
            Console.WriteLine("d) Cantidad de Votos agrupados por eleccion para las mesas mayores a 20");
            var votos = from l in listamesas
                        where l.NroMesa>20
                        group l by l.Eleccion into eleccion
                        select new
                        {
                            Eleccion = eleccion.Key,
                            CantidadMAS = eleccion.Sum(p => p.MAS),
                            CantidadCC = eleccion.Sum(p => p.CC),
                            CantidadJuntos = eleccion.Sum(p => p.Juntos),
                            CantidadCrecer = eleccion.Sum(p => p.Crecer)
                        };
            Console.WriteLine("Eleccion    MAS    CC     Juntos     Crecer");

            foreach (var grupoeleccion in votos)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} ", grupoeleccion.Eleccion, grupoeleccion.CantidadMAS, grupoeleccion.CantidadCC, grupoeleccion.CantidadJuntos, grupoeleccion.CantidadCrecer);

            }

        }
        static void ListaMesasCrecerGano(Mesa[] listamesas)
        {
            Console.WriteLine("e) Lista de mesas donde Crecer Gano");
            var todos = from l in listamesas
                        where l.Crecer > l.MAS && l.Crecer > l.Juntos && l.Crecer > l.CC
                        select l;

            foreach (Mesa a in todos)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", a.NroMesa, a.Eleccion, a.Ciudad, a.MAS, a.CC, a.Juntos, a.Crecer);
            }

        }

    }
}
