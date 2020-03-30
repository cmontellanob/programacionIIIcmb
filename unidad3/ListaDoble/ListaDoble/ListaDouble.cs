using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoble
{
    class Nodo
    {
        public int info;
        public Nodo Siguiente;
        public Nodo Anterior;

        public Nodo(int valor)
        {
            info = valor;
            Siguiente = null;
        }
    }
    class ListaDouble

    {
        public Nodo Actual;
        public void Insertar(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (Actual == null)
            { Actual = nuevo;
            }
            else
            {
                Nodo aux = Actual;
                Nodo ant = null;
                while (aux!= null && valor>aux.info)
                {
                    ant = aux;
                    aux = aux.Siguiente;

                }
                if (ant==null)
                {
                    Actual = nuevo;
                    nuevo.Siguiente = aux;
                    aux.Anterior = nuevo;
                } else
                {
                    ant.Siguiente = nuevo;
                    nuevo.Siguiente = aux;
                    nuevo.Anterior = ant;
                }
                
            }
        }
        public void Eliminar(int valor)
        {
            if (Actual != null)
            {
                Nodo aux = Actual;
                Nodo ant = null;
                while (aux.Siguiente != null && aux.info != valor)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                if (aux.info == valor)
                {
                    if (ant == null)
                        Actual = aux.Siguiente;
                    else
                        ant.Siguiente = aux.Siguiente;
                }
                else
                    Console.WriteLine("No se encontro el valor");


            }
        }
        public void Mostrar()
        {
            Console.WriteLine("Elentos de la lista:");
            if (Actual != null) // que la lista no estee vacia
            {
                Nodo aux = Actual;
                while (aux != null)
                {
                    Console.Write("{0}     ", aux.info);
                    aux = aux.Siguiente;

                }
            }
        }

 
}
