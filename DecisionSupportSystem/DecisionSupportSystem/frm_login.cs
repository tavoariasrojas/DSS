using System;
using System.Windows.Forms;
using BLL;

namespace DecisionSupportSystem
{
    public partial class frm_login : Form
    {
        Login objLogin = new Login();
        Funcional objFuncional = new Funcional();

        public frm_login()
        {
            InitializeComponent();
        }

        private void ingresarSistema()
        {
            if (String.IsNullOrEmpty(txt_sesion.Text))
            {
                MessageBox.Show("Debe digitar un usuario en el inicio de sesión.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sesion.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Debe digitar una contraseña.", "Validación del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_password.Focus();
                return;
            }

            if (cmb_compania.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una compañía.", "Validación del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_compania.Focus();
                return;
            }

            if (objLogin.usuarioExiste(txt_sesion.Text))
            {
                string info_encrypt = objLogin.obtieneInfoEncriptada(txt_sesion.Text);

                if (String.IsNullOrEmpty(info_encrypt))
                {
                    MessageBox.Show("No se pudo obtener información del usuario.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    axSupport_login.encrypted = info_encrypt;
                    axSupport_login.passkey = txt_sesion.Text;
                    int resultado = axSupport_login.Unencrypt();
                    if (resultado > 0)
                    {
                        string desencriptado = axSupport_login.unencrypted;
                        objLogin.descomponeInfoEncriptada(desencriptado);

                        int valor = objLogin.verificaDatos(txt_password.Text);
                        switch (valor)
                        {
                            case 1:
                                MessageBox.Show("La clave digitada no corresponde al usuario.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case 2:
                                MessageBox.Show("El usuario se encuentra deshabilitado.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case 3:
                                MessageBox.Show("La clave a llegado a su fecha de vencimiento, debe cambiarla.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case 4:
                                MessageBox.Show("El usuario debe cambiar la contraseña.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            default:
                                frm_main ventana = new frm_main();
                                ventana.Show();
                                this.Visible = false;
                                axSupport_login.Dispose();
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El usuario no se encuentra registrado en la base de datos.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            ingresarSistema();
        }

        private void txt_sesion_Leave(object sender, EventArgs e)
        {
            objFuncional.cargarCompania(cmb_compania, txt_sesion.Text, "min");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_sesion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ingresarSistema();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ingresarSistema();
            }
        }

        private void cmb_compania_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ingresarSistema();
            }
        }
    }
}
