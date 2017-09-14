using BLL;
using System;
using System.Data;
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
            tv_rol.Nodes.Clear();
            objRol.dibujaRol(cmb_roles.SelectedValue.ToString(), tv_rol);
        }

        private void txt_cod_rol_Leave(object sender, EventArgs e)
        {
            txt_cod_rol.Text = txt_cod_rol.Text.ToUpper().Replace(" ", "_");
        }

        private void tv_rol_AfterCheck(object sender, TreeViewEventArgs e)
        {
            tv_rol.AfterCheck -= tv_rol_AfterCheck;
            if (e.Node.Parent == null)
            {
                replicarHijos(e.Node, e.Node.Checked);
            }
            else
            {
                marcarPadre(e.Node.Parent, e.Node.Checked);
            }
            tv_rol.AfterCheck += tv_rol_AfterCheck;
        }

        private void replicarHijos(TreeNode treeNode, bool check)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                tn.Checked = check;
                replicarHijos(tn, check);
            }
        }

        private void marcarPadre(TreeNode treeNode, bool check)
        {
            if(treeNode.Parent != null)
            {
                treeNode.Checked = check;
                marcarPadre(treeNode.Parent, check);
            }
            else
            {
                treeNode.Checked = check;
            }
        }
    }
}
