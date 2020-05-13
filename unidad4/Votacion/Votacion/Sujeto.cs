using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votacion
{
    class Sujeto
    {
        int a;
        int b;
        int c;

        public Sujeto(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void setDatos(int a, int b, int c)
        {
            if (a + b + c == 100)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }
    }
}
