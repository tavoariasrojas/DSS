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

namespace DecisionSupportSystem.Mantenimiento
{
    public partial class frm_usuario : Form
    {
        Funcional objFuncional = new Funcional();
        Login objLogin = new Login();

        public frm_usuario()
        {
            InitializeComponent();
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            inicio();
        }

        private void inicio()
        {
            cmb_usuario.SelectedValueChanged -= cmb_usuario_SelectedValueChanged;
            objFuncional.cargarUsuarios(2, cmb_usuario, null);
            cmb_usuario.SelectedValueChanged += cmb_usuario_SelectedValueChanged;

        }
        private void tipoUsuario(string tipo) {
            if (tipo.Equals("N")){
                txt_nombre.ReadOnly = false;
                txt_nombre.Clear();
                txt_usuario.ReadOnly = false;
                txt_usuario.Clear();
                txt_clave_nueva.Clear();
                txt_valida_clave.Clear();

                dtp_fecha.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
                chk_inactivo.CheckState = CheckState.Unchecked;
                chk_auditoria.CheckState = CheckState.Unchecked;
                chk_supervisor.CheckState = CheckState.Unchecked;
                chk_conexiones.CheckState = CheckState.Unchecked;
                chk_cambiar_clave.CheckState = CheckState.Unchecked;

                nup_dias.Value = 30;
            }
        }

        private void cmb_usuario_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_usuario.SelectedValue.ToString().Equals("NEW"))
            {
                tipoUsuario("N");
            }
            else
            {
                string info_encrypt = objLogin.obtieneInfoEncriptada(cmb_usuario.SelectedValue.ToString().Trim());
                if (String.IsNullOrEmpty(info_encrypt))
                {
                    MessageBox.Show("No se pudo obtener información del usuario.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    axSupport11.encrypted = info_encrypt;
                    axSupport11.passkey = cmb_usuario.SelectedValue.ToString().Trim();
                    int resultado = axSupport11.Unencrypt();
                    if (resultado > 0)
                    {
                        string desencriptado = axSupport11.unencrypted;
                        string[] datos = desencriptado.Split(';');

                        txt_nombre.ReadOnly = true;
                        txt_nombre.Text = objLogin.obtieneNombreUsuario(cmb_usuario.SelectedValue.ToString().Trim().Trim());
                        txt_usuario.ReadOnly = true;
                        txt_usuario.Text = datos[1];
                        txt_clave_nueva.Text = datos[0];
                        txt_valida_clave.Text = datos[0];
                        dtp_fecha.Text = datos[3];

                        if (datos[5].Equals("S")){ chk_inactivo.Checked = true; } else { chk_inactivo.Checked = false; }
                        if (datos[6].Equals("S")) { chk_auditoria.Checked = true; } else { chk_auditoria.Checked = false; }
                        if (datos[7].Equals("S")) { chk_supervisor.Checked = true; } else { chk_supervisor.Checked = false; }
                        if (datos[8].Equals("S")) { chk_conexiones.Checked = true; } else { chk_conexiones.Checked = false; }
                        if (datos[9].Equals("S")) { chk_cambiar_clave.Checked = true; } else { chk_cambiar_clave.Checked = false; }

                        nup_dias.Value = Convert.ToDecimal(datos[4]);
                    }
                }
            }
        }
    }
}
