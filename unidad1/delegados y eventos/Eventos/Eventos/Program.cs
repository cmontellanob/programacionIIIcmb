using System;

namespace Eventos
{
    public class Operaciones // Esta es la clase publicadora
    {
        public delegate void Delegado(int n); // lafirma del deleado debe ocnincidir con la del Manejador de eventod
        public event Delegado CuandoRecibaMultiplosCinco; //evento aqui se suscriben lo manejadores de eventos 
        public int Sumar(int x, int y)
        {
            int iSuma = x + y;
            if ((iSuma % 5 == 0) && (CuandoRecibaMultiplosCinco != null)) // cuando ocurre el evento de sermultiplo de 5 tenemos que llamar a evento para dispare enlos suscriptores
            { CuandoRecibaMultiplosCinco(iSuma); }
            return iSuma;
        }
    }
    class ProgramaEvento
    {
            static void Main()
            {
                Operaciones o = new Operaciones();
                o.CuandoRecibaMultiplosCinco+= RecibeMultiploCinco;// nos estamos suscribiendo a eventoy mandandoalmanejador de eventos

                int res = o.Sumar(4, 3);
                Console.WriteLine("La suma es = {0}", res);
                res = o.Sumar(7, 8);
            Console.WriteLine("La suma es = {0}", res);
            Console.ReadKey();
            }
            static void RecibeMultiploCinco (int n) // Manejador de Evento
            {
                Console.WriteLine("Se obtuvo un multiplo de cinco valor: {0}",n);
            }
      }

    
}
