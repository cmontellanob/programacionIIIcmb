using System;

namespace Parqueos
{
    class Puesto:IPuesto
    {
        protected int numero;
        protected Auto auto;
        protected DateTime inicio;
        protected DateTime fin;

        public Auto getAuto()
        {
            return auto;
        }
        public Puesto(int numero)
        {
            this.numero = numero;
        }

         public string ingresarAuto(Auto auto)
        {
            this.auto = auto;
            inicio = DateTime.Now;
            return inicio.ToLongDateString();
        }

        public double salirAuto()
        {
            this.auto = null;
            fin = DateTime.Now;
            TimeSpan total = fin - inicio;
            return total.TotalHours;
        }
        public Boolean estaOcupado()
        {
            return (this.auto != null);
        }
    }
}