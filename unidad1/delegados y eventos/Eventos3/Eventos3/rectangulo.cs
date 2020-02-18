using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos3
{
    class rectangulo
    {
        public event EventHandler Changed;
        private double longitud;
        public double Longitud
        {
            get{
             return longitud;
                }
            set
            {
                longitud = value;
                if (Changed!=null)
                Changed(this, EventArgs.Empty); // llamada almanejador de eventos
            }

        }
    }
}
