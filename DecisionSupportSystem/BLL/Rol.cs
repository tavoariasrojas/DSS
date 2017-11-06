using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BLL
{
    public class Rol
    {
        #region Propiedades
        /// <summary>
        /// Propiedades del rol
        /// </summary>
        /// <param name="listaRol">Objeto tipo lista que almacena roles</param>
        /// <param name="objeto">Tipo de objeto</param>
        /// <param name="objeto_padre">Contiene el objeto padre</param>
        /// <param name="nombre">Contiene el nombre del objeto</param>
        /// <param name="chequeado">Indica si el objeto esta chequeado</param>
        List<Rol> listaRol = new List<Rol>();

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

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private char _chequeado;

        public char chequeado
        {
            get { return _chequeado; }
            set { _chequeado = value; }
        }
        #endregion

        #region variables privadas
        /// <summary>
        /// Propiedades del rol
        /// </summary>
        /// <param name="conexion">Almacena la conexion a base de datos</param>
        /// <param name="transaccion">Almacena la transacción</param>
        /// <param name="mensaje_error">Mensaje de error</param>
        /// <param name="numero_error">Número de error</param>
        /// <param name="ds">DataSet</param>
        SqlConnection conexion;
        SqlTransaction transaccion;
        string mensaje_error;
        int numero_error;
        DataSet ds;
        #endregion

        #region Metodos
        /// <summary>
        /// Método para obtener la lista de los roles
        /// </summary>
        /// <param name="obtenerRol">Método para obtener el rol</param>
        /// <param name="tipo">Indicador de tipo de rol</param>
        /// <param name="cod_rol">Código que idebntifica el rol</param>
        public DataSet obtenerRol(char tipo, string cod_rol)
        {
            conexion = cls_DAL.trae_conexion("SM", ref mensaje_error, ref numero_error);
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
                    ParamStruct[] parametros = new ParamStruct[3];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@tipo", SqlDbType.Char, tipo);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@cod_sistema", SqlDbType.VarChar, VG.Variables.codigoAplicacion);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@cod_rol", SqlDbType.VarChar, cod_rol);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_detalle_rol", true, parametros, ref mensaje_error, ref numero_error);
                }
            }
            return ds;
        }
        /// <summary>
        /// Método para obtener la lista de los roles
        /// </summary>
        /// <param name="menejarRol">Método para el manejo de roles</param>
        /// <param name="accion">Acción a realizar con el rol</param>
        /// <param name="cod_rol">Código que idebntifica el rol</param>
        /// <param name="nom_rol">Nombre del rol</param>
        /// <param name="lista">Variable tipo lista para el almacenamiento del rol</param>
        public bool manejarRol(string accion, string cod_rol, string nom_rol, List<Rol> lista)
        {
            bool estado = false;
            conexion = cls_DAL.trae_conexion("SM", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al realizar consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    try
                    {
                        ParamStruct[] parametros = new ParamStruct[4];
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@accion", SqlDbType.VarChar, accion);
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@cod_rol", SqlDbType.VarChar, cod_rol);
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@nom_rol", SqlDbType.VarChar, nom_rol);
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@cod_sistema", SqlDbType.VarChar, VG.Variables.codigoAplicacion);
                        cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                        transaccion = conexion.BeginTransaction();

                        cls_DAL.ejecuta_sp(conexion, transaccion, "sp_manejo_sg_rol", true, parametros, ref mensaje_error, ref numero_error);

                        if (numero_error == 0)
                        {
                            for (int i = 0; i < lista.Count; i++)
                            {
                                if (accion.Equals("I"))
                                {
                                    if (lista[i].chequeado == 'S')
                                    {
                                        estado = manejarAccionesRol(conexion, transaccion, accion, cod_rol, lista[i].objeto);
                                    }
                                }
                                else
                                {
                                    if (lista[i].chequeado == 'S')
                                    {
                                        estado = manejarAccionesRol(conexion, transaccion, "U", cod_rol, lista[i].objeto);
                                    }
                                    else
                                    {
                                        estado = manejarAccionesRol(conexion, transaccion, "D", cod_rol, lista[i].objeto);
                                    }
                                }

                                if (!estado)
                                {
                                    break; ;
                                }
                            }

                            if (estado)
                            {
                                transaccion.Commit();
                                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                                return true;
                            }
                            else
                            {
                                transaccion.Rollback();
                                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                                return false;
                            }
                        }
                        else
                        {
                            transaccion.Rollback();
                            cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                            return false;
                        }
                    }
                    catch (Exception Ex)
                    {
                        numero_error = Ex.HResult;
                        mensaje_error = Ex.Message;
                        return false;
                    }
                }
            }
        }
        /// <summary>
        /// Método para controlar las acciones por roles
        /// </summary>
        /// <param name="conexion">Conexión a base de datos</param>
        /// <param name="transaccion">Transacción de base de datos</param>
        /// <param name="accion">Acción a realizar</param>
        /// <param name="cod_rol">Código del rol</param>
        /// <param name="cod_objeto">Código del objeto</param>
        public bool manejarAccionesRol(SqlConnection conexion, SqlTransaction transaccion, string accion, string cod_rol, string cod_objeto)
        {
            try
            {
                ParamStruct[] parametros = new ParamStruct[4];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@accion", SqlDbType.VarChar, accion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@cod_rol", SqlDbType.VarChar, cod_rol);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@cod_objeto", SqlDbType.VarChar, cod_objeto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@cod_sistema", SqlDbType.VarChar, VG.Variables.codigoAplicacion);
                cls_DAL.ejecuta_sp(conexion, transaccion, "sp_manejo_sg_accion_rol", true, parametros, ref mensaje_error, ref numero_error);

                if (numero_error == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception Ex)
            {
                numero_error = Ex.HResult;
                mensaje_error = Ex.Message;
                return false;
            }
        }
        /// <summary>
        /// Método para asirnar roles al usuario
        /// </summary>
        /// <param name="lista">Lista que contiene las opciones asignar</param>
        /// <param name="usuario">Código de usuario</param>
        public bool asignarRolUsuario(List<string[]> lista, string usuario)
        {
            bool estado = true;

            conexion = cls_DAL.trae_conexion("SM", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al realizar consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    try
                    {
                        cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                        transaccion = conexion.BeginTransaction();
                        for (int i = 0; i < lista.Count; i++)
                        {
                            if (estado)
                            {
                                estado = asignarRol(conexion, transaccion, lista[i][1], usuario, lista[i][0]);
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (estado)
                        {
                            transaccion.Commit();
                            cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                            return true;
                        }
                        else
                        {
                            transaccion.Rollback();
                            cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                            return false;
                        }
                    }
                    catch (Exception Ex)
                    {
                        numero_error = Ex.HResult;
                        mensaje_error = Ex.Message;
                        return false;
                    }
                }
            }
        }
        /// <summary>
        /// Método para asirnar roles
        /// </summary>
        /// <param name="conexion">Conexión a base de datos</param>
        /// <param name="transaccion">Transacción de base de datos</param>
        /// <param name="accion">Acción a realizar</param>
        /// <param name="cod_usuario">Código del rol</param>
        /// <param name="cod_rol">Código del rol</param>
        public bool asignarRol(SqlConnection conexion, SqlTransaction transaccion, string accion, string cod_usuario, string cod_rol)
        {
            try
            {
                ParamStruct[] parametros = new ParamStruct[5];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@accion", SqlDbType.VarChar, accion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@cod_usuario", SqlDbType.VarChar, cod_usuario);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@cod_compania", SqlDbType.VarChar, VG.Variables.codigoCompania);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@cod_rol", SqlDbType.VarChar, cod_rol);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@cod_sistema", SqlDbType.VarChar, VG.Variables.codigoAplicacion);
                cls_DAL.ejecuta_sp(conexion, transaccion, "sp_manejo_sg_usuario_x_rol", true, parametros, ref mensaje_error, ref numero_error);

                if (numero_error == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception Ex)
            {
                numero_error = Ex.HResult;
                mensaje_error = Ex.Message;
                return false;
            }
        }
        /// <summary>
        /// Método para llenar el rol
        /// </summary>
        /// <param name="cod_rol">Código del rol</param>
        public Boolean llenarRol(string cod_rol)
        {
            listaRol.Clear();
            foreach (DataRow row in obtenerRol('D', cod_rol).Tables[0].Rows)
            {
                Rol rol = new Rol();
                rol.objeto = Convert.ToString(row[0]);
                rol.objeto_padre = Convert.ToString(row[1]);
                rol.nombre = Convert.ToString(row[2]);
                rol.chequeado = Convert.ToChar(row[3]);
                listaRol.Add(rol);
            }
            if (listaRol.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Método para dibujar el rol
        /// </summary>
        /// <param name="cod_rol">Código del rol</param>
        /// <param name="tv">Objeto TreeView que mostrará las opciones del rol</param>
        public void dibujaRol(string cod_rol, TreeView tv)
        {
            if (llenarRol(cod_rol))
            {
                for (int a = 0; a < listaRol.Count; a++)
                {
                    if (string.IsNullOrEmpty(listaRol[a].objeto_padre))
                    {
                        tv.Nodes.Add(agregarNodoRaiz(listaRol[a].objeto, listaRol[a].nombre, listaRol[a].chequeado, listaRol[a].objeto));
                    }
                }
                tv.ExpandAll();
            }
            else
            {
                MessageBox.Show(mensaje_error, "Error al realizar consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private TreeNode agregarNodoRaiz(string codigo, string nombre, char chk, string tag)
        {
            TreeNode tn = new TreeNode(nombre);
            tn.Tag = tag;

            switch (chk)
            {
                case 'S':
                    tn.Checked = true;
                    break;
                case 'O':
                    tn.Checked = true;
                    tn.ForeColor = System.Drawing.Color.Blue;
                    break;
            }

            for (int a = 0; a < listaRol.Count; a++)
            {
                if (listaRol[a].objeto_padre.Equals(codigo))
                {
                    agregarNodo(tn, listaRol[a].objeto, listaRol[a].nombre, listaRol[a].chequeado, listaRol[a].objeto);
                }
            }
            return tn;
        }
        /// <summary>
        /// Método para agregar nodos al TreeView
        /// </summary>
        /// <param name="tnr">TreeViewNode</param>
        /// <param name="codigo">Código de la opción</param>
        /// <param name="nombre">Nombre de la opción</param>
        /// <param name="chk">Indicador de chequeado</param>
        /// <param name="tag">Indicador tag del objeto</param>
        private void agregarNodo(TreeNode trn, string codigo, string nombre, char chk, string tag)
        {
            TreeNode tn = new TreeNode(nombre);
            tn.Tag = tag;

            switch (chk)
            {
                case 'S':
                    tn.Checked = true;
                    break;
                case 'O':
                    tn.Checked = true;
                    tn.ForeColor = System.Drawing.Color.Blue;
                    break;
            }

            for (int a = 0; a < listaRol.Count; a++)
            {
                if (listaRol[a].objeto_padre.Equals(codigo))
                {
                    agregarNodo(tn, listaRol[a].objeto, listaRol[a].nombre, listaRol[a].chequeado, listaRol[a].objeto);
                }
            }
            trn.Nodes.Add(tn);
        }
        /// <summary>
        /// Método para recorrer el TreeView
        /// </summary>
        /// <param name="tv">Objeto TreeView</param>
        /// <param name="opciones">Objeto de4 tipo rol que contiene las opciones del rol</param>
        public List<Rol> recorerArbol(TreeView tv, List<Rol> opciones)
        {
            TreeNodeCollection nodes = tv.Nodes;
            foreach (TreeNode n in nodes)
            {
                recorerRamas(n, opciones);
            }
            return opciones;
        }

        private List<Rol> recorerRamas(TreeNode treeNode, List<Rol> opciones)
        {
            if (treeNode.Checked)
            {
                opciones.Add(new Rol(treeNode.Tag.ToString(), 'S'));
            }
            else
            {
                opciones.Add(new Rol(treeNode.Tag.ToString(), 'N'));
            }
            foreach (TreeNode tn in treeNode.Nodes)
            {
                recorerRamas(tn, opciones);
            }
            return opciones;
        }
        /// <summary>
        /// Método para verificar opciones chequeadas
        /// </summary>
        /// <param name="lista">Lista tipo rol para contener opciones</param>
        public int verificaChequeados(List<Rol> lista)
        {
            int contador = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].chequeado == 'S')
                {
                    contador++;
                }
            }
            return contador;
        }
        /// <summary>
        /// Método para ontener los roles de un usuario
        /// </summary>
        /// <param name="lista">Lista tipo rol para contener opciones</param>
        /// <param name="accion">Obtener accion</param>
        /// <param name="lista">Código de usuario</param>
        public DataSet obtenerRoles(ListView lista, string accion, string cod_usuario)
        {
            conexion = cls_DAL.trae_conexion("SM", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al realizar consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    ParamStruct[] parametros = new ParamStruct[3];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@accion", SqlDbType.Char, accion);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@cod_sistema", SqlDbType.VarChar, VG.Variables.codigoAplicacion);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@cod_usuario", SqlDbType.VarChar, cod_usuario);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_asignacion_roles", true, parametros, ref mensaje_error, ref numero_error);
                    if (numero_error == 0)
                    {
                        return ds;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        #endregion

        #region Contructor
        public Rol()
        {
            objeto = string.Empty;
            objeto_padre = string.Empty;
            nombre = string.Empty;
            chequeado = '\0';//Equivalente al nulo de un char
        }

        public Rol(string obj, char chk)
        {
            objeto = obj;
            chequeado = chk;//Equivalente al nulo de un char
        }

        #endregion
    }
}
