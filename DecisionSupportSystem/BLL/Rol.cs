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
        SqlConnection conexion;
        string mensaje_error;
        int numero_error;
        DataSet ds;
        #endregion

        #region Metodos
        public DataSet obtenerRol(string cod_rol)
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
                    ParamStruct[] parametros = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod_sistema", SqlDbType.VarChar, VG.Variables.codigoAplicacion);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@cod_rol", SqlDbType.VarChar, cod_rol);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_detalle_rol", true, parametros, ref mensaje_error, ref numero_error);
                }
            }
            return ds;
        }

        public DataSet obtenerJerarquiaOpcion(string cod_opcion)
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
                    ParamStruct[] parametros = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod_sistema", SqlDbType.VarChar, VG.Variables.codigoAplicacion);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@cod_objeto", SqlDbType.VarChar, cod_opcion);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_jerarquia_opcion", true, parametros, ref mensaje_error, ref numero_error);
                }
            }
            return ds;
        }

        public Boolean llenarRol(string cod_rol)
        {
            listaRol.Clear();
            foreach (DataRow row in obtenerRol(cod_rol).Tables[0].Rows)
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
            if (chk.Equals('S'))
            {
                tn.Checked = true;
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

        private void agregarNodo(TreeNode tnr, string codigo, string nombre, char chk, string tag)
        {
            TreeNode tn = new TreeNode(nombre);
            if (chk.Equals('S'))
            {
                tn.Checked = true;
            }
            for (int a = 0; a < listaRol.Count; a++)
            {
                if (listaRol[a].objeto_padre.Equals(codigo))
                {
                    agregarNodo(tn, listaRol[a].objeto, listaRol[a].nombre, listaRol[a].chequeado, listaRol[a].objeto);
                }
            }
            tnr.Nodes.Add(tn);
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
        #endregion
    }
}
