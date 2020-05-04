using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueos
{
    interface IPuesto
    {
        String ingresarAuto(Auto auto);
        double salirAuto();
        Boolean estaOcupado();
        Auto getAuto();




    }
}
