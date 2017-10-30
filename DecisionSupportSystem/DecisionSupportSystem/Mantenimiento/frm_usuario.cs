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
        Fecha objFecha = new Fecha();
        string[] datos_origen = new string[] { };
        string[] datos_nuevos = new string[] { };

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
                    axSupport_usuario.encrypted = info_encrypt;
                    axSupport_usuario.passkey = cmb_usuario.SelectedValue.ToString().Trim();
                    int resultado = axSupport_usuario.Unencrypt();
                    if (resultado > 0)
                    {
                        string desencriptado = axSupport_usuario.unencrypted;
                        datos_origen = desencriptado.Split(';');

                        txt_nombre.ReadOnly = true;
                        txt_nombre.Text = objLogin.obtieneNombreUsuario(cmb_usuario.SelectedValue.ToString());
                        txt_usuario.ReadOnly = true;
                        txt_usuario.Text = datos_origen[1];
                        txt_clave_nueva.Text = datos_origen[0];
                        txt_valida_clave.Text = datos_origen[0];
                        dtp_fecha.Text = datos_origen[3];

                        if (datos_origen[5].Equals("S")){ chk_inactivo.Checked = true; } else { chk_inactivo.Checked = false; }
                        if (datos_origen[6].Equals("S")) { chk_auditoria.Checked = true; } else { chk_auditoria.Checked = false; }
                        if (datos_origen[7].Equals("S")) { chk_supervisor.Checked = true; } else { chk_supervisor.Checked = false; }
                        if (datos_origen[8].Equals("S")) { chk_conexiones.Checked = true; } else { chk_conexiones.Checked = false; }
                        if (datos_origen[9].Equals("S")) { chk_cambiar_clave.Checked = true; } else { chk_cambiar_clave.Checked = false; }

                        nup_dias.Value = Convert.ToDecimal(datos_origen[4]);
                    }
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string encriptado = string.Empty;


            if (string.IsNullOrEmpty(txt_nombre.Text)) {
                MessageBox.Show("Debe digitar el nombre del usuario.", "Validación del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_usuario.Text))
            {
                MessageBox.Show("Debe digitar el código de usuario.", "Validación del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_usuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_clave_nueva.Text))
            {
                MessageBox.Show("Debe digitar una clave.", "Validación del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_clave_nueva.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_valida_clave.Text))
            {
                MessageBox.Show("Debe repetir la clave para verificar.", "Validación del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_valida_clave.Focus();
                return;
            }

            if (txt_clave_nueva.Text != txt_valida_clave.Text)
            {
                MessageBox.Show("Las claves son diferentes.", "Validación del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_valida_clave.Clear();
                txt_clave_nueva.Focus();
                return;
            }

            string unir_datos = txt_clave_nueva.Text + ";";
            unir_datos += txt_usuario.Text + ";";
            unir_datos += txt_usuario.Text + "123;";
            unir_datos += objFecha.obtieneProximaFecha(nup_dias.Value.ToString()).ToString("dd/MM/yyyy") + ";";
            unir_datos += nup_dias.Value.ToString() + ";";
            if (chk_inactivo.Checked) { unir_datos += "S;"; } else { unir_datos += "N;"; }
            if (chk_auditoria.Checked) { unir_datos += "S;"; } else { unir_datos += "N;"; }
            if (chk_supervisor.Checked) { unir_datos += "S;"; } else { unir_datos += "N;"; }
            if (chk_conexiones.Checked) { unir_datos += "S;"; } else { unir_datos += "N;"; }
            if (chk_cambiar_clave.Checked) { unir_datos += "S;"; } else { unir_datos += "N;"; }

            datos_nuevos = unir_datos.Split(';');
            
            axSupport_usuario.unencrypted = unir_datos;
            axSupport_usuario.passkey = txt_usuario.Text;
            int resultado = axSupport_usuario.Encrypt();

            if (resultado > 0)
            {
                encriptado = axSupport_usuario.encrypted;
            }

            if (cmb_usuario.SelectedValue.ToString().Equals("NEW"))
            {
                if(objLogin.manejoUsuario("N", txt_usuario.Text, txt_nombre.Text, (txt_usuario.Text + "123"), encriptado, VG.Variables.codigoCompania, VG.Variables.codigoAplicacion))
                {
                    tipoUsuario("N");
                    inicio();
                    axSupport_usuario.Dispose();
                    MessageBox.Show("Usuario agregado correctamente.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (datos_origen[0].Equals(datos_nuevos[0]))
                {
                    datos_nuevos[3] = datos_origen[3];
                    unir_datos = string.Empty;

                    for (int i = 0; i < datos_nuevos.Count(); i++)
                    {
                        unir_datos += datos_nuevos[i] + ";";
                    }

                    axSupport_usuario.unencrypted = unir_datos;
                    axSupport_usuario.passkey = txt_usuario.Text;
                    resultado = axSupport_usuario.Encrypt();
                    if (resultado > 0)
                    {
                        encriptado = axSupport_usuario.encrypted;

                        if (objLogin.manejoUsuario("U", txt_usuario.Text, txt_nombre.Text, datos_nuevos[0], encriptado, VG.Variables.codigoCompania, VG.Variables.codigoAplicacion))
                        {
                            tipoUsuario("N");
                            inicio();
                            axSupport_usuario.Dispose();
                            MessageBox.Show("Usuario modificado correctamente.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }
    }
}
