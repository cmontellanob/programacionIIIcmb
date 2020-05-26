using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenGrafico
{
    public partial class Form1 : Form
    {
        private Examen examen;
        int preguntaactual;
        public Form1()
        {
            InitializeComponent();
            examen = new Examen(10);
            examen.insertarPregunta("1+1","2");
            examen.insertarPregunta("2+2", "4");
            examen.insertarPregunta("3+1", "4");
            examen.insertarPregunta("5+1", "6");
            examen.insertarPregunta("1*1", "1");
            preguntaactual = 0;
            lPregunta.Text = examen.listapreguntas.ElementAt<Pregunta>(preguntaactual).enunciado;
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (preguntaactual < examen.listapreguntas.Count)
            {
                if (examen.listapreguntas.ElementAt<Pregunta>(preguntaactual).respuesta==txtRespuesta.Text)
                {
                    examen.calificacion++;

                }
                preguntaactual++;
                if (preguntaactual != examen.listapreguntas.Count)
                {
                    lPregunta.Text = examen.listapreguntas.ElementAt<Pregunta>(preguntaactual).enunciado;
                }
                else
                {
                    lMensaje.Text = "su calificacion es "+examen.calificacion;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            examen.duracionactual++;
            lblTiempoTranscurrido.Text = examen.duracionactual.ToString();
            if (examen.duracionactual==examen.duracionmaxima)
            {
                timer1.Stop();
                lMensaje.Text = "su calificacion es " + examen.calificacion;
                txtRespuesta.Enabled = false;
                btnResponder.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lMensaje.Text = "";
            txtRespuesta.Enabled = true;
            btnResponder.Enabled = true;
            timer1.Enabled = true;
            examen.duracionactual++;
            preguntaactual = 0;

        }

        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
