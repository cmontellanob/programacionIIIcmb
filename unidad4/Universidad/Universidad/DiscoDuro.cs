namespace Universidad
{
    class DiscoDuro
    {
        string marca;
        int capacidad;
        MedidaCapacidad medidacapacidad;

        public DiscoDuro(string marca, int capacidad, MedidaCapacidad medidacapacidad)
        {
            this.marca = marca;
            this.capacidad = capacidad;
            this.medidacapacidad = medidacapacidad;
        }
    }
    enum MedidaCapacidad
    {  Mb, Gb, Tb

    }
}