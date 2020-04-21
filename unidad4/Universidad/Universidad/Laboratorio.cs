using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    class Laboratorio : Aula
    {
        LinkedList<Computadora> listacomputadoras;

        public override string getDatos()
        {
            return "Laboratorio:" + codigo + "Ubicacion:" + ubicacion;

        }
    }
}
