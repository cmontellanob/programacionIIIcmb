namespace Examen
{
     class Pregunta
    {
        public string enunciado;
        public string respuesta;
        public string respuestacorrecta;

        public Pregunta(string enunciado,string respuestacorrecta)
        {
            this.enunciado = enunciado;
            this.respuestacorrecta = respuestacorrecta;

        }
    }
}