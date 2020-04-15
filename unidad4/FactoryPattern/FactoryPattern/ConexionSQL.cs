using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
     public class ConexionSQL :IConexion
    {


    private String host;
    private String puerto;
    private String usuario;
    private String contrasena;

    public ConexionSQL()
    {
        this.host = "localhost";
        this.puerto = "1433";
        this.usuario = "postgres";
        this.contrasena = "123";
    }

        public void conectar()
        {
            Console.WriteLine("Se conectó de SQLServer");
        }

        public void desconectar()
    {
       Console.WriteLine("Se desconectó de SQLServer");
    }

    


    
    }
}
