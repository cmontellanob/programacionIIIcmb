namespace ExamenGrafico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lPregunta = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.btnResponder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTiempoTranscurrido = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lMensaje = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lPregunta
            // 
            this.lPregunta.AutoSize = true;
            this.lPregunta.Location = new System.Drawing.Point(183, 48);
            this.lPregunta.Name = "lPregunta";
            this.lPregunta.Size = new System.Drawing.Size(13, 13);
            this.lPregunta.TabIndex = 0;
            this.lPregunta.Text = "()";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Enabled = false;
            this.txtRespuesta.Location = new System.Drawing.Point(188, 77);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(328, 20);
            this.txtRespuesta.TabIndex = 1;
            this.txtRespuesta.TextChanged += new System.EventHandler(this.txtRespuesta_TextChanged);
            // 
            // btnResponder
            // 
            this.btnResponder.Enabled = false;
            this.btnResponder.Location = new System.Drawing.Point(188, 117);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(79, 32);
            this.btnResponder.TabIndex = 2;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tiempo Transcurrido";
            // 
            // lblTiempoTranscurrido
            // 
            this.lblTiempoTranscurrido.AutoSize = true;
            this.lblTiempoTranscurrido.Location = new System.Drawing.Point(733, 14);
            this.lblTiempoTranscurrido.Name = "lblTiempoTranscurrido";
            this.lblTiempoTranscurrido.Size = new System.Drawing.Size(13, 13);
            this.lblTiempoTranscurrido.TabIndex = 4;
            this.lblTiempoTranscurrido.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lMensaje
            // 
            this.lMensaje.AutoSize = true;
            this.lMensaje.Location = new System.Drawing.Point(185, 175);
            this.lMensaje.Name = "lMensaje";
            this.lMensaje.Size = new System.Drawing.Size(16, 13);
            this.lMensaje.TabIndex = 5;
            this.lMensaje.Text = "...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "IniciarPrueba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lMensaje);
            this.Controls.Add(this.lblTiempoTranscurrido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.lPregunta);
            this.Name = "Form1";
            this.Text = "Examen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPregunta;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTiempoTranscurrido;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lMensaje;
        private System.Windows.Forms.Button button1;
    }
}

