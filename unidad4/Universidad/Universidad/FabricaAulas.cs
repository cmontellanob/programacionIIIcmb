namespace Universidad
{
    class FabricaAulas:FabricaAbstracta
    {
               

        public Aula getAula(string Tipo)
        {
            switch (Tipo)
            {
                case "teoria":
                    return new Teoria();
                case "laboratorio":
                    return new Laboratorio();

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