using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueos
{
    class ProxyPuestos : APuesto
    {
        private Puesto puesto;
        protected List<string> historial;
        public ProxyPuestos(int numero)
        {
            Puesto puesto = new Puesto(numero);
            historial = new List<string>();
        }

        public override string ingresarAuto(Auto auto)
        {
            historial.Add(DateTime.Now.ToLongDateString()+" esta  ingresando el auto "+auto);
           return puesto.ingresarAuto(auto);
        }

        public override double salirAuto()
        {
            historial.Add(DateTime.Now.ToLongDateString() + " esta  saliendo el auto " + auto);
            return puesto.salirAuto(); 
        }
        public void getHitorial()
        {
            Console.WriteLine(historial);
        }
    }
}
