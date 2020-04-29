using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaPilaCola
{
    class Fachada
    {
        Pila<string> p;
        Cola<string> c;

        public Fachada()
        {
            p = new Pila<string>();
            c = new Cola<string>();
        }
        public void InsertarPila(string valor)
        {
            p.insertar(valor);
        }
        public void EliminarPila()
        {
            String resultado = p.eliminar();
            Console.WriteLine(resultado);
        }
        public void MostrarPila()
        {
            p.mostrar();
        }
        public void InsertarCola(string valor)
        {

        }
        public void EliminarCola()
        {

        }
        public void MostrarCola()
        {

        }

    }
}
