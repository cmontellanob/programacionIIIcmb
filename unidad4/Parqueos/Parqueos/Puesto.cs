using System;

namespace Parqueos
{
    class Puesto
    {
        int numero;
        Auto auto;
        DateTime inicio;
        DateTime fin;
        public Auto getAuto()
        {
            return auto;
        }

        public Puesto(int numero)
        {
            this.numero = numero;
        }

        public String ingresarAuto(Auto auto)
        {
            this.auto = auto;
            inicio =DateTime.Now;
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