using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObervadorPatron
{
    abstract class Observador
    {
        protected Sujeto sujeto;
        public abstract void actualizar();
    }
}
