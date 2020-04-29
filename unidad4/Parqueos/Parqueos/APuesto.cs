using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueos
{
    abstract class APuesto
    {
        protected int numero;
        protected Auto auto;
        protected DateTime inicio;
        protected DateTime fin;
   
        public Auto getAuto()
        {
            return auto;
        }

        public abstract String ingresarAuto(Auto auto);
        public abstract double salirAuto();

        public Boolean estaOcupado()
        {
            return (this.auto != null);
        }
    }
}
