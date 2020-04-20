using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    class Program2
    {
        static void Main(string[] args)
        {
            University univalle = University.getInstancia();
            univalle.setDatos("Univalle",15654,TipoUniversidad.Privada,"http://univalle.edu");

            univalle.getDatos();

            PersonFactory fabricapersonas = new PersonFactory();
            Person carlos = fabricapersonas.getPersona("professor");
            Person kasandra = fabricapersonas.getPersona("student");
            kasandra.PurchaceParkingTicket();

           
        }
    }
}
