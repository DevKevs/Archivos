using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(tsearch.Text);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void adelante_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("www.google.com");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Helper help = new Helper();
            help.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("www.google.com");
        }
    }
}
