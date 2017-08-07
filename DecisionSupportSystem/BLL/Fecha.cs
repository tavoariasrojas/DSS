using DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;

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

        public object[] ItemObject { get; private set; }
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

        public void cargarAnos(ComboBox cmb, string posicion)
        {
            try
            {
                int anoInicio = 0, anoActual = 0;
                anoActual = obtieneFechaServidor().Year;

                for (anoInicio = 2000; anoInicio <= anoActual; anoInicio++)
                {
                    cmb.Items.Add(anoInicio.ToString());
                }
                if (posicion.Equals("min"))
                {
                    cmb.SelectedIndex = 0;
                }
                if (posicion.Equals("max"))
                {
                    cmb.SelectedIndex = cmb.Items.Count - 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void cargarMes(ComboBox cmb, string posicion)
        {
            try
            {
                Dictionary<string, int> cmbMes = new Dictionary<string, int>();

                cmbMes.Add("Enero", 1);
                cmbMes.Add("Febrero", 2);
                cmbMes.Add("Marzo", 3);
                cmbMes.Add("Abril", 4);
                cmbMes.Add("Mayo", 5);
                cmbMes.Add("Junio", 6);
                cmbMes.Add("Julio", 7);
                cmbMes.Add("Agosto", 8);
                cmbMes.Add("Septiempre", 9);
                cmbMes.Add("Octubre", 10);
                cmbMes.Add("Noviembre", 11);
                cmbMes.Add("Diciembre", 12);

                cmb.DataSource = new BindingSource(cmbMes, null);
                cmb.DisplayMember = "Key";
                cmb.ValueMember = "Value";

                if (posicion.Equals("min"))
                {
                    cmb.SelectedIndex = 0;
                }
                if (posicion.Equals("max"))
                {
                    cmb.SelectedIndex = cmb.Items.Count - 1;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void cargarSemana(ComboBox cmb, int year, string posicion)
        {
            try
            {

                CultureInfo ci = CultureInfo.CurrentCulture;
                DateTime date = new DateTime(year, 1, 1);
                int semanas = ci.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

                for (int i = 1; i <= semanas; i++)
                {
                    cmb.Items.Add(i.ToString());
                }

                if (posicion.Equals("min"))
                {
                    cmb.SelectedIndex = 0;
                }
                if (posicion.Equals("max"))
                {
                    cmb.SelectedIndex = cmb.Items.Count - 1;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion metodos
    }
}
