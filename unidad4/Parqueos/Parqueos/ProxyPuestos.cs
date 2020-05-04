using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueos
{
    class ProxyPuestos : IPuesto
    {
        private List<string> historial;

        private Puesto puesto ;

        public ProxyPuestos(int numero)
        {
            puesto = new Puesto(numero);
            historial = new List<string>();
        }

        public string ingresarAuto(Auto auto)
        {
            historial.Add(DateTime.Now.ToLongDateString()+" esta  ingresando el auto "+auto);
           return puesto.ingresarAuto(auto);
        }

        public double salirAuto()
        {
            historial.Add(DateTime.Now.ToLongDateString() + " esta  saliendo el auto " +puesto.getAuto());
            return puesto.salirAuto(); 
        }
        public void getHitorial()
        {
            string [] h= historial.ToArray();
            for (int i=0;i< h.Count();i++)
                Console.WriteLine(h[i]);
        }

        public bool estaOcupado()
        {
            return puesto.estaOcupado();
        }

        public Auto getAuto()
        {
            return puesto.getAuto();
        }
    }
}
