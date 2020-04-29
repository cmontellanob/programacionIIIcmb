using System;

namespace Parqueos
{
    class Puesto:APuesto
    {
       
        public Puesto(int numero)
        {
            this.numero = numero;
        }

      

        public override string ingresarAuto(Auto auto)
        {
            this.auto = auto;
            inicio = DateTime.Now;
            return inicio.ToLongDateString();
        }

   

        public override double salirAuto()
        {
            this.auto = null;
            fin = DateTime.Now;
            TimeSpan total = fin - inicio;
            return total.TotalHours;
        }
    }
}