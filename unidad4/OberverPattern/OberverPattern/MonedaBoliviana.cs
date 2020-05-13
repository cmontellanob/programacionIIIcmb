using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObervadorPatron
{
    class MonedaBoliviana : Observador

    {
        private double valorCambio = 6.98;
        public MonedaBoliviana(Sujeto sujeto)
        {
            this.sujeto = sujeto;
            this.sujeto.agregar(this);
        }

        public override void actualizar()
        {
            Console.WriteLine("BS: " + (sujeto.getMontocambio() * valorCambio));
        }
    }
}
