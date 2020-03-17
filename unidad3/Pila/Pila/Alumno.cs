using System;
using System.Collections.Generic;
using System.Text;

namespace Pila
{
    class Alumno
    {
        public Alumno(string nombre, string apellidos)
        {
            Nombre = nombre;
            Apellidos = apellidos;
        }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string ToString()
        {
            return Nombre+""+Apellidos;
        }

    }
}
