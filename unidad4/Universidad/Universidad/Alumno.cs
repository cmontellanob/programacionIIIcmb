using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    class Alumno : Persona
    {
        public override String getDatos()
        {
            return "Alumno: " + nombres + " " + apellidos;
        }
    }
}
