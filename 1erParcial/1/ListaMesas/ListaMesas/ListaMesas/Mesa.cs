using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaMesas
{
    class Mesa
    {
        public Mesa(int nroMesa, string eleccion, string ciudad, int mAS, int cC, int juntos, int crecer)
        {
            NroMesa = nroMesa;
            Eleccion = eleccion;
            Ciudad = ciudad;
            MAS = mAS;
            CC = cC;
            Juntos = juntos;
            Crecer = crecer;
        }

        public int NroMesa{set;get;}
        public String Eleccion { set; get; }
        public String Ciudad { set; get; }

        public int MAS { set; get; }
        public int CC { set; get; }
        public int Juntos { set; get; }

        public int Crecer { set; get; }





    }
}
