using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class Login : Fecha
    {
        #region parametros
        /// <summary>
        /// Parámetros de la clase Login
        /// </summary>
        /// <param name="password">Almacena contraseña</param>
        /// <param name="usuario_bd">Almacena usuario de base de datos</param>
        /// <param name="password_db">Almacena contraseña de la base de datos</param>
        /// <param name="fecha_vencimiento">Almacena fecha de vencimiento</param>
        /// <param name="dias_habilita_clave">Almacena días que dura vigente la contraseña</param>
        /// <param name="ind_desactivado">Almacena indicador de usuario activo</param>
        /// <param name="ind_auditoria">Almacena indicador de auditoría</param>
        /// <param name="ind_supervisor">Almacena indicador de supervisor</param>
        /// <param name="multiples_conexiones">Almacena indicador de multiples conexiones</param>
        /// <param name="cambiar_password">Almacena indicador cambiar password</param>
        ///
        private string _password;

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _usuario_bd;

        public string usuario_bd
        {
            get { return _usuario_bd; }
            set { _usuario_bd = value; }
        }

        private string _password_db;

        public string password_db
        {
            get { return _password_db; }
            set { _password_db = value; }
        }

        private DateTime _fecha_vencimiento;

        public DateTime fecha_vencimiento
        {
            get { return _fecha_vencimiento; }
            set { _fecha_vencimiento = value; }
        }

        private int _dias_habilita_clave;

        public int dias_habilita_clave
        {
            get { return _dias_habilita_clave; }
            set { _dias_habilita_clave = value; }
        }

        private char _ind_desactivado;

        public char ind_desactivado
        {
            get { return _ind_desactivado; }
            set { _ind_desactivado = value; }
        }

        private char _ind_auditoria;

        public char ind_auditoria
        {
            get { return _ind_auditoria; }
            set { _ind_auditoria = value; }
        }

        private char _ind_supervisor;

        public char ind_supervisor
        {
            get { return _ind_supervisor; }
            set { _ind_supervisor = value; }
        }

        private char _multiples_conexiones;

        public char multiples_conexiones
        {
            get { return _multiples_conexiones; }
            set { _multiples_conexiones = value; }
        }

        private char _cambiar_password;

        public char cambiar_password
        {
            get { return _cambiar_password; }
            set { _cambiar_password = value; }
        }
        #endregion

        #region variables privadas
        /// <summary>
        /// Variables privadas de clase Login
        /// </summary>
        /// <param name="conexion">Conexión de base de datos/param>
        /// <param name="sql">sentencia sql</param>
        /// <param name="mensaje_error">Mensaje de error</param>
        /// <param name="numero_error">Número de error</param>
        /// <param name="ds">DataSet</param>
        /// <param name="transaccion">Transacción de base de datos</param>
        /// 
        SqlConnection conexion;
        string sql;
        string mensaje_error;
        int numero_error;
        DataSet ds;
        SqlTransaction transaccion;
        #endregion

        #region Métodos
        /// <summary>
        /// Método para validar la existencia del usuario
        /// </summary>
        /// <param name="mensaje_error">Mensaje de error</param>
        /// <param name="numero_error">Número de error</param>
        /// 
        public Boolean usuarioExiste(string usuario)
        {
            int cantidad = 0;
            conexion = cls_DAL.trae_conexion("INI", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error validar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    sql = "SELECT COUNT(*) cantidad " +
                        "FROM seg_usuarios " +
                        "WHERE sg_usu_nombre_usuario = @usuario ";

                    ParamStruct[] parametros = new ParamStruct[1];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@usuario", SqlDbType.VarChar, usuario);
                    ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                    cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                    if (cantidad == 1)
                    {
                        conexion.Close();
                        return true;
                    }
                    else
                    {
                        conexion.Close();
                        return false;
                    }
                }
            }
        }
        /// <summary>
        /// Método para obtener información encriptada del usuario
        /// </summary>
        /// <param name="usuario">Código del usuario</param>
        /// 
        public string obtieneInfoEncriptada(string usuario)
        {
            string info = string.Empty;
            Login login = new Login();

            conexion = cls_DAL.trae_conexion("INI", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error validar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sql = "SELECT CONVERT(VARCHAR(300), m1210961861135) datos " +
                          "FROM m121096070873 " +
                          "WHERE m1861135121096 = @usuario ";

                    ParamStruct[] parametros = new ParamStruct[1];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@usuario", SqlDbType.VarChar, usuario);
                    ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                    if (ds != null)
                    {
                        info = ds.Tables[0].Rows[0][0].ToString();
                    }
                    else
                    {
                        info = null;
                    }
                    
                }
            }
            return info;
        }
        /// <summary>
        /// Método para obtener desencriptar información encriptada del usuario
        /// </summary>
        /// <param name="info">Cadena de datos encriptada</param>
        /// 
        public void descomponeInfoEncriptada(string info)
        {
            password            = info.Split(';')[0];
            VG.Variables.password = password;

            usuario_bd          = info.Split(';')[1];
            VG.Variables.usuario_bd = usuario_bd;

            password_db         = info.Split(';')[2];
            VG.Variables.password_db = password_db;

            fecha_vencimiento   = Convert.ToDateTime(info.Split(';')[3]);
            VG.Variables.fecha_vencimiento = fecha_vencimiento;

            dias_habilita_clave = Convert.ToInt32(info.Split(';')[4]);
            VG.Variables.dias_habilita_clave = dias_habilita_clave;

            ind_desactivado     = Convert.ToChar(info.Split(';')[5]);
            VG.Variables.ind_desactivado = ind_desactivado;

            ind_auditoria       = Convert.ToChar(info.Split(';')[6]);
            VG.Variables.ind_auditoria = ind_auditoria;

            ind_supervisor      = Convert.ToChar(info.Split(';')[7]);
            VG.Variables.ind_supervisor = ind_supervisor;

            multiples_conexiones = Convert.ToChar(info.Split(';')[8]);
            VG.Variables.multiples_conexiones = multiples_conexiones;

            cambiar_password    = Convert.ToChar(info.Split(';')[9]);
            VG.Variables.cambiar_password = cambiar_password;
        }

        public int verificaDatos(string password)
        {
            if (!password.Equals(this.password))
            {
                return 1;
            }

            if (ind_desactivado.Equals('S'))
            {
                return 2;
            }

            DateTime ldt_fecha = obtieneFechaServidor();
            if (ldt_fecha > this.fecha_vencimiento)
            {
                return 3;
            }

            if(cambiar_password == 'S')
            {
                return 4;
            }

            return 0;
        }
        /// <summary>
        /// Método para obtener el nombre del usuario
        /// </summary>
        /// <param name="usuario">Código del usuario</param>
        /// 
        public string obtieneNombreUsuario(string usuario)
        {
            string info = string.Empty;
            Login login = new Login();

            conexion = cls_DAL.trae_conexion("INI", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error validar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sql = "SELECT rtrim(sg_usu_nombre_completo) " +
                        "FROM seg_usuarios " +
                        "WHERE sg_usu_nombre_usuario = @usuario ";

                    ParamStruct[] parametros = new ParamStruct[1];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@usuario", SqlDbType.VarChar, usuario);
                    ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                    if (ds != null)
                    {
                        info = ds.Tables[0].Rows[0][0].ToString();
                    }
                    else
                    {
                        info = null;
                    }

                }
            }
            return info;
        }
        /// <summary>
        /// Método para el manejo de usuarios
        /// </summary>
        /// <param name="tipo">Tipo de accion</param>
        /// <param name="cod_usuario">Código del usuario</param>
        /// <param name="nombre">Nombre del usuario</param>
        /// <param name="clave_bd">Clave de la base de datos</param>
        /// <param name="clave_app">Clave del sistema</param>
        /// <param name="cod_compania">Código de la compañía</param>
        /// <param name="cod_sistema">Código del sistema</param>
        ///
        public bool manejoUsuario(string tipo, string cod_usuario, string nombre, string clave_bd, string clave_app, string cod_compania, string cod_sistema)
        {
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
                        ParamStruct[] parametros = new ParamStruct[7];
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@tipo", SqlDbType.VarChar, tipo);
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@cod_usuario", SqlDbType.VarChar, cod_usuario);
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@nombre", SqlDbType.VarChar, nombre);
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@clave_bd", SqlDbType.VarChar, clave_bd);
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@clave_app", SqlDbType.VarChar, clave_app);
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@cod_compania", SqlDbType.VarChar, cod_compania);
                        cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@cod_sistema", SqlDbType.VarChar, cod_sistema);
                        cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                        transaccion = conexion.BeginTransaction();
                        cls_DAL.ejecuta_sp(conexion, transaccion, "sp_manejo_usuario", true, parametros, ref mensaje_error, ref numero_error);
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
        #endregion

        #region Constructor
        public Login()
        {
            password = string.Empty;
            usuario_bd = string.Empty;
            password_db = string.Empty;
            fecha_vencimiento = new DateTime(1900, 01, 01);
            dias_habilita_clave = 0;
            ind_desactivado = 'N';
            ind_auditoria = 'N';
            ind_supervisor = 'N';
            multiples_conexiones = 'N';
            cambiar_password = 'N';
        }
        #endregion
    }
}