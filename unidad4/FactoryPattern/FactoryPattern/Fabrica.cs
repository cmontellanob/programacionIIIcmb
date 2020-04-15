using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Fabrica
    {
        public IConexion getConexion(String motor)
        {
            if (motor == "MYSQL")
            {
                return new ConexionMYSQL();
            }
            else
            {
                return new ConexionSQL();
            }

        }

    }
}
