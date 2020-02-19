using System;

namespace Eventos2
{
    public class Operacionesvector // Esta es la clase publicadora
    {
        public delegate void Delegado(int[] arreglo); // lafirma del deleado debe coincidir con la del Manejador de eventod
        public event Delegado CuandoseIntroduce1; //evento aqui se suscriben lo manejadores de eventos 
        public  void Llenar(int[] arreglo)
        {
            Console.WriteLine("Introduzca valores");
            for (int i = 0; i < 5; i++)
            {
                arreglo[i] = int.Parse(Console.ReadLine());
                if ((arreglo[i]==-1) && (CuandoseIntroduce1 != null))
                        {
                    CuandoseIntroduce1(arreglo);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[5];
            Operacionesvector op = new Operacionesvector();
            op.CuandoseIntroduce1 += MostrarVector; // suscribirse al evento
            op.Llenar(arreglo);
        }
        static void MostrarVector(int[] arreglo)
        {
            foreach (int elemento in arreglo)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
