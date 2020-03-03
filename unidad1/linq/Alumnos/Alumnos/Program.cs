using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] listaalumnos = new Alumno[8];
            InsertarTodos(listaalumnos);
            int opcion = 0;
            while (opcion!=5)
            {
                Console.Clear();
                Console.WriteLine("1.- Insertar Alumno");
                Console.WriteLine("2.- Mostrar Alumnos");
                Console.WriteLine("3.- Mostrar Alumnas");
                Console.WriteLine("4.- Mostrar Alumnos ordenados alfabeticamente por nombre");

                Console.WriteLine("5.- Salir");
                Console.Write("Introduzca opcion ");
                opcion= int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Insertar(listaalumnos);
                        break;
                    case 2:
                        Mostrar(listaalumnos);
                        break;
                    case 3:
                        MostrarAlumnas(listaalumnos);
                        break;
                    case 4:
                        Ordenar(listaalumnos);
                        break;


                    default:
                        break;
                }
            }
        }
        static void Insertar(Alumno[] listaalumnos)
        {
            
            Console.Write("Introduzca el nro de alumno: ");
            int nroalumno = int.Parse(Console.ReadLine())-1;
            Console.Write("Introduzca el Nombre: ");
            String Nombre = Console.ReadLine();
            Console.Write("Introduzca el Primer Apellido: ");
            String PrimerApellido = Console.ReadLine();
            Console.Write("Introduzca el Segundo Apellido: ");
            String SegundoApellido = Console.ReadLine();
            Console.Write("Introduzca el Carnet de Identidad: ");
            String CI = Console.ReadLine();
            Console.Write("Introduzca el Sexo: (M/F) ");
            String Sexo = Console.ReadLine();

            Console.Write("Introduzca la Edad: ");
            int Edad=int.Parse(Console.ReadLine());
            

            Alumno a = new Alumno(Nombre, PrimerApellido, SegundoApellido, CI, Sexo,Edad);
            listaalumnos[nroalumno] = a;
            
        }
        static void InsertarTodos(Alumno[] listaalumnos)
        {
            listaalumnos[0] = new Alumno("Antonio","Arce","Pacheco","10390566","M",21);
            listaalumnos[1] = new Alumno("Maycol", "Mancilla", "Lora", "10566366", "M", 22);
            listaalumnos[2] = new Alumno("Camila", "Canaviri", "Mamani", "12398414", "F", 19);
            listaalumnos[3] = new Alumno("Kassandra", "Cuellar", "Almendras", "7512719", "F", 21);
            listaalumnos[4] = new Alumno("Danna", "Colque", "Soliz", "65498512", "F", 18);
            listaalumnos[5] = new Alumno("Jhoselin", "Choque", "Ajalla", "12931915", "F", 19);
            listaalumnos[6] = new Alumno("Yerson", "Mallcu", "Lisarazu", "123456789", "M", 26);
            listaalumnos[7] = new Alumno("Manuel", "Quispe", "Calcina", "8565058", "M", 20);
        }

        static void Mostrar(Alumno[] listaalumnos)
        {
            foreach(Alumno a in listaalumnos)
            {
                if (a!=null)
                Console.WriteLine("{0} {1} {2} {3} {4}",a.nombre,a.primerapellido,a.segundoapellido,a.ci,a.edad);
            }
            Console.ReadKey();

        }
        static void MostrarAlumnas(Alumno[] listaalumnos)
        {
            foreach (Alumno a in listaalumnos)
            {
                if (a != null)
                    if (a.sexo=="F")
                    Console.WriteLine("{0} {1} {2} {3} {4}", a.nombre, a.primerapellido, a.segundoapellido, a.ci, a.edad);
            }
            Console.ReadKey();

        }
        public static void Ordenar(Alumno[] listaalumnos)
            
        {
            for (int j = 0; j < listaalumnos.Length; j++)
            {
                for (int i = 0; i < listaalumnos.Length - 1 - j; i++)
                {
                    if (listaalumnos[i].nombre.CompareTo(listaalumnos[i + 1].nombre) > 0)
                    {
                        Alumno  aux = listaalumnos[i];
                        listaalumnos[i] = listaalumnos[i + 1];
                        listaalumnos[i + 1] = aux;
                    }
                }
            }
            Mostrar(listaalumnos);
        }
    }
}
