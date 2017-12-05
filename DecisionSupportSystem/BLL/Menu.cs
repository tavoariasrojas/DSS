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
        #region propiedades
        /// <summary>
        /// Parámetros de la clase Menu
        /// </summary>
        /// <param name="contenedor">Nombre del contenedor</param>
        /// <param name="objeto">Nombre del objeto</param>
        /// <param name="objeto_padre">Nombre del objeto padre</param>
        /// <param name="objeto_nombre">Nombre del objeto</param>
        /// <param name="tipo">Tipo de objeto</param>
        /// <param name="frm_name">Nombre del form asociado</param>
        /// <param name="imagen">Numero de imagen</param>
        /// <param name="imagen_menu">Imagen list</param>
        ///
        List<Menu> listaMenu = new List<Menu>();

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

        private int _imagen;

        public int imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }

        private ImageList _imagen_menu;

        public ImageList imagen_menu
        {
            get { return _imagen_menu; }
            set { _imagen_menu = value; }
        }

        #endregion

        #region variables privadas
        /// <summary>
        /// Variables privadas de clase Menu
        /// </summary>
        /// <param name="conexion">Conexión de base de datos/param>
        /// <param name="mensaje_error">Mensaje de error</param>
        /// <param name="numero_error">Número de error</param>
        /// <param name="ds">DataSet</param>
        ///
        SqlConnection conexion;
        string mensaje_error;
        int numero_error;
        DataSet ds;
        #endregion

        #region Metodos
        /// <summary>
        /// Método para obtener el menú del usuario
        /// </summary>
        ///
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
                    ParamStruct[] parametros = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod_sistema", SqlDbType.VarChar, VG.Variables.codigoAplicacion);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@cod_usuario", SqlDbType.VarChar, VG.Variables.usuario_bd);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_obtiene_opciones_usuario", true, parametros, ref mensaje_error, ref numero_error);
                }
            }
            return ds;
        }
        /// <summary>
        /// Método para llenar el menu
        /// </summary>
        ///
        private Boolean llenarMenu()
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
                menu.imagen = Convert.ToInt32(row[6]);
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
        /// <summary>
        /// Método para crear menu
        /// </summary>
        /// <param name="img">Lista de imagenes del menu</param>
        ///
        public MenuStrip crearMenu(ImageList img)
        {
            MenuStrip menu = new MenuStrip();
            menu.BackColor = System.Drawing.Color.LightSteelBlue;
            imagen_menu = img;

            if (llenarMenu())
            {
                for (int a = 0; a < listaMenu.Count; a++)
                {
                    if (string.IsNullOrEmpty(listaMenu[a].objeto_padre)){
                        menu.Items.Add(agregarPadre(a));
                    }
                }
            }
            return menu;
        }
        /// <summary>
        /// Método para agregar opciones padres del menu
        /// </summary>
        /// <param name="posicion">Número de posición</param>
        ///
        private ToolStripMenuItem agregarPadre(int posicion){
            ToolStripMenuItem item = new ToolStripMenuItem(listaMenu[posicion].objeto_nombre);
            agregarHijo(listaMenu[posicion].tipo, listaMenu[posicion].objeto, item);
            return item;
        }
        /// <summary>
        /// Método para agregar hijos a las opciones padres
        /// </summary>
        /// <param name="tipo">Tipo</param>
        /// <param name="obj_padre">Objeto padre</param>
        /// /// <param name="item">Nombre del Tool Strip Menu</param>
        ///
        private void agregarHijo(char tipo, string obj_padre, ToolStripMenuItem item)
        {
            ToolStripMenuItem subitem;

            for (int a = 0; a < listaMenu.Count; a++)
            {
                if (listaMenu[a].objeto_padre.Equals(obj_padre))
                {
                    if (listaMenu[a].tipo.Equals('M')) {
                        subitem = new ToolStripMenuItem(listaMenu[a].objeto_nombre);
                        agregarHijo(listaMenu[a].tipo, listaMenu[a].objeto, subitem);
                        item.DropDownItems.Add(subitem);
                    }

                    if (listaMenu[a].tipo.Equals('A'))
                    {
                        subitem = new ToolStripMenuItem(listaMenu[a].objeto_nombre);
                        System.Drawing.Image img = imagen_menu.Images[listaMenu[a].imagen];
                        subitem = new ToolStripMenuItem(listaMenu[a].objeto_nombre, img, new EventHandler(accionMenu));
                        item.DropDownItems.Add(subitem);
                    }
                }
                
            }
        }
        /// <summary>
        /// Método para manejar opciones del menú
        /// </summary>
        ///
        private void accionMenu(object sender, EventArgs e)
        {
            Assembly frmAssembly = Assembly.LoadFile(Application.ExecutablePath);

            if (sender.ToString().ToLower().Equals("salir"))
            {
                Form frmShow = (Form)frmAssembly.CreateInstance("DecisionSupportSystem.frm_login");
                frmShow.Show();
                VG.Variables.mdiForm.Visible = false;
            }

            if (sender.ToString().ToLower().Equals("manual de usuario"))
            {
                System.Diagnostics.Process.Start(Application.StartupPath + @"\Ayuda\ayuda.chm");
            }
            
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
            imagen = 0;
        }
        #endregion

    }
}
