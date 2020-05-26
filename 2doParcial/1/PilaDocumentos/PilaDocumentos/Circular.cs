using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaDocumentos
{
    class Circular : Documento
    {
        string de;
        string fecha;
        string para;
        string asunto;

        public Circular(string de, string fecha, string para, string asunto)
        {
            this.de = de;
            this.fecha = fecha;
            this.para = para;
            this.asunto = asunto;
        }

        public string mostrar()
        {
            return "Circular -"+de+"fecha:" + fecha + "para:" + para+ "asunto:" + asunto;

        }

        public override string ToString()
        {
            return mostrar();
        }
    }
}
