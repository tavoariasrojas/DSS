using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class Consulta
    {
        #region parametros
        private string _sql_query;

        public string sql_query
        {
            get { return _sql_query; }
            set { _sql_query = value; }
        }

        private DateTime _fecha_ini;

        public DateTime fecha_ini
        {
            get { return _fecha_ini; }
            set { _fecha_ini = value; }
        }

        private DateTime _fecha_fin;

        public DateTime fecha_fin
        {
            get { return _fecha_fin; }
            set { _fecha_fin = value; }
        }
        #endregion

        #region variables privadas
        SqlConnection conexion;
        string mensaje_error;
        int numero_error;
        DataSet ds;
        #endregion

        #region metodos
        public DataSet reporteClientesNuevos()
        {
            conexion = cls_DAL.trae_conexion("DSS", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "No se pude realizar conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    ParamStruct[] parametros = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@fec_ini", SqlDbType.DateTime, fecha_ini);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@fec_fin", SqlDbType.DateTime, fecha_fin);
                    ds = cls_DAL.ejecuta_dataset(conexion, sql_query, false, parametros, ref mensaje_error, ref numero_error);

                    if (numero_error != 0)
                    {
                        conexion.Close();
                        return null;
                    }
                    else
                    {
                        conexion.Close();
                        return ds;
                    }
                }
            }
        }
        #endregion

        #region Constructor
        public Consulta()
        {
            sql_query = string.Empty;
            fecha_ini = new DateTime(1900, 01, 01);
            fecha_fin = new DateTime(1900, 01, 01);
        }
        #endregion

    }
}
