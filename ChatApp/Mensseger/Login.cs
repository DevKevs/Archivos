using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensseger
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnSing_Click(object sender, EventArgs e)
        {
            FrmMain.Instance.Content.Controls.Add(new UserMain() {Dock = DockStyle.Fill });
            FrmMain.Instance.Content.Controls[0].SendToBack();
        }
    }
}
