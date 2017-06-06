using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace BLL
{
    public class Login
    {
        SupportOCX objSupport = new SupportOCX();

        #region parametros
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
        SqlConnection conexion;
        string sql;
        string mensaje_error;
        int numero_error;
        DataSet ds;
        #endregion

        #region Métodos
        public Boolean usuarioExiste(string usuario)
        {
            int cantidad = 0;
            conexion = cls_DAL.trae_conexion("SM", ref mensaje_error, ref numero_error);
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
                    sql = sql = "SELECT COUNT(*) cantidad " +
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

        public Login obtieneDatosUsuario(string usuario)
        {
            string info_encryp = string.Empty;
            string info_desencryp = string.Empty;
            Login login = new Login();

            conexion = cls_DAL.trae_conexion("SM", ref mensaje_error, ref numero_error);
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
                    info_encryp = ds.Tables[0].Rows[0][0].ToString();

                    if (!string.IsNullOrEmpty(info_encryp))
                    {
                        objSupport.encrypted = info_encryp;
                        objSupport.passkey = usuario;
                        int resultado = objSupport.Unencrypt();
                        info_desencryp = objSupport.unencrypted;
                    }
                }
            }
            return login;
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