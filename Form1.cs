using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls.RJControls;
using Hangfire;
namespace Proyecto
{
    public partial class Form1 : Form
    {
    
        int categoria;
       
        List<string> rutasDeImagenes = new List<string>
        {
            //@"C:\Users\Isaac\Pictures\Saved Pictures\goofy\1.png",
            // @"C:\Users\Isaac\Pictures\Saved Pictures\goofy\2.png",
              @"C:\Users\Isaac\Pictures\Saved Pictures\goofy\3.gif",
               //@"C:\Users\Isaac\Pictures\Saved Pictures\goofy\4.png",
               // @"C:\Users\Isaac\Pictures\Saved Pictures\goofy\5.jpg",
               // @"C:\Users\Isaac\Pictures\Saved Pictures\goofy\6.png",
        };
        Random random = new Random();
        ClsTrivia objTrivia;
        int aux = 0;
        int? ronda = null;
        int puntuacion = 0;
        public Form1()
        {
            InitializeComponent();
        }
   

        private void imprimir(string cadena)
        {
            if (aux == 5)
            {
                aux = 0;
            }
            switch (aux)
            {
                case 0:lblPregunta.Text = cadena;   break;
                case 1: btnA.Text = cadena; break;
                case 2: btnB.Text = cadena; break;
                case 3: btnC.Text = cadena; break;
                case 4: btnD.Text = cadena; break;
                
            }
            aux++;
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BarraTiempo.Value > BarraTiempo.Minimum)
            {
                BarraTiempo.Value--;
            }
        }

    
        private void btnA_Click(object sender, EventArgs e)
        {

            objTrivia.respSeleccionada = 0;
        }
        private void btnB_Click(object sender, EventArgs e)
        {

            objTrivia.respSeleccionada = 1;
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            objTrivia.respSeleccionada = 2;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            objTrivia.respSeleccionada = 3;
        }

     

        private async void btnJugar_Click(object sender, EventArgs e)
        {
            //Celebridades:26    Musica:12   General:9   Peliculas:10
            pictureBox1.Visible = true;
            lblPregunta.Visible = true;
            lblPuntos.Visible = true;
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
            boton5.Visible = true;
            boton6.Visible = true;
            boton7.Visible = true;
            boton8.Visible = true;
            btnJugar.Visible = false;
            btnJugar.Enabled= false;
            boton1.Visible = true;
            btnRondas.Visible = true;
            btnA.SendToBack();
            btnB.SendToBack();
            btnC.SendToBack();
            btnD.SendToBack();
            objTrivia = new ClsTrivia(12, "easy", BarraTiempo);
            BarraTiempo.Visible= true;
            timer1.Start();
             objTrivia.delPrint = imprimir;
            for (int i = 1; i < 11; i++)
            {
                pictureBox1.Image = Image.FromFile(rutasDeImagenes[random.Next(rutasDeImagenes.Count)]);
                ronda = i;
                btnRondas.Text = ronda.ToString();
                await objTrivia.JugarRonda();

                while (objTrivia.respSeleccionada == null)
                {
                    await Task.Delay(100);
                }

                objTrivia.respSeleccionada = null;
                if (objTrivia.acerto == true)
                {
                    MessageBox.Show("CORRECTO!!");
                    puntuacion++;
                }
                else
                {
                    MessageBox.Show("INCORRECTO!!");
                }
                BarraTiempo.Value = BarraTiempo.Maximum;
                lblPuntos.Text = "Puntuación: " + puntuacion;
                await Task.Delay(1000);

            }


          

            //DialogResult dialogResult = MessageBox.Show("Si", "Quieres G??", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    Puntuaciones frmPuntos = new Puntuaciones(objTrivia,puntuacion);
            //    frmPuntos.Show();
            //}
            //else if (dialogResult == DialogResult.No)
            //{
                
            //}
            timer1.Stop();

        }

     
    }
}
