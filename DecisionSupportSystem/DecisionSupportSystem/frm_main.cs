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

        /*public void windowOpen() {
            int theHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            int theWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;

            this.Height = theHeight;
            this.Width = theWidth;

            this.Top = 0;
            this.Left = 0;
        }*/

        private void frm_main_Load(object sender, EventArgs e)
        {
            VG.Variables.mdiForm = this;
            this.MinimumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height);
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height);
            MenuStrip menu = objMenu.crearMenu(il_menu);
            this.Controls.Add(menu);
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
