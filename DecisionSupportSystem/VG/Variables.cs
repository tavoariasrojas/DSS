using System;
using System.Windows.Forms;

namespace VG
{
    public class Variables
    {
        /// <summary>
        /// Variables globales de la aplicación
        /// </summary>
        /// <param name="codigoAplicacion">Código que identifica el sistema</param>
        /// <param name="nombreAplicacion">Nombre de la aplicación</param>
        /// <param name="codigoCompania">Código de la compañía</param>
        #region aplicacion
        public static string codigoAplicacion = "TD";
        public static string nombreAplicacion = "Sistema Toma de Desiciones";
        public static string codigoCompania = "001";
        #endregion
        /// <summary>
        /// Variables globales del usuario
        /// </summary>
        /// <param name="password">Clave del usuario</param>
        /// <param name="usuario_bd">Usuario de la base de datos</param>
        /// <param name="password_db">Clave del usuario en base de datos</param>
        /// <param name="fecha_vencimiento">Fecha de vencimiento de la clave</param>
        /// <param name="dias_habilita_clave">Cantidad de días que para el cambio de usuario</param>
        /// <param name="ind_desactivado">Indicador de usuario activo</param>
        /// <param name="ind_auditoria">Indicador de auditoría</param>
        /// <param name="ind_supervisor">Indicador de supervisor</param>
        /// <param name="multiples_conexiones">Indicador de múltiples conexiones</param>
        /// <param name="cambiar_password">Indicador para realizar cambio de clave</param>
        #region usuario
        public static string password;
        public static string usuario_bd;
        public static string password_db;
        public static DateTime fecha_vencimiento;
        public static int dias_habilita_clave;
        public static char ind_desactivado;
        public static char ind_auditoria;
        public static char ind_supervisor;
        public static char multiples_conexiones;
        public static char cambiar_password;
        #endregion
        /// <summary>
        /// Variables globales de ventana
        /// </summary>
        /// <param name="mdiForm">Almacena el nombre del Form principal del sistema</param>
        #region ventana
        public static Form mdiForm;
        #endregion
        /// <summary>
        /// Variables globales del conexiones
        /// </summary>
        /// <param name="connectionString">Almacena el string de conexión</param>
        #region ConexionString
        public static string connectionString;
        #endregion
        /// <summary>
        /// Variables globales del conexiones
        /// </summary>
        /// <param name="serverIpAddressSM">Dirección IP del servidor</param>
        /// <param name="serverDataBaseSM">Nombre de la base de datos</param>
        #region conexion SAMA
        public static string serverIpAddressSM = "192.168.32.230";
        public static string serverDataBaseSM = "SM";
        #endregion
        /// <summary>
        /// Variables globales del conexiones
        /// </summary>
        /// <param name="serverIpAddressSM">Dirección IP del servidor</param>
        /// <param name="serverDataBaseSM">Nombre de la base de datos</param>
        #region conexion DSS
        public static string serverIpAddressDSS = "192.168.32.230";
        public static string serverDataBaseDSS = "Sama_DSS";
        #endregion
    }
}
