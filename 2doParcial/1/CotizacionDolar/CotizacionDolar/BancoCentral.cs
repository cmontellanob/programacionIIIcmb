using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionDolar
{
    class BancoCentral
    {
        static BancoCentral instancia;
        List<Cotizacion> listacotizaciones;

        private BancoCentral()
        {
            listacotizaciones = new List<Cotizacion>();
        }

        public static BancoCentral getInstancia()
        {
            if (instancia==null)
            {
                instancia = new BancoCentral();
            }
            return instancia;
        }

        public void colocar(string fecha, double valor )
        {
            listacotizaciones.Add(new Cotizacion(fecha, valor));
           
        }
        public double mostrar(string fecha)
        {
            foreach (Cotizacion cotizacion in listacotizaciones)
            {
                if (cotizacion.fecha == fecha)
                    return cotizacion.monto;
            }
            return 0;
        }

    }
}
