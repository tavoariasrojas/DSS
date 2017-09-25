using System;
using System.Windows.Forms;

namespace VG
{
    public class Variables
    {
        #region aplicacion
        public static string codigoAplicacion = "TD";
        public static string nombreAplicacion = "Sistema Toma de Desiciones";
        public static string codigoCompania = "001";
        #endregion

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

        #region ventana
        public static Form mdiForm;
        #endregion

        #region Conexion
        public static string connectionString;
        #endregion

        #region conexion DSS
        public static string serverIpAddressSM = "192.168.32.230";
        public static string serverDataBaseSM = "SM";
        #endregion

        #region conexion DSS
        public static string serverIpAddressDSS = "192.168.32.230";
        public static string serverDataBaseDSS = "Sama_DSS";
        #endregion

        #region Paths
        //string menuIco = 
        #endregion
    }
}
