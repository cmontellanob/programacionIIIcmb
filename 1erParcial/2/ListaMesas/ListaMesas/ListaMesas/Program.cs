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
            ListaMesasCiudadEleccion(listamesas);
            ListaMesasCC20(listamesas);
            CantidadVotosEleccion(listamesas);
            CantidadVotosPresidenteCiudad(listamesas);
            ListaMesasCCGano(listamesas);

            Console.ReadKey();
        }
        static void InsertarTodos(Mesa[] listamesas)
        {
            listamesas[0] = new Mesa(1, "Presidente", "Sucre", 35, 46, 15, 5);
            listamesas[1] = new Mesa(21, "Diputado", "La Paz", 33, 11, 20, 6);
            listamesas[2] = new Mesa(323, "Diputado", "Sucre", 36, 60, 18, 7);
            listamesas[3] = new Mesa(44, "Presidente", "Sucre", 40, 20, 20, 8);

        }
        static void ListaMesasCiudadEleccion(Mesa[] listamesas)
        {
            Console.WriteLine("a) Lista de mesas ordenadas por ciuidad luego por eleccion");
            var todos = from l in listamesas
                        orderby l.Ciudad, l.Eleccion
                        select l;

            foreach (Mesa a in todos)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", a.NroMesa, a.Eleccion, a.Ciudad, a.MAS, a.CC,a.Juntos,a.Crecer);
            }

        }
        static void ListaMesasCC20(Mesa[] listamesas)
        {
            Console.WriteLine("b) Lista de mesas donde la votacion del CC es mayor a 20 ordenados por su ciudad");
            var todos = from l in listamesas
                        where l.MAS>35
                        orderby l.MAS
                        select l;

            foreach (Mesa a in todos)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", a.NroMesa, a.Eleccion, a.Ciudad, a.MAS, a.CC, a.Juntos, a.Crecer);
            }

        }
        static void CantidadVotosEleccion(Mesa[] listamesas)
        {
            Console.WriteLine("c) Cantidad de Votos agrupados por Eleccion");
            var votos = from l in listamesas
                        group l by l.Eleccion into eleccion
                        select new
                        {
                            Eleccion = eleccion.Key,
                            CantidadMAS = eleccion.Sum(p => p.MAS),
                            CantidadCC = eleccion.Sum(p => p.CC),
                            CantidadJuntos = eleccion.Sum(p => p.Juntos),
                            CantidadCrecer = eleccion.Sum(p => p.Crecer)
                        };
            Console.WriteLine("Eleccion       MAS    CC     Juntos     Crecer");

            foreach (var grupoeleccion in votos)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} ", grupoeleccion.Eleccion, grupoeleccion.CantidadMAS,grupoeleccion.CantidadCC,grupoeleccion.CantidadJuntos,grupoeleccion.CantidadCrecer);

            }

        }
        static void CantidadVotosPresidenteCiudad(Mesa[] listamesas)
        {
            Console.WriteLine("d) Cantidad de Votos para Presidente agrupados por Ciudad");
            var votos = from l in listamesas
                        where l.Eleccion=="Presidente"
                        group l by l.Ciudad into ciudad
                        select new
                        {
                            Eleccion = ciudad.Key,
                            CantidadMAS = ciudad.Sum(p => p.MAS),
                            CantidadCC = ciudad.Sum(p => p.CC),
                            CantidadJuntos = ciudad.Sum(p => p.Juntos),
                            CantidadCrecer = ciudad.Sum(p => p.Crecer)
                        };
            Console.WriteLine("Ciudad    MAS    CC     Juntos     Crecer");

            foreach (var grupoeleccion in votos)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} ", grupoeleccion.Eleccion, grupoeleccion.CantidadMAS, grupoeleccion.CantidadCC, grupoeleccion.CantidadJuntos, grupoeleccion.CantidadCrecer);

            }

        }
        static void ListaMesasCCGano(Mesa[] listamesas)
        {
            Console.WriteLine("e) Lista de mesas donde el CC Gano");
            var todos = from l in listamesas
                        where l.CC  > l.MAS && l.CC>l.Juntos && l.CC>l.Crecer
                        orderby l.MAS
                        select l;

            foreach (Mesa a in todos)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", a.NroMesa, a.Eleccion, a.Ciudad, a.MAS, a.CC, a.Juntos, a.Crecer);
            }

        }

    }
}
