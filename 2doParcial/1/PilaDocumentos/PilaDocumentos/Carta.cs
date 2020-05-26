using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaDocumentos
{
    class Carta : Documento
    {
        string fecha; 
        string origen;
        string asunto;

        public Carta(string fecha, string origen, string asunto)
        {
            this.fecha = fecha;
            this.origen = origen;
            this.asunto = asunto;
        }

        public string mostrar()
        {
            return "Carta- fecha:" + fecha + "origen:" + origen + "asunto:" + asunto;
        }

        public override string ToString()
        {
            return mostrar();
        }
    }
}
