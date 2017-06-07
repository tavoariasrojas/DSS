using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Fecha
    {
        #region variables privadas
        SqlConnection conexion;
        string sql;
        string mensaje_error;
        int numero_error;
        DataSet ds;
        #endregion

        #region metodos
        public DateTime obtieneFechaServidor()
        {
            DateTime fecha = new DateTime(1900, 1, 1);

            conexion = cls_DAL.trae_conexion("SM", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al conectar con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sql = "SELECT GETDATE()";

                    ParamStruct[] parametros = new ParamStruct[0];
                    ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                    fecha = Convert.ToDateTime(ds.Tables[0].Rows[0][0].ToString());
                }
            }
            return fecha;
        }
        #endregion metodos
    }
}
