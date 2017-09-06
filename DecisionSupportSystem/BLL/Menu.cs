using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;

namespace BLL
{
    public class Menu
    {
        List<Menu> listaMenu = new List<Menu>();

        #region propiedades
        private string _contenedor;

        public string contenedor
        {
            get { return _contenedor; }
            set { _contenedor = value; }
        }

        private string _objeto;

        public string objeto
        {
            get { return _objeto; }
            set { _objeto = value; }
        }

        private string _objeto_padre;

        public string objeto_padre
        {
            get { return _objeto_padre; }
            set { _objeto_padre = value; }
        }

        private string _objeto_nombre;

        public string objeto_nombre
        {
            get { return _objeto_nombre; }
            set { _objeto_nombre = value; }
        }

        private char _tipo;

        public char tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private string _frm_name;

        public string frm_name
        {
            get { return _frm_name; }
            set { _frm_name = value; }
        }
        #endregion

        #region variables privadas
        SqlConnection conexion;
        string sql;
        string mensaje_error;
        int numero_error;
        DataSet ds;
        #endregion

        #region Metodos
        public DataSet obtieneMenuUsuario()
        {
            conexion = cls_DAL.trae_conexion("INI", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al realizar consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sql = "SELECT OBJ.sg_con_cod_obj_contenedor, " +
                            
                            "OBJ.sg_obj_cod_objeto, " +
                            "OBJ.sg_obj_cod_objeto_padre, " +
                            "OBJ.sg_obj_nom_objeto, " +
                            "OBJ.sg_obj_ind_tipo_objeto, " +
                            "OBJ.sg_nombre_frm " +

                            "FROM seg_usuarios USU " +

                            "INNER JOIN sg_sistemas_x_usuario SXU " +
                            "ON USU.sg_usu_nombre_usuario = SXU.sg_usu_cod_usuario " +

                            "INNER JOIN sg_usuario_x_rol UXR " +
                            "ON SXU.ge_cia_cod_compania = UXR.ge_cia_cod_compania " +
                            "AND SXU.ge_sis_cod_sistema = UXR.ge_sis_cod_sistema " +
                            "AND SXU.sg_usu_cod_usuario = UXR.sg_usu_cod_usuario " +

                            "INNER JOIN sg_accion_rol AR " +
                            "ON UXR.sg_rol_cod_rol = AR.sg_rol_cod_rol " +

                            "INNER JOIN sg_objeto OBJ " +
                            "ON AR.ge_sis_cod_sistema = OBJ.ge_sis_cod_sistema " +
                            "AND AR.sg_con_cod_obj_contenedor = OBJ.sg_con_cod_obj_contenedor " +
                            "AND AR.sg_obj_cod_objeto = OBJ.sg_obj_cod_objeto " +

                            "WHERE USU.sg_usu_nombre_usuario = '"+VG.Variables.usuario_bd+"' " +
                            "AND SXU.ge_sis_cod_sistema = 'TD' " +
                            "AND UXR.sg_rol_ind_estado = 'A' " +
                            "AND AR.sg_acc_ind_estado = 'A' " +

                            "GROUP BY OBJ.sg_obj_num_secuencia, "+
                                    "OBJ.sg_con_cod_obj_contenedor, " +
                                    "OBJ.sg_obj_cod_objeto, " +
                                    "OBJ.sg_obj_cod_objeto_padre, " +
                                    "OBJ.sg_obj_nom_objeto, " +
                                    "OBJ.sg_obj_ind_tipo_objeto, " +
                                    "OBJ.sg_nombre_frm " +

                            "ORDER BY OBJ.sg_obj_num_secuencia, OBJ.sg_obj_cod_objeto_padre";

                    ParamStruct[] parametros = new ParamStruct[0];
                    //cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@usuario", SqlDbType.VarChar, usuario);
                    ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                }
            }
            return ds;
        }

        public Boolean llenarMenu()
        {
            foreach (DataRow row in obtieneMenuUsuario().Tables[0].Rows)
            {
                Menu menu = new Menu();
                menu.contenedor = Convert.ToString(row[0]);
                menu.objeto = Convert.ToString(row[1]);
                menu.objeto_padre = Convert.ToString(row[2]);
                menu.objeto_nombre = Convert.ToString(row[3]);
                menu.tipo = Convert.ToChar(row[4]);
                menu.frm_name = Convert.ToString(row[5]);
                listaMenu.Add(menu);
            }
            if (listaMenu.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public MenuStrip crearMenu()
        {
            MenuStrip menu = new MenuStrip();
            menu.BackColor = System.Drawing.Color.LightSteelBlue;

            if (llenarMenu())
            {
                for (int a = 0; a < listaMenu.Count; a++)
                {
                    if (string.IsNullOrEmpty(listaMenu[a].objeto_padre))
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem(listaMenu[a].objeto_nombre);
                        for (int b = 0; b < listaMenu.Count; b++)
                        {
                            if (listaMenu[b].objeto_padre.Equals(listaMenu[a].objeto))
                            {
                                ToolStripMenuItem subitem;
                                switch (listaMenu[b].tipo)
                                {
                                    case 'M':
                                        subitem = new ToolStripMenuItem(listaMenu[b].objeto_nombre);
                                        item.DropDownItems.Add(subitem);
                                        break;
                                    case 'A':
                                        string path = Environment.GetEnvironmentVariable("USERPROFILE");
                                        path += @"\Source\DSS\DecisionSupportSystem\DecisionSupportSystem\Images\Menu\cliente_32_32.png";
                                        subitem = new ToolStripMenuItem(listaMenu[b].objeto_nombre, System.Drawing.Image.FromFile(path), new EventHandler(accionMenu));
                                        //subitem = new ToolStripMenuItem(listaMenu[b].objeto_nombre, System.Drawing.Image.FromFile(@"C:\Users\jason\Source\Repos\DSS\DecisionSupportSystem\DecisionSupportSystem\Images\Menu\cliente_32_32.png"), new EventHandler(accionMenu));
                                        item.DropDownItems.Add(subitem);
                                        break;
                                }
                            }
                        }
                        menu.Items.Add(item);
                    }
                }
            }
            return menu;
        }

        private void accionMenu(object sender, EventArgs e)
        {
            if (sender.ToString().ToLower().Equals("salir"))
            {
                Application.Exit();
            }
                Assembly frmAssembly = Assembly.LoadFile(Application.ExecutablePath);
                foreach (Type type in frmAssembly.GetTypes())
                {
                    if (type.BaseType == typeof(Form))
                    {
                        string frm_name = string.Empty;
                        for (int a = 0; a < listaMenu.Count; a++)
                        {
                            if (listaMenu[a].objeto_nombre.Equals(sender.ToString()))
                            {
                                frm_name = listaMenu[a]._frm_name;
                            }
                        }
                            if (type.Name == frm_name)
                            {
                            Form frmShow = (Form)frmAssembly.CreateInstance(type.ToString());
                            //frmShow.WindowState = FormWindowState.Maximized;

                        foreach (Form form in VG.Variables.mdiForm.MdiChildren)
                            {
                                form.Close();
                            }

                            frmShow.MdiParent = VG.Variables.mdiForm;
                            frmShow.StartPosition = FormStartPosition.CenterScreen;
                            frmShow.MinimizeBox = false;
                            frmShow.MaximizeBox = false;
                            //frmShow.Dock = DockStyle.Fill;
                            frmShow.Show();
                            }
                        }
                }
            
        }

        #endregion

        #region Constructor
        public Menu()
        {
            contenedor = string.Empty;
            objeto = string.Empty;
            objeto_padre = string.Empty;
            objeto_nombre = string.Empty;
            tipo = Convert.ToChar(0);
            frm_name = string.Empty;
        }
        #endregion

    }
}
