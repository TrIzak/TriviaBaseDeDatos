using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hangfire;

namespace Proyecto
{
    public partial class Puntuaciones : Form
    {
        private ClsTrivia objTrivia;
        private int puntuacion;

        public Puntuaciones(ClsTrivia objTrivia,int puntuacion)
        {
            InitializeComponent();
            this.objTrivia = objTrivia;
        }

        private void Puntuaciones_Load(object sender, EventArgs e)
        {

        }

        private async  void btnGuardar_Click(object sender, EventArgs e)
        {
            BackgroundJob.Enqueue(() => objTrivia.RegsitrarPuntuacion(Convert.ToInt32(textBox1.Text), puntuacion));
            BackgroundJob.Enqueue(() => objTrivia.ActualizarRanking(dataGridView1));
            dataGridView1.Visible = true;
            btnGuardar.Visible = false;
            textBox1.Visible=false;
        }
    }
}
