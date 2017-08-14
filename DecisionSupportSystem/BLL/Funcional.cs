using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BLL
{
    public class Funcional : Reporte
    {
        #region Variables privadas
        DataSet ds;
        #endregion

        #region Métodos
        #region Carga Combro Expresado
        public void cargarExpresado(ComboBox cmb, string posicion)
        {
            try
            {
                Dictionary<string, int> cmbTmp = new Dictionary<string, int>();

                cmbTmp.Add("Unidades", 1);
                /*cmbTmp.Add("Decenas", 10);
                cmbTmp.Add("Cientos", 100);*/
                cmbTmp.Add("Miles", 1000);
                cmbTmp.Add("Millones", 1000000);

                cmb.DataSource = new BindingSource(cmbTmp, null);
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
        #endregion

        #region Carga Combo Tipo Título
        public void cargarTipoTitulo(ComboBox cmb, string posicion)
        {
            try
            {
                Dictionary<string, string> cmbTmp = new Dictionary<string, string>();

                cmbTmp.Add("Todos", "%");
                cmbTmp.Add("Acciones", "ACCIONES");
                cmbTmp.Add("Bonos - Títulos", "BONOS - TÍTULOS");
                cmbTmp.Add("Mercado Liquidez", "MERCADO LIQUIDEZ");
                cmbTmp.Add("Participaciones", "PARTICIPACIONES");
                cmbTmp.Add("Recompras", "RECOMPRAS");

                cmb.DataSource = new BindingSource(cmbTmp, null);
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
        #endregion

        #region Carga Combo Ejecutivo
        public void cargarEjecutivos(ComboBox cmb, int ano_ini, int ano_fin, string posicion)
        {
            try
            {
                ds = ReporteEjecutivos(ano_ini, ano_fin);
                Dictionary<string, string> cmbTmp = new Dictionary<string, string>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cmbTmp.Add(dr["nombre"].ToString(), dr["codigo"].ToString());
                }

                cmb.DataSource = new BindingSource(cmbTmp, null);
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
        #endregion

        #endregion
    }
}
