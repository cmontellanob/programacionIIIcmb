using System;

namespace Universidad
{
    class FabricaPersonas: FabricaAbstracta
    {
        
            public Aula getAula(string Tipo)
            {
                throw new NotImplementedException();
            }

            public Persona getPersona(string Tipo)
            {
                switch (Tipo)
                {
                    case "alumno":
                        return new Alumno();
                    case "docente":
                        return new Docente();
                    case "adminsitrativo":
                        return new Docente();

                    default:
                        return null;

                }
            }

            


     }

     
}