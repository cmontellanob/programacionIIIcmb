using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Examen
    {
        int calificacion;
        int duracionmaxima;
        int duracionactual;
        List<Pregunta> listapreguntas;

        public Examen(int duracionmaxima)
        {
            calificacion = 0;
            duracionactual = 0;
            this.duracionmaxima = duracionmaxima;
            listapreguntas=new List<Pregunta> ();
        }
        public void insertarPregunta(string enunciado,string respuesta)
        {
            listapreguntas.Add(new Pregunta(enunciado,respuesta));
        }
        public void iniciarExamen()
        {
            foreach (Pregunta p in listapreguntas)
            {
                Console.WriteLine(p.enunciado);
                p.respuesta=Console.ReadLine();
                if (p.respuesta==p.respuestacorrecta)
                {
                    calificacion++;
                }
            }
            Console.WriteLine(" termino el examen su calificacion es {0}",calificacion);
            Console.ReadKey();
            
        }
        public void contar()
        {
            TimeSpan Inicio = new TimeSpan(DateTime.Now.Ticks);
            int segundos=Inicio.Seconds;
            while (duracionactual!=duracionmaxima)
            {
                int nuevossegundos=new TimeSpan(DateTime.Now.Ticks).Seconds;
                if (nuevossegundos != segundos)
                {
                    duracionactual++;
                    segundos = nuevossegundos;
                 
                }
            }
            Console.WriteLine("su tiemppo se termino");
            
        }




    }
}
