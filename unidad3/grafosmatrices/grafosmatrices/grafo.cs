using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafosmatrices
{
    class grafo
    {
        int[,] matrizadiaciencia;

        public grafo(int numeronodos)
        {
            this.matrizadiaciencia = new int[numeronodos, numeronodos];
        }

        public void insertarrama(int x, int y)

        {
            matrizadiaciencia[x, y] = 1;
        }
        public void mostrar()
        {
            foreach (int fila in matrizadiaciencia)
                Console.WriteLine(fila);




        }
    }
}
