using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class ConexionMYSQL:IConexion
    {
        String cadenaConexion;
        public void conectar()

        {
            Console.WriteLine("Se conectó de MYSQL");
        }
        public void desconectar()
        {
            Console.WriteLine("Se desconectó de MYSQL");
        }
    }
}
