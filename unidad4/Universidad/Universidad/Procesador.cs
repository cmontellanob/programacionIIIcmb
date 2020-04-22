namespace Universidad
{
    class Procesador
    {
        string marca;
        int frecuencia;

        public Procesador(string marca, int frecuencia)
        {
            this.marca = marca;
            this.frecuencia = frecuencia;
        }

        public override string ToString()
        {
            return marca+" "+frecuencia.ToString()+"Ghz";
        }
    }
}