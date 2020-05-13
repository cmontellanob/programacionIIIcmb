using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObervadorPatron
{
    class Sujeto
    {
        private List<Observador> observadores = new List<Observador>();
        private int montocambio;

        public int getMontocambio()
        {
            return montocambio;
        }

        public void setMontocambio(int monto)
        {
            montocambio = monto;
            notificarTodosObservadores();  //dispador
        }

        public void agregar(Observador observador)
        {
            observadores.Add(observador);
        }

        public void notificarTodosObservadores()
        {
            observadores.ForEach(x=>x.actualizar());
        }


    }
}
