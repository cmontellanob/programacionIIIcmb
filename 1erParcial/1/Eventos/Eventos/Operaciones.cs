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
        public event Delegado CuandoRecibaMultiplosCuatro; //evento aqui se suscriben lo manejadores de eventos 
        public int Promedio(int a, int b,int c)
        {
            int iPromedio = (a + b+ c)/3;
            int iSuma = a + b + c;
            if ((iSuma % 4 == 0) && (CuandoRecibaMultiplosCuatro != null)) // cuando ocurre el evento de sermultiplo de 5 tenemos que llamar a evento para dispare enlos suscriptores
            { CuandoRecibaMultiplosCuatro(); }
            return iPromedio;
        }
    }
}
