namespace Proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPregunta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BarraTiempo = new System.Windows.Forms.ProgressBar();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.btnJugar = new CustomControls.RJControls.Boton();
            this.btnRondas = new CustomControls.RJControls.Boton();
            this.boton8 = new CustomControls.RJControls.Boton();
            this.boton7 = new CustomControls.RJControls.Boton();
            this.boton6 = new CustomControls.RJControls.Boton();
            this.boton5 = new CustomControls.RJControls.Boton();
            this.btnD = new CustomControls.RJControls.Boton();
            this.btnC = new CustomControls.RJControls.Boton();
            this.btnB = new CustomControls.RJControls.Boton();
            this.btnA = new CustomControls.RJControls.Boton();
            this.boton1 = new CustomControls.RJControls.Boton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.ForeColor = System.Drawing.Color.White;
            this.lblPregunta.Location = new System.Drawing.Point(112, 24);
            this.lblPregunta.MaximumSize = new System.Drawing.Size(1030, 200);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(152, 51);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "label1";
            this.lblPregunta.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(81, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BarraTiempo
            // 
            this.BarraTiempo.Location = new System.Drawing.Point(722, 710);
            this.BarraTiempo.Maximum = 1000;
            this.BarraTiempo.Name = "BarraTiempo";
            this.BarraTiempo.Size = new System.Drawing.Size(399, 55);
            this.BarraTiempo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarraTiempo.TabIndex = 11;
            this.BarraTiempo.Value = 1000;
            this.BarraTiempo.Visible = false;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.White;
            this.lblPuntos.Location = new System.Drawing.Point(36, 699);
            this.lblPuntos.MaximumSize = new System.Drawing.Size(1030, 200);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(328, 51);
            this.lblPuntos.TabIndex = 13;
            this.lblPuntos.Text = "Puntuación:  0";
            this.lblPuntos.Visible = false;
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.White;
            this.btnJugar.BackgroundColor = System.Drawing.Color.White;
            this.btnJugar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnJugar.BorderRadius = 14;
            this.btnJugar.BorderSize = 0;
            this.btnJugar.FlatAppearance.BorderSize = 0;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.ForeColor = System.Drawing.Color.Black;
            this.btnJugar.Location = new System.Drawing.Point(372, 369);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(367, 82);
            this.btnJugar.TabIndex = 17;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.TextColor = System.Drawing.Color.Black;
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnRondas
            // 
            this.btnRondas.BackColor = System.Drawing.Color.Red;
            this.btnRondas.BackgroundColor = System.Drawing.Color.Red;
            this.btnRondas.BorderColor = System.Drawing.Color.Transparent;
            this.btnRondas.BorderRadius = 20;
            this.btnRondas.BorderSize = 0;
            this.btnRondas.Enabled = false;
            this.btnRondas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRondas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRondas.ForeColor = System.Drawing.Color.White;
            this.btnRondas.Location = new System.Drawing.Point(25, 24);
            this.btnRondas.Name = "btnRondas";
            this.btnRondas.Size = new System.Drawing.Size(74, 71);
            this.btnRondas.TabIndex = 16;
            this.btnRondas.TextColor = System.Drawing.Color.White;
            this.btnRondas.UseVisualStyleBackColor = false;
            this.btnRondas.Visible = false;
            // 
            // boton8
            // 
            this.boton8.BackColor = System.Drawing.Color.Red;
            this.boton8.BackgroundColor = System.Drawing.Color.Red;
            this.boton8.BorderColor = System.Drawing.Color.Transparent;
            this.boton8.BorderRadius = 14;
            this.boton8.BorderSize = 0;
            this.boton8.FlatAppearance.BorderSize = 0;
            this.boton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton8.ForeColor = System.Drawing.Color.White;
            this.boton8.Location = new System.Drawing.Point(722, 566);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(51, 46);
            this.boton8.TabIndex = 9;
            this.boton8.Text = "D";
            this.boton8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boton8.TextColor = System.Drawing.Color.White;
            this.boton8.UseVisualStyleBackColor = false;
            this.boton8.Visible = false;
            // 
            // boton7
            // 
            this.boton7.BackColor = System.Drawing.Color.Red;
            this.boton7.BackgroundColor = System.Drawing.Color.Red;
            this.boton7.BorderColor = System.Drawing.Color.Transparent;
            this.boton7.BorderRadius = 14;
            this.boton7.BorderSize = 0;
            this.boton7.FlatAppearance.BorderSize = 0;
            this.boton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton7.ForeColor = System.Drawing.Color.White;
            this.boton7.Location = new System.Drawing.Point(722, 308);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(51, 46);
            this.boton7.TabIndex = 8;
            this.boton7.Text = "B";
            this.boton7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boton7.TextColor = System.Drawing.Color.White;
            this.boton7.UseVisualStyleBackColor = false;
            this.boton7.Visible = false;
            // 
            // boton6
            // 
            this.boton6.BackColor = System.Drawing.Color.Red;
            this.boton6.BackgroundColor = System.Drawing.Color.Red;
            this.boton6.BorderColor = System.Drawing.Color.Transparent;
            this.boton6.BorderRadius = 14;
            this.boton6.BorderSize = 0;
            this.boton6.FlatAppearance.BorderSize = 0;
            this.boton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton6.ForeColor = System.Drawing.Color.White;
            this.boton6.Location = new System.Drawing.Point(714, 434);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(51, 46);
            this.boton6.TabIndex = 7;
            this.boton6.Text = "C";
            this.boton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boton6.TextColor = System.Drawing.Color.White;
            this.boton6.UseVisualStyleBackColor = false;
            this.boton6.Visible = false;
            // 
            // boton5
            // 
            this.boton5.BackColor = System.Drawing.Color.Red;
            this.boton5.BackgroundColor = System.Drawing.Color.Red;
            this.boton5.BorderColor = System.Drawing.Color.Transparent;
            this.boton5.BorderRadius = 14;
            this.boton5.BorderSize = 0;
            this.boton5.FlatAppearance.BorderSize = 0;
            this.boton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton5.ForeColor = System.Drawing.Color.White;
            this.boton5.Location = new System.Drawing.Point(714, 183);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(51, 46);
            this.boton5.TabIndex = 6;
            this.boton5.Text = "A";
            this.boton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boton5.TextColor = System.Drawing.Color.White;
            this.boton5.UseVisualStyleBackColor = false;
            this.boton5.Visible = false;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.White;
            this.btnD.BackgroundColor = System.Drawing.Color.White;
            this.btnD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnD.BorderRadius = 14;
            this.btnD.BorderSize = 0;
            this.btnD.FlatAppearance.BorderSize = 0;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.Color.Black;
            this.btnD.Location = new System.Drawing.Point(735, 589);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(367, 82);
            this.btnD.TabIndex = 5;
            this.btnD.TextColor = System.Drawing.Color.Black;
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Visible = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.White;
            this.btnC.BackgroundColor = System.Drawing.Color.White;
            this.btnC.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnC.BorderRadius = 14;
            this.btnC.BorderSize = 0;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.Black;
            this.btnC.Location = new System.Drawing.Point(735, 457);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(367, 82);
            this.btnC.TabIndex = 4;
            this.btnC.TextColor = System.Drawing.Color.Black;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Visible = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.White;
            this.btnB.BackgroundColor = System.Drawing.Color.White;
            this.btnB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnB.BorderRadius = 14;
            this.btnB.BorderSize = 0;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.ForeColor = System.Drawing.Color.Black;
            this.btnB.Location = new System.Drawing.Point(735, 325);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(367, 82);
            this.btnB.TabIndex = 3;
            this.btnB.TextColor = System.Drawing.Color.Black;
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Visible = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.White;
            this.btnA.BackgroundColor = System.Drawing.Color.White;
            this.btnA.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnA.BorderRadius = 14;
            this.btnA.BorderSize = 0;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.Black;
            this.btnA.Location = new System.Drawing.Point(735, 200);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(367, 82);
            this.btnA.TabIndex = 2;
            this.btnA.TextColor = System.Drawing.Color.Black;
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Visible = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.Color.White;
            this.boton1.BackgroundColor = System.Drawing.Color.White;
            this.boton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.boton1.BorderRadius = 14;
            this.boton1.BorderSize = 0;
            this.boton1.CausesValidation = false;
            this.boton1.Enabled = false;
            this.boton1.FlatAppearance.BorderSize = 0;
            this.boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.ForeColor = System.Drawing.Color.Black;
            this.boton1.Location = new System.Drawing.Point(714, 699);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(416, 77);
            this.boton1.TabIndex = 12;
            this.boton1.TextColor = System.Drawing.Color.Black;
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1148, 819);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnRondas);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.BarraTiempo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boton8);
            this.Controls.Add(this.boton7);
            this.Controls.Add(this.boton6);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.boton1);
            this.Name = "Form1";
            this.Text = "FormTrivia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPregunta;
        private CustomControls.RJControls.Boton btnA;
        private CustomControls.RJControls.Boton btnB;
        private CustomControls.RJControls.Boton btnC;
        private CustomControls.RJControls.Boton btnD;
        private CustomControls.RJControls.Boton boton5;
        private CustomControls.RJControls.Boton boton6;
        private CustomControls.RJControls.Boton boton7;
        private CustomControls.RJControls.Boton boton8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar BarraTiempo;
        private CustomControls.RJControls.Boton boton1;
        private System.Windows.Forms.Label lblPuntos;
        private CustomControls.RJControls.Boton btnRondas;
        private CustomControls.RJControls.Boton btnJugar;
    }
}

