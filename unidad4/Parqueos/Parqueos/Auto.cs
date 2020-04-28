using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueos
{
    class Auto
    {
        Color color;
        Marca marca;
        Tipo tipo;
        String modelo;
        int anio;
        String placa;

        public Auto(Color color, Marca marca, Tipo tipo, string modelo, int anio, string placa)
        {
            this.color = color;
            this.marca = marca;
            this.tipo = tipo;
            this.modelo = modelo;
            this.anio = anio;
            this.placa = placa;
        }
        public Auto(Color color, Marca marca, Tipo tipo,  string placa)
        {
            this.color = color;
            this.marca = marca;
            this.tipo = tipo;
            this.placa = placa;
        }
        public String getPlaca()
        {
            return placa;
        }

        public override string ToString()
        {
            return tipo.ToString()+" "+color.ToString()+ " placa: " +placa ;
        }
    }
    enum Color
    {
        rojo,azul,negro,blanco
    }
    enum Tipo
    {
        vagonenta, camioneta,auto,camion,motocicleta
    }
    enum Marca
    {
        Toyota, Nissan, Susuki,Ford, Fiat 
    }
}
