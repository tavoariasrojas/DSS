using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DAL;

namespace BLL
{
    public class Capacitar
    {
        #region variables privadas
        SqlConnection conexion;
        SqlTransaction transaccion;
        DataSet ds;
        string mensaje_error;
        int numero_error;
        #endregion

        #region Métodos
        public bool ingresarParticipante(List<string> participantes)
        {
            conexion = cls_DAL.trae_conexion("INI", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                return false;
            }
            else
            {
                if (numero_error != 0)
                {
                    return false;
                }
                else
                {
                    try
                    {
                        bool estatus = borrarParticipante("D");
                        conexion.Open();
                        transaccion = conexion.BeginTransaction();

                        for (int i = 0; i < participantes.Count; i++)
                        {
                            if (estatus)
                            {
                                ParamStruct[] parametros = new ParamStruct[3];
                                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@accion", SqlDbType.VarChar, "I");
                                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@nombre", SqlDbType.VarChar, participantes[i]);
                                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@numero", SqlDbType.Int, 0);
                                cls_DAL.ejecuta_sp(conexion, transaccion, "sp_manejo_participante", true, parametros, ref mensaje_error, ref numero_error);
                            }
                            else
                            {
                                estatus = false;
                            }
                        }

                        if (numero_error == 0)
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

        public bool borrarParticipante(string accion)
        {
            conexion = cls_DAL.trae_conexion("INI", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                return false;
            }
            else
            {
                if (numero_error != 0)
                {
                    return false;
                }
                else
                {
                    try
                    {
                        conexion.Open();
                        transaccion = conexion.BeginTransaction();

                        ParamStruct[] parametros = new ParamStruct[3];
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@accion", SqlDbType.VarChar, accion);
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@nombre", SqlDbType.VarChar, "");
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@numero", SqlDbType.Int, 0);
                        cls_DAL.ejecuta_sp(conexion, transaccion, "sp_manejo_participante", true, parametros, ref mensaje_error, ref numero_error);

                        if (numero_error == 0)
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

        public int cantidadParticipantes(string accion)
        {
            int cantidad = 0;
            conexion = cls_DAL.trae_conexion("INI", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                return 0;
            }
            else
            {
                if (numero_error != 0)
                {
                    return 0;
                }
                else
                {
                    ParamStruct[] parametros = new ParamStruct[3];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@accion", SqlDbType.VarChar, accion);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@nombre", SqlDbType.VarChar, "");
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@numero", SqlDbType.Int, 0);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_manejo_participante", true, parametros, ref mensaje_error, ref numero_error);
                    cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                    if (cantidad > 0)
                    {
                        conexion.Close();
                        return cantidad;
                    }
                    else
                    {
                        conexion.Close();
                        return 0;
                    }
                }
            }
        }

        public string escogerParticipante(string accion, int numero)
        {
            string candidato = string.Empty;
            conexion = cls_DAL.trae_conexion("INI", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                return string.Empty;
            }
            else
            {
                if (numero_error != 0)
                {
                    return string.Empty;
                }
                else
                {
                    ParamStruct[] parametros = new ParamStruct[3];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@accion", SqlDbType.VarChar, accion);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@nombre", SqlDbType.VarChar, "");
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@numero", SqlDbType.Int, numero);
                    ds = cls_DAL.ejecuta_dataset(conexion, "sp_manejo_participante", true, parametros, ref mensaje_error, ref numero_error);
                    candidato = ds.Tables[0].Rows[0][0].ToString();

                    if (candidato != string.Empty)
                    {
                        conexion.Close();
                        return candidato;
                    }
                    else
                    {
                        conexion.Close();
                        return string.Empty;
                    }
                }
            }
        }
        #endregion
    }
}
