using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingleObject
    {
        private static SingleObject instance;
        private String a;

        private SingleObject()
        {
            
        }
        public static SingleObject getInstance()
        {
            if (instance == null)
            {
                instance = new SingleObject();
                return instance;
            }
            else
                return instance;

        }
        public void seta(String valor)
        {
            a = valor;
        }
        public void showMessage()
        {
            Console.WriteLine("hola singleton: "+a);
        }
    }
}
