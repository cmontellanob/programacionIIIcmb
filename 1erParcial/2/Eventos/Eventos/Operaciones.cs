using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class Operaciones
    {
        public delegate void Delegado(); // lafirma del deleado debe ocnincidir con la del Manejador de eventod
        public event Delegado CuandoRecibaMultiplosTres; //evento aqui se suscriben lo manejadores de eventos 
        public int Multiplicar(int a, int b,int c)
        {
            int iProducto = a * b* c;
            int iProductoDividido = iProducto/2;
            if ((iProductoDividido % 3 == 0) && (CuandoRecibaMultiplosTres != null)) // cuando ocurre el evento de sermultiplo de 5 tenemos que llamar a evento para dispare enlos suscriptores
            { CuandoRecibaMultiplosTres(); }
            return iProducto;
        }
    }
}
