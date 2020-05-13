﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObervadorPatron
{
    class SolObservador:Observador
    {
        private double valorCambio = 3.25;

        public SolObservador(Sujeto sujeto)
        {
            this.sujeto = sujeto;
            this.sujeto.agregar(this); //incluirde a la lista
        }

        public override void actualizar()
        {
           Console.WriteLine("PEN: " + (sujeto.getMontocambio() * valorCambio));
        }
        
    }
}
