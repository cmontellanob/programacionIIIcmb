using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaDocumentos
{
    class Memorandum : Documento
    {
        string fecha;
        string asunto;
        string para;

        public Memorandum(string fecha, string asunto, string para)
        {
            this.fecha = fecha;
            this.asunto = asunto;
            this.para = para;
        }

        public string mostrar()
        {
            return "Memorandum -fecha:" + fecha + "para:" + para + "asunto:" + asunto;

        }

        public override string ToString()
        {
            return mostrar();
        }
    }
}
