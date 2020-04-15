using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDocentes
{
    class Docente
    {
        String Nombres { get; set; }
        String Apellidos { get; set; }
        List<Materia> materias;
        // una lista de materias

        // Un lista de alumnos por materia

        // pila de libros 
        Stack<Libro> pilalibros;
        // una cola de tareas
        Queue<Tarea> colatareas;
        // arbol de problemas
        ArbolProblema problemas;
        public void insertarMateria(Materia m)

        {
            materias.Add(m);
        }
        public void insertarLibro(Libro l)

        {
            pilalibros.Push(l);
        }

        public void insertarTarea(Tarea t)

        {
            colatareas.Enqueue(t);
        }
    }
}
