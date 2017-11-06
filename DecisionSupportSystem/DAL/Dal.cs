using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// Estructura para almacenar parámetros
    /// </summary>
    /// <param name="nombre_parametro">Almacena el nombre del parámetro</param>
    /// <param name="tipo_dato">Almacena el tipo de dato</param>
    /// <param name="valor_parametro">Valor que contiene el parámetro</param>
    /// 
    public struct ParamStruct
    {
        public string Nombre_Parametro;
        public SqlDbType Tipo_Dato;
        public Object Valor_Parametro;
    }

    public class cls_DAL
    {
        /// <summary>
        /// Inicializa un sqlconnection con una cadena de conexion si todo esta bien y null si fallo
        /// </summary>
        /// <param name="nombre_conexion">Nombre de la cadena conexion a buscar en el app.config</param>
        /// <param name="mensaje_error">Mensaje de error o confirmacion</param>
        /// <param name="numero_error">Número del error</param>
        /// <returns></returns>
        public static SqlConnection trae_conexion(string nombre_conexion, ref string mensaje_error, ref int numero_error)
        {
            SqlConnection cnn;
            try
            {
                string cadena_conexion = "";

                if (nombre_conexion.Equals("INI"))
                {
                    cadena_conexion = ConfigurationManager.ConnectionStrings[nombre_conexion].ToString();
                }
                else
                {
                    crear_string_conexion(nombre_conexion);
                    cadena_conexion = VG.Variables.connectionString;
                }

                cnn = new SqlConnection(cadena_conexion);
                mensaje_error = String.Empty;
                numero_error = 0;
                return cnn;
            }
            catch (NullReferenceException ex)
            {
                mensaje_error = "No se encontro el nombre de cadena de conexion: " + nombre_conexion + ". Información adicional: " + ex.Message;
                numero_error = -1;
                return null;
            }
            catch (ConfigurationException ex)
            {
                mensaje_error = "Error, información adicional: " + ex.Message;
                numero_error = -2;
                return null;
            }

        }
        /// <summary>
        /// Se crea string de conexión
        /// </summary>
        /// <param name="bd">Nombre de la base de datos</param>
        /// 
        public static void crear_string_conexion(string bd)
        {
            try
            {
                if (bd.Equals("SM"))
                {
                    VG.Variables.connectionString = "Data Source=" + VG.Variables.serverIpAddressSM + ";Initial Catalog=" + VG.Variables.serverDataBaseSM + ";User ID=" + VG.Variables.usuario_bd + ";Password=" + VG.Variables.password_db + "";
                }
                else
                {
                    VG.Variables.connectionString = "Data Source=" + VG.Variables.serverIpAddressDSS + ";Initial Catalog=" + VG.Variables.serverDataBaseDSS + ";User ID=" + VG.Variables.usuario_bd + ";Password=" + VG.Variables.password_db + "";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Realiza conexion contra la base de datos
        /// </summary>
        /// <param name="conexion">Variable estilo sqlconnection que contiene la cadena de conexion</param>
        /// <param name="mensaje_error">Mensaje de error o confirmacion</param>
        /// <param name="numero_error">Número de error</param>
        /// 
        public static void conectar(SqlConnection conexion, ref string mensaje_error, ref int numero_error)
        {
            try
            {
                conexion.Open();
                mensaje_error = "";
                numero_error = 0;
            }
            catch (SqlException ex)
            {
                mensaje_error = "Error de conexion hacia el servidor de base de datos, informacion adicional: " + ex.Message;
                numero_error = ex.Number;
            }
        }

        /// <summary>
        /// Realiza desconección contra la base de datos
        /// </summary>
        /// <param name="conexion">Variable estilo sqlconnection que contiene la cadena de conexion</param>
        /// <param name="mensaje_error">Mensaje de error o confirmacion</param>
        /// 
        public static void desconectar(SqlConnection conexion, ref string mensaje_error, ref int numero_error)
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    mensaje_error = "cerrada";
                    numero_error = 0;
                }
                else
                {
                    conexion.Close();
                    mensaje_error = "";
                }
            }
            catch (SqlException ex)
            {
                mensaje_error = "Error de conexion hacia el servidor de base de datos, informacion adicional: " + ex.Message;
                numero_error = ex.Number;
            }
        }
        /// <summary>
        /// realiza la carga de un dataset con parametros.
        /// </summary>
        /// <param name="sql">Sentencia sql o nombre del procedimiento almacenado</param>
        /// <param name="conexion">Variable donde recide la conexion</param>        
        /// <param name="numero_error">Número de error</param>
        /// <param name="mensaje_error">Mensaje de error</param>
        /// <param name="parametros">lista de parametros que necesita el procedimiento almacenado o sentencia SQL para su ejecución</param>        
        /// <param name="es_procedimiento_almacenado">Indica si se ejecuta un procedimiento almacenado</param>        
        ///
        public static void ejecuta_sp(SqlConnection conexion, SqlTransaction transaccion, string sql, bool es_procedimiento_almacenado, ParamStruct[] parametros, ref string mensaje_error, ref int numero_error)
        {
            SqlCommand sql_command;
            try
            {
                int resultado = 0;
                sql_command = new SqlCommand(sql, conexion, transaccion);
                if (es_procedimiento_almacenado)
                {
                    sql_command.CommandType = CommandType.StoredProcedure;
                }
                foreach (ParamStruct var in parametros)
                {
                    Agrega_parametro(ref sql_command, var.Nombre_Parametro, var.Valor_Parametro.ToString(), var.Tipo_Dato);
                }
                resultado = sql_command.ExecuteNonQuery();
                numero_error = 0;
                mensaje_error = "";
            }
            catch (SqlException ex)
            {
                numero_error = ex.Number;
                mensaje_error = ex.Message;
            }
        }
        /// <summary>
        /// realiza la carga de un dataset de solo lectura.
        /// </summary>
        /// <param name="sql">Sentencia sql o nombre del SP</param>
        /// <param name="conexion">Variable donde recide la conexion</param>        
        /// <param name="numero_error">Número de error</param>
        /// <param name="mensaje_error">Mensaje de error</param>
        /// <param name="es_procedimiento_almacenado">indica si se ejecuta un procedimiento almacenado</param>
        ///            
        public static DataSet ejecuta_dataset(SqlConnection conexion, string sql, bool es_procedimiento_almacenado, ref string mensaje_error, ref int numero_error)
        {
            SqlDataAdapter sql_data_adapter;
            DataSet dataset = new DataSet();
            try
            {
                sql_data_adapter = new SqlDataAdapter(sql, conexion);
                if (es_procedimiento_almacenado)
                {
                    sql_data_adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                }
                sql_data_adapter.Fill(dataset);
                numero_error = 0;
                mensaje_error = "";
                return dataset;
            }
            catch (SqlException ex)
            {
                numero_error = ex.Number;
                mensaje_error = ex.Message;
                return null;
            }
        }
        /// <summary>
        /// realiza la carga de un dataset con parametros.
        /// </summary>
        /// <param name="sql">Sentencia sql o nombre del procedimiento almacenado</param>
        /// <param name="conexion">Variable donde recide la conexion</param>        
        /// <param name="numero_error">Número de error</param>
        /// <param name="mensaje_error">Mensaje de error</param>
        /// <param name="parametros">Lista de parametros que necesita el procedimiento almacenado o sentencia SQL para su ejecución</param>        
        /// <param name="es_procedimiento_almacenado">indica si se ejecuta un procedimiento almacenado</param>        
        ///
        public static DataSet ejecuta_dataset(SqlConnection conexion, string sql, bool es_procedimiento_almacenado, ParamStruct[] parametros, ref string mensaje_error, ref int numero_error)
        {
            SqlDataAdapter sql_data_adapter;
            DataSet dataset = new DataSet();
            try
            {
                sql_data_adapter = new SqlDataAdapter(sql, conexion);
                if (es_procedimiento_almacenado)
                {
                    sql_data_adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                }
                foreach (ParamStruct var in parametros)
                {
                    Agrega_parametro(ref sql_data_adapter, var.Nombre_Parametro, var.Valor_Parametro.ToString(), var.Tipo_Dato);
                }
                sql_data_adapter.Fill(dataset);
                numero_error = 0;
                mensaje_error = "";
                return dataset;
            }
            catch (SqlException ex)
            {
                numero_error = ex.Number;
                mensaje_error = ex.Message;
                return null;
            }
        }
        /// <summary>
        /// Realiza la lectura de una sentencia SQL contra base de datos
        /// </summary>
        /// <param name="sql_data_reader">Comando de recuperación de datos</param>
        /// <param name="sql_command">Comando sql</param>
        /// <param name="mensaje_error">Mensaje de erro</param>
        /// <param name="numero_error">Número de error</param>
        public static void ejecuta_datareader(ref SqlDataReader sql_data_reader, SqlCommand sql_command, ref string mensaje_error, ref int numero_error)
        {
            try
            {
                sql_data_reader = sql_command.ExecuteReader(CommandBehavior.CloseConnection);
                numero_error = 0;
                mensaje_error = "";
            }
            catch (SqlException ex)
            {
                numero_error = ex.Number;
                mensaje_error = ex.Message;
            }
        }
        /// <summary>
        /// Ejecuta una sentecia de tipo SQL contra la base de datos
        /// </summary>
        /// <param name="conexion">Variable donde recide la conexion</param>
        /// <param name="sql">Sentencia sql o nombre del procedimiento almacenado</param>
        /// <param name="es_procedimiento_almacenado">Indica si se ejecuta un procedimiento almacenado</param>
        /// <param name="mensaje_error">Mensaje de error</param>
        /// <param name="numero_error">Número de error</param>        
        public static void ejecuta_sqlcommand(SqlConnection conexion, string sql, bool es_procedimiento_almacenado, ref string mensaje_error, ref int numero_error)
        {
            SqlCommand sql_command;
            try
            {
                sql_command = new SqlCommand(sql, conexion);
                if (es_procedimiento_almacenado)
                {
                    sql_command.CommandType = CommandType.StoredProcedure;
                }
                int resultado = 0;
                resultado = sql_command.ExecuteNonQuery();
                mensaje_error = "";
                numero_error = 0;
            }
            catch (SqlException ex)
            {
                mensaje_error = "Error al ejecutar la sentencia sql, información adicional: " + ex.Message;
                numero_error = ex.Number;
            }
        }
        /// <summary>
        /// Ejecuta una sentecia de tipo SQL contra la base de datos, método sobre cargado
        /// </summary>
        /// <param name="conexion">Variable donde recide la conexion</param>
        /// <param name="sql">Sentencia sql o nombre del procedimiento almacenado</param>
        /// <param name="es_procedimiento_almacenado">Indica si se ejecuta un procedimiento almacenado</param>
        /// <param name="parametros">Lista de parametros que necesita el procedimiento almacenado o sentencia SQL para su ejecucion</param>
        /// <param name="mensaje_error">Mensaje de error</param>
        /// <param name="numero_error">Número de error</param>        
        public static void ejecuta_sqlcommand(SqlConnection conexion, string sql, bool es_procedimiento_almacenado, ParamStruct[] parametros, ref string mensaje_error, ref int numero_error)
        {
            SqlCommand sql_command;
            try
            {
                //int resultado = 0;
                sql_command = new SqlCommand(sql, conexion);
                if (es_procedimiento_almacenado)
                {
                    sql_command.CommandType = CommandType.StoredProcedure;
                }
                foreach (ParamStruct var in parametros)
                {
                    Agrega_parametro(ref sql_command, var.Nombre_Parametro, var.Valor_Parametro.ToString(), var.Tipo_Dato);
                }
                //resultado = sql_command.ExecuteNonQuery();
                mensaje_error = "";
                numero_error = 0;
            }
            catch (SqlException ex)
            {
                mensaje_error = "Error al ejecutar la sentencia sql, informacion adicional: " + ex.Message;
                numero_error = ex.Number;
            }
        }

        public static void ejecuta_sqlcommand(ref SqlTransaction transaccion, SqlConnection conexion, string sql, bool es_procedimiento_almacenado, ParamStruct[] parametros, ref string mensaje_error, ref int numero_error)
        {
            SqlCommand sql_command;
            try
            {
                //int resultado = 0;
                sql_command = new SqlCommand(sql, conexion);
                sql_command.Transaction = transaccion;
                if (es_procedimiento_almacenado)
                {
                    sql_command.CommandType = CommandType.StoredProcedure;
                }
                foreach (ParamStruct var in parametros)
                {

                    Agrega_parametro(ref sql_command, var.Nombre_Parametro, var.Valor_Parametro, var.Tipo_Dato);

                }
                //resultado = sql_command.ExecuteNonQuery();
                mensaje_error = "";
                numero_error = 0;
            }
            catch (SqlException ex)
            {
                mensaje_error = "Error al ejecutar la sentencia sql, informacion adicional: " + ex.Message;
                numero_error = ex.Number;
            }
        }
        /// <summary>
        /// Agrega un parametro a un procedimiento almacenado cuando se realiza el llamado a la base de datos, método sobrecargado
        /// </summary>
        /// <param name="sql_comand">Comando sql</param>
        /// <param name="nombre_parametro">Nombre del parametro</param>
        /// <param name="valor parametro">Valor que contiene el parámetro</param>
        /// <param name="tipo_dato">Tipo de datos</param>
        public static void Agrega_parametro(ref SqlCommand sql_command, string nombre_parametro, string valor_parametro, SqlDbType tipo_dato)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = nombre_parametro;
            param.Value = valor_parametro;
            param.SqlDbType = tipo_dato;
            sql_command.Parameters.Add(param);
        }

        public static void Agrega_parametro(ref SqlCommand sql_command, string nombre_parametro, object valor_parametro, SqlDbType tipo_dato)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = nombre_parametro;
            param.Value = valor_parametro;
            param.SqlDbType = tipo_dato;
            sql_command.Parameters.Add(param);
        }

        public static void Agrega_parametro(ref SqlDataAdapter sql_data_adapter, string nombre_parametro, string valor_parametro, SqlDbType tipo_dato)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = nombre_parametro;
            param.Value = valor_parametro;
            param.SqlDbType = tipo_dato;
            sql_data_adapter.SelectCommand.Parameters.Add(param);
        }
        /// <summary>
        /// Estructura pra almacenar parametros
        /// </summary>
        /// <param name="parametros">Estructura que contiene los parametros</param>
        /// <param name="posicion">Número de posición del parámetro</param>
        /// <param name="nombre_parametro">Nombre del parámetro</param>
        /// <param name="tipo_dato_parametro">Tipo de datos</param>
        /// /// <param name="valor_parametro">Valor que contiene el parámetro</param>
        public static void agregar_datos_estructura_parametros(ref ParamStruct[] parametros, int posicion, string nombre_parametro, SqlDbType tipo_dato_parametro, object valor_parametro)
        {
            parametros[posicion].Nombre_Parametro = nombre_parametro.ToString();
            parametros[posicion].Tipo_Dato = tipo_dato_parametro;
            parametros[posicion].Valor_Parametro = valor_parametro;
        }
    }
}
