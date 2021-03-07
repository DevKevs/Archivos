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
    public partial class FrmMain : MaterialForm
    {
        private static FrmMain _instance;
        public static FrmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmMain();
                return _instance;
            }
            
        }
    public FrmMain()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        public Panel Content
        {
            get { return MainContainer; }
            set { MainContainer = value; }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _instance = this;
            MainContainer.Controls.Add(new Login() { Dock = DockStyle.Fill});
        }
    }
}
