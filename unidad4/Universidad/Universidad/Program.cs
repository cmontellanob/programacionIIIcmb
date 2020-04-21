using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Universidad univalle = Universidad.getInstancia();
            univalle.setDatos("Univalle", 15654, TipoUniversidad.Privada, "http://univalle.edu");
            Console.Writeline( univalle.getDatos());

            FabricaPersonas fabricapersonas = new FabricaPersonas();
            Persona carlos = fabricapersonas.getPersona("docente");
            Persona kasandra = fabricapersonas.getPersona("alumno");
            carlos.setDatos("Carlos", "Montellano", Sexo.Masculino, "17/12/75", 72880553, "carlosmontellano@gmail.com");
            Console.WriteLine(carlos.getDatos());
            
            kasandra.setDatos("Kasandra","Cuellar",Sexo.Femenino,"05/04/2001",7156587,"kasandra@gmail.com");
            Console.WriteLine(kasandra.getDatos());
            FabricaAulas fabricaaulas = new FabricaAulas();

            Aula a202 = fabricaaulas.getAula("teoria");
            a202.setDatos("A202", new Ubicacion(1, 2), new Tamano(3, 4), 30);
            Aula l302 = fabricaaulas.getAula("laboratorio");
            l302.setDatos("L302", new Ubicacion(1, 4), new Tamano(3, 5), 25);
            Console.WriteLine(a202.getDatos());
            Console.WriteLine(l302.getDatos());
            Console.ReadKey();

        }
    }
}
