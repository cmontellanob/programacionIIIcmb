using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    class University
    {
        String nombre;
        int nit;
        TipoUniversidad tipouniversidad;
        String URL;
        static University Instancia;

        private University()
        {
        }
        public void setDatos(string nombre, int nit, TipoUniversidad tipouniversidad, string uRL)
        {
            this.nombre = nombre;
            this.nit = nit;
            this.tipouniversidad = tipouniversidad;
            URL = uRL;

        }
        public string getDatos()
        {
            return "Nombre: " + nombre + "nit:" + nit + "tipo:" + tipouniversidad.ToString() + "url:" + URL;
        }
        public static University getInstancia()
        {
            if (Instancia==null)
            {
                Instancia = new University();
            } 
            return Instancia;

        }
    }
    enum TipoUniversidad
    {
        Publica,
        Privada
    }
}
