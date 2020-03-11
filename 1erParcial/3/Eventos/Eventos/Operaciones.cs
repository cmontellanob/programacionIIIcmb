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
        public event Delegado CuandoDiscirminanteMenor0; //evento aqui se suscriben lo manejadores de eventos 
        public void Raices(int a, int b, int c)
        {
            Double iDiscriminante = (b * b - 4 * a * c);
            if (iDiscriminante > 0) // cuando ocurre el evento de sermultiplo de 5 tenemos que llamar a evento para dispare enlos suscriptores
            {
                Double x1 = (-b + Math.Sqrt(iDiscriminante)) / 2 * a;
                Double x2 = (-b - Math.Sqrt(iDiscriminante)) / 2 * a;
                Console.WriteLine("x1= {0}", x1);
                Console.WriteLine("x1= {0}", x2);
            }
            else
            {
                if (CuandoDiscirminanteMenor0 != null)
                {
                    CuandoDiscirminanteMenor0();
                }
            }

        }

    }
}
