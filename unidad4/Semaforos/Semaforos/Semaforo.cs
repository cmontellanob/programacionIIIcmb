using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaforos
{
    class Semaforo
    {
        private Estado estadoactual;
        public Semaforo(Estado estadoactual)
        {
            this.estadoactual = estadoactual;
        }


        public void imprimirestado()
        {
            estadoactual.mostrar();
        }
    }
}
