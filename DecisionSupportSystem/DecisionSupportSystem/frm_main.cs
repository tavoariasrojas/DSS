using System;
using System.Windows.Forms;

namespace DecisionSupportSystem
{
    public partial class frm_main : Form
    {
        BLL.Menu objMenu = new BLL.Menu();
        public frm_main()
        {
            InitializeComponent();
        }

        public void windowOpen() {
            int theHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            int theWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;

            this.Height = theHeight;
            this.Width = theWidth;

            this.Top = 0;
            this.Left = 0;
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            VG.Variables.mdiForm = this; 
            MenuStrip menu = objMenu.crearMenu();
            this.Controls.Add(menu);
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
