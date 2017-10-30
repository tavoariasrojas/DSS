using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DecisionSupportSystem.Mantenimiento
{
    public partial class frm_mant_roles : Form
    {
        Funcional objFuncional = new Funcional();
        Rol objRol = new Rol();

        public frm_mant_roles()
        {
            InitializeComponent();
        }

        private void frm_mant_roles_Load(object sender, EventArgs e)
        {
            inicio();
        }

        private void inicio()
        {
            cmb_usuarios.SelectedValueChanged -= cmb_usuarios_SelectedValueChanged;
            objFuncional.cargarUsuarios(1, cmb_usuarios, null);
            cmb_usuarios.SelectedValueChanged += cmb_usuarios_SelectedValueChanged;

            cargarListView(lv_rol_asignado);
            cargarListView(lv_rol_disponible);

            agregarToolTip(btn_d_right, "Agregar todos");
            agregarToolTip(btn_right, "Agregar seleccionados");
            agregarToolTip(btn_left, "Quitar seleccionados");
            agregarToolTip(btn_d_left, "Quitar todos");

        }

        private void agregarToolTip(Button btn, string mensaje)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btn, mensaje);
        }

        private void cargarListView(ListView lista)
        {
            lista.Clear();
            lista.View = View.Details;
            lista.GridLines = true;
            lista.FullRowSelect = true;
            lista.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            //Agregar encabezado de columnas
            lista.Columns.Add("Código del rol", 130);
            lista.Columns.Add("Descripción del rol", 335);
        }

        private void llenarListView(ListView lista, string accion, string usuario)
        {
            lista.Clear();
            cargarListView(lista);
            DataSet ds = objRol.obtenerRoles(lista, accion, usuario);

            DataTable dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem itm = new ListViewItem(new string[] { row[0].ToString(), row[1].ToString() });
                lista.Items.Add(itm);
            }
        }

        private void cmb_usuarios_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_usuarios.SelectedValue.ToString().Equals("-"))
            {
                cargarListView(lv_rol_asignado);
                cargarListView(lv_rol_disponible);
            }
            else
            {
                llenarListView(lv_rol_disponible, "D", cmb_usuarios.SelectedValue.ToString());
                llenarListView(lv_rol_asignado, "A", cmb_usuarios.SelectedValue.ToString());
            }
        }

        private void btn_d_right_Click(object sender, EventArgs e)
        {
            for (int i = lv_rol_disponible.Items.Count - 1; i >= 0 ; i--)
            {
                lv_rol_asignado.Items.Add(new ListViewItem(new string[] { lv_rol_disponible.Items[i].SubItems[0].Text, lv_rol_disponible.Items[i].SubItems[1].Text }));
                lv_rol_disponible.Items.RemoveAt(i);
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            for (int i = lv_rol_disponible.Items.Count - 1; i >= 0; i--)
            {
                if (lv_rol_disponible.Items[i].Selected)
                {
                    lv_rol_asignado.Items.Add(new ListViewItem(new string[] { lv_rol_disponible.Items[i].SubItems[0].Text, lv_rol_disponible.Items[i].SubItems[1].Text }));
                    lv_rol_disponible.Items.RemoveAt(i);
                }
            }
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            for (int i = lv_rol_asignado.Items.Count - 1; i >= 0; i--)
            {
                if (lv_rol_asignado.Items[i].Selected)
                {
                    lv_rol_disponible.Items.Add(new ListViewItem(new string[] { lv_rol_asignado.Items[i].SubItems[0].Text, lv_rol_asignado.Items[i].SubItems[1].Text }));
                    lv_rol_asignado.Items.RemoveAt(i);
                }
            }
        }

        private void btn_d_left_Click(object sender, EventArgs e)
        {
            for (int i = lv_rol_asignado.Items.Count - 1; i >= 0; i--)
            {
                lv_rol_disponible.Items.Add(new ListViewItem(new string[] { lv_rol_asignado.Items[i].SubItems[0].Text, lv_rol_asignado.Items[i].SubItems[1].Text }));
                lv_rol_asignado.Items.RemoveAt(i);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            List<string[]> lista = new List<string[]>();

            for (int i = 0; i < lv_rol_disponible.Items.Count; i++)
            {
                lista.Add( new string[] { lv_rol_disponible.Items[i].Text, "D" } );
            }

            for (int i = 0; i < lv_rol_asignado.Items.Count; i++)
            {
                lista.Add(new string[] {  lv_rol_asignado.Items[i].Text, "U"  });
            }

            if(lista.Count > 0)
            {
                if(objRol.asignarRolUsuario(lista, cmb_usuarios.SelectedValue.ToString()))
                {
                    MessageBox.Show("Proceso finalizado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede ejecutar el proceso", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
