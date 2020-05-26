using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaDocumentos
{
    class FabricaDocumento
    {
        public Documento crarDocumento(string tipo, string de, string fecha, string para, string asunto)
        {
            switch (tipo)
                {
                case "Carta":
                    return new Carta(fecha, de, asunto);
                    break;
                case "Circular":
                    return new Circular(de,fecha, para, asunto);
                    break;
                case "Memorandum":
                    return new Memorandum(fecha,  asunto,para);
                    break;
                default:
                    return null;

            }
          
        }
    }
}
