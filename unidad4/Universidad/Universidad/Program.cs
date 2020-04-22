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
            Console.WriteLine( univalle.getDatos());

            FabricaPersonas fabricapersonas = new FabricaPersonas();
            Persona carlos = fabricapersonas.getPersona("docente");
            Persona kasandra = fabricapersonas.getPersona("alumno");
            carlos.setDatos("Carlos", "Montellano", Sexo.Masculino, "17/12/75", 72880553, "carlosmontellano@gmail.com");
            Console.WriteLine(carlos.getDatos());
            
            kasandra.setDatos("Kasandra","Cuellar",Sexo.Femenino,"05/04/2001",7156587,"kasandra@gmail.com");
            Console.WriteLine(kasandra.getDatos());
            FabricaAulas fabricaaulas = new FabricaAulas();

            Aula a202 = fabricaaulas.getAula("teoria",null);
            a202.setDatos("A202", new Ubicacion(1, 2), new Tamano(3, 4), 30);
            List<Computadora> lc = new List<Computadora>();
            List<DiscoDuro> l = new List<DiscoDuro>();
            l.Add(new DiscoDuro("hitachi", 2, MedidaCapacidad.Tb));
            Computadora c = new Computadora(Marca.Lenovo, "tinkpad", new Procesador("Intel", 24), l, Color.negro, 2018);
            for (int i=1;i<=18;i++)
            {
                lc.Add((Computadora)c.Clone());
            }
            Aula l302 = fabricaaulas.getAula("laboratorio",lc);
            l302.setDatos("L302", new Ubicacion(1, 4), new Tamano(3, 5), 25);
            Console.WriteLine(a202.getDatos());
            Console.WriteLine(l302.getDatos());
           
            Console.WriteLine(c);
            Computadora c2 =(Computadora) c.Clone();
            Console.WriteLine(c2);
            
            Console.ReadKey();

        }
    }
}
