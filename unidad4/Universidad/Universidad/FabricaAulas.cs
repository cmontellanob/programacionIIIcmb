using System.Collections.Generic;

namespace Universidad
{
    class FabricaAulas:FabricaAbstracta
    {
               

        public Aula getAula(string Tipo, List<Computadora> lista)
        {
            switch (Tipo)
            {
                case "teoria":
                    return new Teoria();
                case "laboratorio":
                    return new Laboratorio(lista);

                default:
                    return null;

            }
        }

       

        public Persona getPersona(string Tipo)
        {
            throw new System.NotImplementedException();
        }
    }
}