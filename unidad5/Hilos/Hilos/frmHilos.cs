using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilos
{
    public partial class frmHilos : Form
    {
        public int contador = 0;
        // progreso contador para el hilo 1
        public int contador1 = 0;
        // progreso contador para el hilo 2
        public int contador2 = 0;
        // progreso contador para el hilo 3
        public int contador3 = 0;
        public frmHilos()
        {
            InitializeComponent();
                // General contador, can be used to measure executing time for each thread.
      
    }

        // progreso contador by 1
        private void thread1()
        {
            for (int i = 0; contador1 < 1000000000; i++)
                contador1++;
        }
        // progreso contador by 2
        private void thread2()
        {
            for (int i = 0; contador2 < 1000000000; i++)
                contador2 += 1;
        }

        // progreso contador by 4
        private void thread3()
        {
            for (int i = 0; contador3 < 1000000000; i++)
                contador3 += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double tmp = 0.00;
            contador++;
            textBox4.Text = contador.ToString();
            textBox1.Text = contador1.ToString();
            textBox2.Text = contador2.ToString();
            textBox3.Text = contador3.ToString();
            if (contador1 > 1)
            {
                tmp = ((double)contador1 / 1000000000) * 100;
                progressBar1.Value = (int)tmp;
                tmp = ((double)contador2 / 1000000000) * 100;
                progressBar2.Value = (int)tmp;
                tmp = ((double)contador3 / 1000000000) * 100;
                progressBar3.Value = (int)tmp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // crear  hilo 1
            ThreadStart newThread1 = new ThreadStart(thread1);
            Thread t1 = new Thread(newThread1);
            t1.Start();
            // crear  hilo 2
            ThreadStart newThread2 = new ThreadStart(thread2);
            Thread t2 = new Thread(newThread2);
            t2.Start();
            // crear  hilo 3
            ThreadStart newThread3 = new ThreadStart(thread3);
            Thread t3 = new Thread(newThread3);
            t3.Start();
        }
    }
}
