using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos1
{

    public delegate void ActualizacionEventHandler(string msg);

    public class Empleado
        {
            //atributo
            private string Nombre;

            //declaración del evento
            public event ActualizacionEventHandler NombreCambiado;

            public Empleado(String Nombre)
            {
                this.Nombre = Nombre;
            }

            public void setNombre(string s)
            {
                //actualizar el atributo
                string anteriorNombre = this.Nombre;
                this.Nombre = s;

            //lanzar el evento
            if  (s!=anteriorNombre)
             if (this.NombreCambiado != null)
                    this.NombreCambiado("Era " + anteriorNombre + " y ahora es "+this.Nombre);
            }

        }
   }


