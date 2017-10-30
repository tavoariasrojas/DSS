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

            return 0;
        }

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
                    sql = "SELECT sg_usu_nombre_completo " +
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