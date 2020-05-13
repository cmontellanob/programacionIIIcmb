using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaforos
{
    class Rojo : Estado
    {
        public void mostrar()
        {
            Console.WriteLine("Esta en Rojo");
        }
    }
}
