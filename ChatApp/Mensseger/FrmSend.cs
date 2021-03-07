using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensseger
{
    public partial class FrmSend : MaterialForm
    {
        public FrmSend()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            textContent.Text += $"\n{txtsend.Text} || {date.ToShortDateString()}";
            txtsend.Text = "";
        }
    }
}
