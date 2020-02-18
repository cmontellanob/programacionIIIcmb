namespace ClasesGenericas
{
    public class Pila<T>
    {
        private int tope;
        private T[] datos = new T[10];

        public void Insertar(T objeto) 
        { 
            datos[tope++] = objeto; 
        }

        public T Eliminar() 
        { 
            return datos[--tope]; 
        }
    }
}
