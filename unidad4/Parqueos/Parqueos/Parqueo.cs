using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueos
{
    class Parqueo
    {
        String nombre;
        Ubicacion ubicacion;
        double costo;
        int capacidad;
        private ProxyPuestos[] puestos;

        public Parqueo(string nombre, Ubicacion ubicacion, double costo, int capacidad)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            this.costo = costo;
            this.capacidad = capacidad;
            this.puestos = new ProxyPuestos[capacidad];
            for (int i = 0; i < this.puestos.Count(); i++)
            {
                this.puestos[i] = new ProxyPuestos(i);
            }
        }
        private int getIndicePuesto()
        {
            int indice = -1;
            int i = 0;
            while ((i < puestos.Count()) && indice == -1)
            {
                if (!puestos[i].estaOcupado())
                {
                    indice = i;
                }
                i++;
            }
            return indice;
        }
        public string ingresarAuto(Color color, Marca marca, Tipo tipo, string placa)
        {
            Auto auto = new Auto(color, marca, tipo, placa);
            int nropuesto = getIndicePuesto();
            if (nropuesto == -1)
                return "No hay espacio";
            else
            {
                puestos[nropuesto].ingresarAuto(auto);
                return "Su lugar es el " + nropuesto.ToString();
            }
        }
        public string SalirAuto(string placa)
        {
            int nropuesto = buscarPuesto(placa);
            if (nropuesto != -1)
            {
                double totalhoras = puestos[nropuesto].salirAuto();
                double tarifa = totalhoras * costo;
                return "su tarifa es " + Convert.ToString(tarifa);
            }
            else
                return "placa no encontrada";
            
        }

        private int buscarPuesto(string placa)
        {
            int indice = -1;
            int i = 0;
            while ((i < puestos.Count()) && indice == -1)
            {
                if (puestos[i].getAuto().getPlaca()==placa)
                {
                    indice = i;
                }
                i++;

            }
            return indice;
        }


            public void getDatos()
        {
            for (int i = 0; i < this.puestos.Count(); i++)
            {
                if (puestos[i].estaOcupado())
                    Console.WriteLine("Puesto {0} Ocupado auto {1}",i,puestos[i].getAuto());
                else
                    Console.WriteLine("Puesto {0} Ocupado", i);
            }
        }
        public override string ToString()
        {
            return "Parqueo: "+nombre +" "+ ubicacion;
        }
        public void getHistorial(int indice)
        {
            puestos[indice].getHitorial();
        }
    }
}
