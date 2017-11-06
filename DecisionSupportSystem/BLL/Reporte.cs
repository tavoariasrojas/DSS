using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BLL
{
    public class Reporte
    {
        #region Variables privadas
        /// <summary>
        /// Variables privadas de clase Login
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
        #region Reportes Compañías
        /// <summary>
        /// Método para obtener las compañías de usuario
        /// </summary>
        /// <param name="usuario">Código del usuario</param>
        ///
        public DataSet reporteCompania(string usuario)
        {
            conexion = cls_DAL.trae_conexion("INI", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error validar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    ParamStruct[] parametros = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod_sistema", SqlDbType.VarChar, VG.Variables.codigoAplicacion);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@cod_usuario", SqlDbType.VarChar, usuario);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_obtiene_companias", true, parametros, ref mensaje_error, ref numero_error);

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

        #region Reportes Resumen
        /// <summary>
        /// Método para generar reporte de cliente por género
        /// </summary>
        /// <param name="tipo">Tipo de reporte</param>
        ///
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
        /// <summary>
        /// Método para generar reporte de cliente por edad
        /// </summary>
        ///
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
        /// <summary>
        /// Método para generar reporte de cliente por tipo (Físico-Jurídico)
        /// </summary>
        /// <param name="tipo">Tipo de reporte</param>
        ///
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

        #region Reportes Información de Clientes
        /// <summary>
        /// Método para generar reporte de información de clientes
        /// </summary>
        /// <param name="tipo">Tipo de reporte</param>
        /// <param name="estado">Tipo de reporte</param>
        /// <param name="asesor">Tipo de reporte</param>
        ///
        public DataSet reporteCteInfo(string tipo, string estado, string asesor)
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
                    ParamStruct[] parametros = new ParamStruct[3];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@tipo", SqlDbType.VarChar, tipo);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@estado", SqlDbType.VarChar, estado);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@asesor", SqlDbType.VarChar, asesor);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_cte_info", true, parametros, ref mensaje_error, ref numero_error);

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
        /// <summary>
        /// Método para generar reporte de información de clientes con mayor volumen de inversión
        /// </summary>
        /// <param name="tipo_reporte">Tipo de reporte</param>
        /// <param name="tipo_cliente">Tipo de clientee</param>
        /// <param name="tipo_moneda">Tipo de moneda</param>
        /// <param name="mto_com">Indicador si es por monto o por comisión</param>
        /// <param name="ano_desde">Año desde</param>
        /// <param name="mes_desde">Mes desde</param>
        /// <param name="ano_hasta">Año hasta</param>
        /// <param name="mes_hasta">Mes hasta</param>
        /// <param name="top">Cantidad máxima del top</param>
        /// <param name="expresado">Indica de que forma se desea expresar el monto</param>
        ///
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

        #region Reportes Rendimiento de Productos
        /// <summary>
        /// Método para generar reporte de productos por rendimiento
        /// </summary>
        /// <param name="tipo_reporte">Tipo de reporte</param>
        /// <param name="tipo_instrumento">Tipo de instrumento</param>
        /// <param name="tipo_moneda">Tipo de moneda</param>
        /// <param name="mto_com">Indicador si es por monto o por comisión</param>
        /// <param name="ano_desde">Año desde</param>
        /// <param name="mes_desde">Mes desde</param>
        /// <param name="ano_hasta">Año hasta</param>
        /// <param name="mes_hasta">Mes hasta</param>
        /// <param name="top">Cantidad máxima del top</param>
        /// 
        public DataSet reporteProdRend(string tipo_reporte, string tipo_instrumento, string tipo_moneda, int ano_desde, int mes_desde, int ano_hasta, int mes_hasta, decimal top)
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
                    ParamStruct[] parametros = new ParamStruct[8];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@tipo_rep", SqlDbType.VarChar, tipo_reporte);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@tipo_instrumento", SqlDbType.VarChar, tipo_instrumento);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@tipo_moneda", SqlDbType.VarChar, tipo_moneda);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@ano_desde", SqlDbType.Int, ano_desde);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@mes_desde", SqlDbType.Int, mes_desde);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@ano_hasta", SqlDbType.Int, ano_hasta);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@mes_hasta", SqlDbType.Int, mes_hasta);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@top", SqlDbType.Decimal, top);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_top_prod_rent_comis", true, parametros, ref mensaje_error, ref numero_error);

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

        #region Reporte Lista de Ejecutivos Rango de Años
        /// <summary>
        /// Método para generar reporte de ejecutivos
        /// </summary>
        /// <param name="indicador">Indicador/param>
        /// <param name="ano_inicial">Año inicial</param>
        /// <param name="ano_final">Año final</param>
        /// <param name="asesor">Cósigo del asesor</param>
        /// 
        public DataSet reporteEjecutivos(int indicador, int ano_inicial, int ano_final, string asesor)
        {
            if (ano_inicial > 0 && ano_final > 0)
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
                        ParamStruct[] parametros = new ParamStruct[4];
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@indicador", SqlDbType.Int, indicador);
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@ano_desde", SqlDbType.Int, ano_inicial);
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@ano_hasta", SqlDbType.Int, ano_final);
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@asesor", SqlDbType.VarChar, asesor);
                        ds = cls_DAL.ejecuta_dataset(conexion, "sp_filtra_ejecutivo", true, parametros, ref mensaje_error, ref numero_error);

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
            return null;
        }
        #endregion

        #region Reportes de Clientes Nuevos
        /// <summary>
        /// Método para generar reporte de información de clientes con mayor volumen de inversión
        /// </summary>
        /// <param name="tipo_reporte">Tipo de reporte</param>
        /// <param name="comision_transado">Seleccionar comisión o transado</param>
        /// <param name="tipo_moneda">Tipo de moneda</param>
        /// <param name="mto_com">Indicador si es por monto o por comisión</param>
        /// <param name="ano_desde">Año desde</param>
        /// <param name="mes_desde">Mes desde</param>
        /// <param name="ano_hasta">Año hasta</param>
        /// <param name="mes_hasta">Mes hasta</param>
        /// <param name="expresado">Indica de que forma se desea expresar el monto</param>
        ///
        public DataSet reporteComiEjec(string tipo_reporte, string comision_transado, string tipo_moneda, int ano_desde, int mes_desde, int ano_hasta, int mes_hasta, string ejecutivo, decimal expresado)
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
                    ParamStruct[] parametros = new ParamStruct[9];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@tipo_rep", SqlDbType.VarChar, tipo_reporte);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@tipo_valor", SqlDbType.VarChar, comision_transado);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@tipo_moneda", SqlDbType.VarChar, tipo_moneda);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@ano_desde", SqlDbType.Int, ano_desde);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@mes_desde", SqlDbType.Int, mes_desde);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@ano_hasta", SqlDbType.Int, ano_hasta);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@mes_hasta", SqlDbType.Int, mes_hasta);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@ejecutivo", SqlDbType.VarChar, ejecutivo);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@expresado", SqlDbType.Decimal, expresado);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_info_movto_ejecutivos", true, parametros, ref mensaje_error, ref numero_error);

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

        #region Reportes de Comisiones de Ejecutivos
        /// <summary>
        /// Método para generar reporte de productos por rendimiento
        /// </summary>
        /// <param name="tipo_reporte">Tipo de reporte</param>
        /// <param name="asesor">Código del asesor</param>
        /// <param name="ejecutivo">Código de ejecutivo</param>
        /// <param name="ano_desde">Año desde</param>
        /// <param name="mes_desde">Mes desde</param>
        /// <param name="ano_hasta">Año hasta</param>
        /// <param name="mes_hasta">Mes hasta</param>
        /// 
        public DataSet reporteCtesNuev(string tipo_reporte, string asesor, string ejecutivo, int ano_desde, int mes_desde, int ano_hasta, int mes_hasta)
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
                    ParamStruct[] parametros = new ParamStruct[7];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@tipo_rep", SqlDbType.VarChar, tipo_reporte);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@asesor", SqlDbType.VarChar, asesor);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@ejecutivo", SqlDbType.VarChar, ejecutivo);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@ano_desde", SqlDbType.Int, ano_desde);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@mes_desde", SqlDbType.Int, mes_desde);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@ano_hasta", SqlDbType.Int, ano_hasta);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@mes_hasta", SqlDbType.Int, mes_hasta);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_info_nuevs_ctes", true, parametros, ref mensaje_error, ref numero_error);

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

        #region Reportes de Roles
        /// <summary>
        /// Método para generar reporte de roles
        /// </summary>
        /// 
        public DataSet reporteRoles()
        {
            conexion = cls_DAL.trae_conexion("SM", ref mensaje_error, ref numero_error);
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
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod_sistema", SqlDbType.VarChar, VG.Variables.codigoAplicacion);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_lista_roles", true, parametros, ref mensaje_error, ref numero_error);

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

        #region Reportes de Usuarios
        /// <summary>
        /// Método para generar reporte de usuario
        /// </summary>
        /// <param name="tip">Tipo de reporte</param>
        /// 
        public DataSet reporteUsuarios(int tipo)
        {
            conexion = cls_DAL.trae_conexion("SM", ref mensaje_error, ref numero_error);
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
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@tipo", SqlDbType.Int, tipo);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_lista_usuarios", true, parametros, ref mensaje_error, ref numero_error);

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