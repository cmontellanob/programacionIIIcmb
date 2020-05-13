using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votacion
{
    abstract class Observador
    {
        Sujeto sujeto; 
        public abstract void Actualizar();
    }
}
