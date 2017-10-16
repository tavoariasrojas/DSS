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
            this.tssl_usuario.Text = tssl_usuario + " " + VG.Variables.usuario_bd;
            this.tssl_servidor.Text = tssl_servidor + " " + VG.Variables.serverIpAddressDSS;
            this.tssl_database.Text = tssl_database + " " + VG.Variables.serverDataBaseDSS;
            t_main.Start();
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void t_main_Tick(object sender, EventArgs e)
        {
            
            this.tssl_fecha.Text = "Fecha y hora actual: " + System.DateTime.Now.ToString();
        }
    }
}
