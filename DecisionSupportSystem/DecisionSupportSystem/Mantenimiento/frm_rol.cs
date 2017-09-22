using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DecisionSupportSystem.Mantenimiento
{
    public partial class frm_rol : Form
    {
        Funcional objFuncional = new Funcional();
        Rol objRol = new Rol();
        string tipo_ingreso = string.Empty;

        public frm_rol()
        {
            InitializeComponent();
        }

        private void frm_rol_Load(object sender, EventArgs e)
        {
            inicio();
        }

        private void inicio()
        {
            cmb_roles.SelectedValueChanged -= cmb_roles_SelectedValueChanged;
            objFuncional.cargarRoles(cmb_roles, null);
            tipo_ingreso = "I";
            txt_cod_rol.Text = string.Empty;
            txt_nom_rol.Text = string.Empty;
            cmb_roles.SelectedValueChanged += cmb_roles_SelectedValueChanged;

            habilitaCampos(cmb_roles.SelectedValue.ToString());

            tv_rol.Nodes.Clear();
            objRol.dibujaRol(cmb_roles.SelectedValue.ToString(), tv_rol);
        }

        private void habilitaCampos(string rol)
        {
            if (rol.Equals("NEW"))
            {
                txt_cod_rol.Enabled = true;
            }
            else
            {
                txt_cod_rol.Enabled = false;
            }
        }

        private void cmb_roles_SelectedValueChanged(object sender, EventArgs e)
        {
            string cod_rol = cmb_roles.SelectedValue.ToString();
            habilitaCampos(cod_rol);
            if (cod_rol.Equals("NEW"))
            {
                txt_cod_rol.Text = string.Empty;
                txt_nom_rol.Text = string.Empty;
                tipo_ingreso = "I";
            }
            else
            {
                DataSet ds = objRol.obtenerRol('I', cmb_roles.SelectedValue.ToString());
                txt_cod_rol.Text = ds.Tables[0].Rows[0][0].ToString();
                txt_nom_rol.Text = ds.Tables[0].Rows[0][1].ToString();
                tipo_ingreso = "U";
            }
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
                replicarPadre(e.Node.Parent, e.Node.Checked);
                replicarHijos(e.Node, e.Node.Checked);
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

        private void replicarPadre(TreeNode treeNode, bool check)
        {
            if(treeNode.Parent != null)
            {
                if (check)
                {
                    treeNode.Checked = check;
                    replicarPadre(treeNode.Parent, check);
                }
                else
                {
                    if(treeNode.Nodes.Count > 1)
                    {
                        int contador = 0;
                        for (int a = 0; a < treeNode.Nodes.Count; a++)
                        {
                            if (treeNode.Nodes[a].Checked)
                            {
                                contador++;
                            }
                        }
                        if(contador > 0)
                        {
                            treeNode.Checked = check;
                            replicarPadre(treeNode.Parent, check);
                        }
                    }
                    else
                    {
                        treeNode.Checked = check;
                        replicarPadre(treeNode.Parent, check);
                    }
                }
            }
            else
            {
                if (check)
                {
                    treeNode.Checked = check;
                }
                else
                {
                    if (treeNode.Nodes.Count > 1)
                    {
                        int contador = 0;
                        for (int a = 0; a < treeNode.Nodes.Count; a++)
                        {
                            if (treeNode.Nodes[a].Checked)
                            {
                                contador++;
                            }
                        }
                        if (contador == 0)
                        {
                            treeNode.Checked = check;
                        }
                    }
                    else
                    {
                        treeNode.Checked = check;
                    }
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cod_rol.Text))
            {
                MessageBox.Show("Debe digitar un código para identificar el rol.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txt_nom_rol.Text))
            {
                MessageBox.Show("Debe digitar una descripción para dicho rol.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Rol> opciones = new List<Rol>();
            opciones = objRol.recorerArbol(tv_rol, opciones);
            if (objRol.verificaChequeados(opciones) <= 0)
            {
                MessageBox.Show("No hay opciones seleccionadas.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (objRol.manejarRol(tipo_ingreso, txt_cod_rol.Text, txt_nom_rol.Text, opciones))
            {
                MessageBox.Show("Rol agregado correctamente.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                inicio();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al agregar el perfil.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tv_rol_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
             if (e.Node.Tag.ToString().Equals("S")) e.Cancel = true;
        }
    }
}
