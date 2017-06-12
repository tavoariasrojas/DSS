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
using AxSUPPORT1Lib;

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
                string info_encrypt = objLogin.obtieneInfoEncriptada(txt_sesion.Text);

                if (String.IsNullOrEmpty(txt_password.Text))
                {
                    MessageBox.Show("No se pudo obtener información del usuario.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    axSupport11.encrypted = info_encrypt;
                    axSupport11.passkey = txt_sesion.Text;
                    int resultado = axSupport11.Unencrypt();
                    if (resultado > 0)
                    {
                        string desencriptado = axSupport11.unencrypted;
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
                                MessageBox.Show("El usuario debe cambiar la contraseña.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            default:
                                frm_main ventana = new frm_main();
                                ventana.Show();
                                this.Visible = false;
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
    }
}
