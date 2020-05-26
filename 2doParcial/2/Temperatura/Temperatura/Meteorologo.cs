using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class Meteorologo
    {
        static Meteorologo instancia;
            List<TemperaturaCiudad> listatemperaturas;

            private Meteorologo()
            {
            listatemperaturas = new List<TemperaturaCiudad>();
            }

            public static Meteorologo getInstancia()
            {
                if (instancia == null)
                {
                    instancia = new Meteorologo();
                }
                return instancia;
            }

            public void colocar(string ciudad, int temperatura)
            {
                listatemperaturas.Add(new TemperaturaCiudad(ciudad, temperatura));

            }
            public double mostrar(string ciudad)
            {
                foreach (TemperaturaCiudad temperaturaciudad in listatemperaturas)
                {
                    if (temperaturaciudad.ciudad == ciudad)
                        return temperaturaciudad.temperatura;
                }
                return 0;
            }

        }
    }
}
