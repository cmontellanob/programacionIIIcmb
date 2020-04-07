using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles
{
    class Arbol
    {
        private Nodo raiz;
    
        public void insertar(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo aux = raiz;
                Nodo ant = null;
                while (aux!=null)
                {
                    if (valor.CompareTo(aux.info)>=0)
                    {
                        ant = aux;
                        aux = aux.der;
                    }
                    else
                    {
                        ant = aux;
                        aux = aux.izq;
                    }
                }
                // en ant tengo el nodo anterior
                if (valor.CompareTo(ant.info) >= 0)
                {
                    ant.der = nuevo;
                }
                else
                {
                    ant.izq = nuevo;
                }


            }
        }
        public void eliminar(String valor)
        {
            if (raiz == null)
                Console.WriteLine("el arbol esta vacio");
            else
            {
                Nodo aux = raiz;
                Nodo ant = null;
                while (valor!=aux.info && aux != null)
                {
                    if (valor.CompareTo(aux.info) >= 0)
                    {
                        ant = aux;
                        aux = aux.der;
                    }
                    else
                    {
                        ant = aux;
                        aux = aux.izq;
                    }
                }
                // en ant tengo el nodo anterior
                if (valor==aux.info)
                {
                    // lo encontro
                    if (valor.CompareTo(ant.info) >= 0)
                    {
                        ant.der = aux.der;
                        Nodo hijo = aux.der;
                        while (hijo.izq != null)
                        {
                            hijo = hijo.izq;
                        }
                        hijo.izq = aux.izq;
                    }
                    else
                    {
                        ant.izq = aux.izq;
                        Nodo hijo = aux.izq;
                        while (hijo.der!=null)
                        {
                            hijo = hijo.der;
                        }
                        hijo.der = aux.der;
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro al elemento");
                }


            }

        }
        private void PreOrden(Nodo aux )
        {
            if (aux!=null)
            {
                Console.Write("{0} ",aux.info);
                PreOrden(aux.izq);
                PreOrden(aux.der);
            }
            
        }

         public void mostrarPreOrden()
         {
            Nodo aux = raiz;
            PreOrden(aux);
         }

        private void InOrden(Nodo aux)
        {
            if (aux != null)
            {
                InOrden(aux.izq);
                Console.Write("{0} ", aux.info);
                InOrden(aux.der);
            }

        }
        public void mostrarInOrden()
         {
            Nodo aux = raiz;
            InOrden(aux);
        }
        private void PosOrden(Nodo aux)
        {
            if (aux != null)
            {
                PosOrden(aux.izq);
                PosOrden(aux.der);
                Console.Write("{0} ", aux.info);

            }

        }


        public void mostrarPosOrden()
         {
            Nodo aux = raiz;
            PosOrden(aux);

        }

    }
}