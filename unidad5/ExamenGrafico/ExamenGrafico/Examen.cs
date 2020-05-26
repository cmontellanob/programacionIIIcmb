using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrafico
{
    class Examen
    {
        public int calificacion;
        public int duracionmaxima;
        public int duracionactual;
        public List<Pregunta> listapreguntas;

        public Examen(int duracionmaxima)
        {
            calificacion = 0;
            duracionactual = 0;
            this.duracionmaxima = duracionmaxima;
            listapreguntas = new List<Pregunta>();
        }
        public void insertarPregunta(string enunciado, string respuesta)
        {
            listapreguntas.Add(new Pregunta(enunciado, respuesta));
        }
        public void contar()
        {
            TimeSpan Inicio = new TimeSpan(DateTime.Now.Ticks);
            int segundos = Inicio.Seconds;
            while (duracionactual != duracionmaxima)
            {
                int nuevossegundos = new TimeSpan(DateTime.Now.Ticks).Seconds;
                if (nuevossegundos != segundos)
                {
                    duracionactual++;
                    segundos = nuevossegundos;

                }
            }
            Console.WriteLine(" termino su tiempo su calificacion es {0}", calificacion);

        }

    }
}
