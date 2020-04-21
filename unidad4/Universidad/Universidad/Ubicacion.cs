namespace Universidad
{
    class Ubicacion
    {
        int piso;
        int nroaula;

        public Ubicacion(int piso, int nroaula)
        {
            this.piso = piso;
            this.nroaula = nroaula;
        }

        public override  string ToString()
        {
            return piso.ToString() + nroaula.ToString();
        }
    }
}