using System;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    abstract class Persona
    {
       protected String nombres;
       protected String apellidos;
       protected Sexo sexo;
       protected String fechanacimiento;
        protected int celular;
        protected String correo;

        public void setDatos(string nombres, string apellidos, Sexo sexo, string fechanacimiento, int celular, string correo)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.sexo = sexo;
            this.fechanacimiento = fechanacimiento;
            this.celular = celular;
            this.correo = correo;
        }

        public int getEdad()
        {
            return 0;
        }
       abstract public String getDatos();
    }
    enum Sexo
    {
        Masculino,
        Femenino
    }
}
