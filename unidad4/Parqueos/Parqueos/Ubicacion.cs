namespace Parqueos
{
    class Ubicacion
    {
        string calle;
        int numero;

        public Ubicacion(string calle, int numero)
        {
            this.calle = calle;
            this.numero = numero;
        }

        public override string ToString()
        {
            return "calle: " + calle + " # " + numero;
        }
    }
}