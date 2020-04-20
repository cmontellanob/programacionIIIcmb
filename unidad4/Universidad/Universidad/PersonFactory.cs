using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    class PersonFactory
    {
        public Person getPersona(String tipo)
        {
            switch (tipo)
            {
                case "student":
                    return new Student();
                case "professor":
                    return new Professor();
                case "administrador":
                    return new Professor();

                default:
                    return null; 

            }
        }
    }
}
