using System.Collections.Generic;

namespace Universidad
{
    interface FabricaAbstracta
    {
        Persona getPersona(string Tipo);
        Aula getAula(string Tipo, List<Computadora> lista);

    }
}