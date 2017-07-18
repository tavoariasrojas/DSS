using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BLL
{
    public class Reporte
    {
        
        #region Variables privadas
        SqlConnection conexion;
        string mensaje_error;
        int numero_error;
        DataSet ds;
        #endregion

        #region Metodos
        public DataSet reporteCteGenero( string tipo)
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
                    ParamStruct[] parametros = new ParamStruct[1];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@tipo", SqlDbType.VarChar, tipo);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_cte_genero", true, parametros, ref mensaje_error, ref numero_error);

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

        public DataSet reporteCteEdad()
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
                    ParamStruct[] parametros = new ParamStruct[0];
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_cte_edad", true, parametros, ref mensaje_error, ref numero_error);

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
    }
}
