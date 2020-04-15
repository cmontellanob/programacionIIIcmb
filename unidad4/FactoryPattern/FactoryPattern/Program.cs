using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabrica f= new Fabrica();

            IConexion cx1 = f.getConexion("MYSQL");
            cx1.conectar();
            cx1.desconectar();

            IConexion cx2 = f.getConexion("SQLSERVER");
            cx2.conectar();
            cx2.desconectar();

            Console.ReadKey();
        }
    }
}
