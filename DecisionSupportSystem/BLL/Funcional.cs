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

                cmbTmp.Add("UNIDADES", 1);
                /*cmbTmp.Add("Decenas", 10);
                cmbTmp.Add("Cientos", 100);*/
                cmbTmp.Add("MILES", 1000);
                cmbTmp.Add("MILLONES", 1000000);

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

                cmbTmp.Add("TODOS", "%");
                cmbTmp.Add("ACCIONES", "ACCIONES");
                cmbTmp.Add("BONOS - TÍTULOS", "BONOS - TÍTULOS");
                cmbTmp.Add("MERCADO LIQUIDEZ", "MERCADO LIQUIDEZ");
                cmbTmp.Add("PARTICIPACIONES", "PARTICIPACIONES");
                cmbTmp.Add("RECOMPRAS", "RECOMPRAS");

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
        public void cargarTipoTitulo(CheckedListBox clb)
        {
            try
            {
                clb.Items.Add("ACCIONES", true);
                clb.Items.Add("BONOS - TÍTULOS", true);
                clb.Items.Add("MERCADO LIQUIDEZ", true);
                clb.Items.Add("PARTICIPACIONES", true);
                clb.Items.Add("RECOMPRAS", true);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Carga Combo Ejecutivo
        public void cargarEjecutivos(ComboBox cmb, int indicador, int ano_ini, int ano_fin, string asesor, string ejecutivo, string posicion)
        {
            try
            {
                cmb.DataSource = null;
                cmb.Items.Clear();
                int index = 0;
                ds = reporteEjecutivos(indicador, ano_ini, ano_fin, asesor);
                Dictionary<string, string> cmbTmp = new Dictionary<string, string>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cmbTmp.Add(dr["nombre"].ToString(), dr["codigo"].ToString());
                }

                cmb.DataSource = new BindingSource(cmbTmp, null);
                cmb.DisplayMember = "Key";
                cmb.ValueMember = "Value";

                if (ejecutivo.Equals("%"))
                {
                    if (posicion.Equals("min"))
                    {
                        cmb.SelectedIndex = 0;
                    }
                    if (posicion.Equals("max"))
                    {
                        cmb.SelectedIndex = cmb.Items.Count - 1;
                    }
                }
                else
                {
                    index = cmb.FindStringExact(ejecutivo);
                    if(index > 0)
                    {
                        cmb.SelectedIndex = index;
                    }
                    else
                    {
                        if (posicion.Equals("min"))
                        {
                            cmb.SelectedIndex = 0;
                        }
                        if (posicion.Equals("max"))
                        {
                            cmb.SelectedIndex = cmb.Items.Count - 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
        #endregion

        #region Carga Combro Asesor
        public void cargarAsesor(ComboBox cmb, string posicion)
        {
            try
            {
                Dictionary<string, string> cmbTmp = new Dictionary<string, string>();

                cmbTmp.Add("TODOS", "%");
                cmbTmp.Add("SAMA", "SAMA");
                cmbTmp.Add("CFS", "CFS");

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
