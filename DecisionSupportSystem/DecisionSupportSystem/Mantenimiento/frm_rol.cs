using BLL;
using System;
using System.Windows.Forms;

namespace DecisionSupportSystem.Mantenimiento
{
    public partial class frm_rol : Form
    {
        Funcional objFuncional = new Funcional();
        Rol objRol = new Rol();

        public frm_rol()
        {
            InitializeComponent();
        }

        private void frm_rol_Load(object sender, EventArgs e)
        {
            objFuncional.cargarRoles(cmb_roles, null);
            if (cmb_roles.SelectedValue.ToString().Equals("NEW"))
            {
                txt_cod_rol.Enabled = true;
                txt_nom_rol.Enabled = true;
            }
            else
            {
                txt_cod_rol.Enabled = false;
                txt_nom_rol.Enabled = false;
            }
            tv_rol.Nodes.Clear();
            objRol.dibujaRol(cmb_roles.SelectedValue.ToString(), tv_rol);
        }

        private void cmb_roles_SelectedValueChanged(object sender, EventArgs e)
        {
            /*ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex > 0)
            {*/
                tv_rol.Nodes.Clear();
                objRol.dibujaRol(cmb_roles.SelectedValue.ToString(), tv_rol);
            //}
        }

        private void txt_cod_rol_TextChanged(object sender, EventArgs e)
        {
            txt_cod_rol.Text =  txt_cod_rol.Text.ToUpper().Replace(" ", "_");
        }
    }
}
