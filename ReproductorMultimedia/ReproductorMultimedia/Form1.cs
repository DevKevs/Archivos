using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorMultimedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.FileName = "archivo nuevo";
            abrir.Filter = "archivo mp3|*.mp3|archivo mp4|*.mp4|archivo avi|*.avi";
            abrir.FilterIndex = 1;
            if(abrir.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = (abrir.FileName);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kevin Feliz | Matricula: 2019-8682 | Instagram: @Kevs_kun");
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

     

        private void controlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El boton de pausa, boton de las dos barras sirve para detener el contenido reproducido en pantalla, el boton de play o iniciar que es el boton con un triangulo, sirve para reanudar la pausa luego de ser accionada y finalmente el boton de stop o detener cuyo simbolo es un cuadrado sirve para detener toda la reproduccion.");
        }
    }
}
