using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VG
{
    public class Variables
    {
        #region aplicacion
        public static string nombreAplicacion = "Sistema Toma de Desiciones";
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

        #region conexion
        public static string serverIpAddress = "192.168.32.230";
        public static string serverDataBase = "Sama_DSS";
        public static string connectionString;
        #endregion
    }
}
