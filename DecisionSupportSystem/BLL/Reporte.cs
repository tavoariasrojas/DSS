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

        #region Reportes Resumen
        public DataSet reporteCteGenero(string tipo)
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

        public DataSet reporteCteTipo(string tipo)
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
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_cte_tipo", true, parametros, ref mensaje_error, ref numero_error);

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

        #region Reportes Clientes Mayor Volumen Inversion
        public DataSet reporteMayVolInv(string tipo_reporte, string tipo_cliente, string tipo_moneda, string mto_com, int ano_desde, int mes_desde, int ano_hasta, int mes_hasta, decimal top, decimal expresado)
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
                    ParamStruct[] parametros = new ParamStruct[10];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@tipo_rep", SqlDbType.VarChar, tipo_reporte);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@tipo_cte", SqlDbType.VarChar, tipo_cliente);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@tipo_moneda", SqlDbType.VarChar, tipo_moneda);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@monto_comision", SqlDbType.VarChar, mto_com);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@ano_desde", SqlDbType.Int, ano_desde);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@mes_desde", SqlDbType.Int, mes_desde);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@ano_hasta", SqlDbType.Int, ano_hasta);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@mes_hasta", SqlDbType.Int, mes_hasta);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@top", SqlDbType.Decimal, top);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@expresado", SqlDbType.Decimal, expresado); 
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_top_vol_invers_cliente", true, parametros, ref mensaje_error, ref numero_error);

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

        #endregion
    }
}
