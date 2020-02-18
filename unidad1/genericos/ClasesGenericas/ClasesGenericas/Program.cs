using System;

namespace ClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila<double> stack = new Pila<double>();
            stack.Insertar(5.5);
            stack.Insertar(10.1);

            double x = stack.Eliminar(); 
            double y = stack.Eliminar(); 

            Console.WriteLine("x: {0}, y: {1}", x, y);

            Pila<string> stack1 = new Pila<string>();
            stack1.Insertar("franco");
            stack1.Insertar("momos");

            string a = stack1.Eliminar();
            string b = stack1.Eliminar();
            Console.WriteLine("a:{0},b:{1}", a, b);



            Console.ReadKey();
        }
    }
}
