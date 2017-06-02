using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace DecisionSupportSystem
{
    public partial class frm_login : Form
    {
        Login objLogin = new Login();

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_sesion.Text))
            {
                MessageBox.Show("Debe digitar un usuario en el inicio de sesión.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sesion.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Debe digitar una contraseña", "Validación del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_password.Focus();
                return;
            }

            if (objLogin.usuarioExiste(txt_sesion.Text))
            {
                frm_main ventana = new frm_main();
                ventana.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("El usuario no se encuentra registrado en la base de datos.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
