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

        private string _padre;

        public string padre
        {
            get { return _padre; }
            set { _padre = value; }
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

        public Boolean llenarRol(string cod_rol)
        {
            listaRol.Clear();
            foreach (DataRow row in obtenerRol(cod_rol).Tables[0].Rows)
            {
                Rol rol = new Rol();
                rol.objeto = Convert.ToString(row[0]);
                rol.padre = Convert.ToString(row[1]);
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
            int indexPadre = 0;
            int indexHijo = 0;

            if (llenarRol(cod_rol))
            {
                for (int a = 0; a < listaRol.Count; a++)
                {
                    if (string.IsNullOrEmpty(listaRol[a].padre))
                    {
                        tv.Nodes.Add(listaRol[a]._objeto, listaRol[a]._nombre);
                        if (listaRol[a].chequeado.Equals('S'))
                        {
                            indexPadre = tv.Nodes.IndexOfKey(listaRol[a]._objeto);
                            tv.Nodes[indexPadre].Checked = true;
                        }
                    }
                    else
                    {
                        tv.Nodes[tv.Nodes.IndexOfKey(listaRol[a]._padre)].Nodes.Add(listaRol[a]._objeto, listaRol[a]._nombre);
                        if (listaRol[a].chequeado.Equals('S'))
                        {
                            indexPadre = tv.Nodes.IndexOfKey(listaRol[a]._padre);
                            indexHijo = tv.Nodes[indexPadre].Nodes.IndexOfKey(listaRol[a]._objeto);
                            tv.Nodes[indexPadre].Nodes[indexHijo].Checked = true;
                        }
                    }
                }
                tv.ExpandAll();
            }
            else
            {
                MessageBox.Show(mensaje_error, "Error al realizar consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Contructor
        public Rol()
        {
            objeto = string.Empty;
            padre= string.Empty;
            nombre = string.Empty;
            chequeado = '\0';//Equivalente al nulo de un char
        }
        #endregion
    }
}
