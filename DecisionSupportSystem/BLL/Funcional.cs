using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class Funcional : Reporte
    {
        #region Variables privadas
        /// <summary>
        /// Variabkle privada
        /// <param name="ds">DataSet</param>
        DataSet ds;
        #endregion

        #region Métodos
        /// <summary>
        /// Método para cargar combo compañía
        /// <param name="cmb">Combo que contiene los años</param>
        /// <param name="usuario">Código del usuario</param>
        /// <param name="posicion">Indicador para mostrar la posicion inicial</param>
        /// </summary>
        /// 
        #region Carga Combo Compañía
        public void cargarCompania(ComboBox cmb, string usuario, string posicion)
        {
            try
            {
                cmb.DataSource = null;
                cmb.Items.Clear();
                ds = reporteCompania(usuario);
                if(ds.Tables[0].Rows.Count > 0)
                {
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
                
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion
        /// <summary>
        /// Método para cargar combo expresado
        /// <param name="cmb">Combo que contiene los años</param>
        /// <param name="posicion">Indicador para mostrar la posicion inicial</param>
        /// </summary>
        /// 
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
        /// <summary>
        /// Método para cargar combo tipo título
        /// <param name="cmb">Combo que contiene los años</param>
        /// <param name="posicion">Indicador para mostrar la posicion inicial</param>
        /// </summary>
        ///
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
        /// <summary>
        /// Método para cargar CheckedListBox
        /// <param name="clb">Nombre del CheckedListBox</param>
        /// </summary>
        ///
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
        /// <summary>
        /// Método para cargar combo de ejecutivo
        /// <param name="cmb">Nombre del combo</param>
        /// <param name="indicador">Indicador</param>
        /// <param name="ano_ini">Año inicial</param>
        /// <param name="ano_fin">Año final</param>
        /// <param name="asesor">Código de asesor</param>
        /// <param name="ejecutivo">Código de ejecutivo</param>
        /// <param name="posicón">Indicar posición</param>
        /// </summary>
        ///
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
                    if (index > 0)
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
        /// <summary>
        /// Método para cargar asesor
        /// </summary>
        /// <param name="cmb">Combo que contiene los años</param>
        /// <param name="posicion">Indicador para mostrar la posicion inicial</param>
        /// 
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

        #region Carga Combro Tipo Cliente
        /// <summary>
        /// Método para cargar tipo de cliente
        /// </summary>
        /// <param name="cmb">Combo que contiene los años</param>
        /// <param name="posicion">Indicador para mostrar la posicion inicial</param>
        /// 
        public void cargarTipoCliente(ComboBox cmb, string posicion)
        {
            try
            {
                Dictionary<string, string> cmbTmp = new Dictionary<string, string>();

                cmbTmp.Add("TODOS", "%");
                cmbTmp.Add("FÍSICO", "FISICO");
                cmbTmp.Add("JURÍDICO", "JURIDICO");

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

        #region Carga Combo Roles
        /// <summary>
        /// Método para cargar combo de roles
        /// </summary>
        /// <param name="cmb">Combo que contiene los años</param>
        /// <param name="posicion">Indicador para mostrar la posicion inicial</param>
        /// 
        public void cargarRoles(ComboBox cmb, string posicion)
        {
            try
            {
                cmb.DataSource = null;
                cmb.Items.Clear();
                ds = reporteRoles();
                Dictionary<string, string> cmbTmp = new Dictionary<string, string>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cmbTmp.Add(dr["nombre"].ToString(), dr["codigo"].ToString());
                }

                cmb.DataSource = new BindingSource(cmbTmp, null);
                cmb.DisplayMember = "Key";
                cmb.ValueMember = "Value";

                if (!string.IsNullOrEmpty(posicion))
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
            catch (Exception ex)
            {
                throw;
            }

        }
        #endregion

        #region Carga Combo Usuarios
        /// <summary>
        /// Método para cargar usuarios
        /// </summary>
        /// <param name="tipo">Tipo de cliente</param>
        /// <param name="cmb">Combo que contiene los años</param>
        /// <param name="posicion">Indicador para mostrar la posicion inicial</param>
        /// 
        public void cargarUsuarios(int tipo, ComboBox cmb, string posicion)
        {
            try
            {
                cmb.DataSource = null;
                cmb.Items.Clear();
                ds = reporteUsuarios(tipo);
                Dictionary<string, string> cmbTmp = new Dictionary<string, string>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cmbTmp.Add(dr["nombre"].ToString(), dr["codigo"].ToString());
                }

                cmb.DataSource = new BindingSource(cmbTmp, null);
                cmb.DisplayMember = "Key";
                cmb.ValueMember = "Value";

                if (!string.IsNullOrEmpty(posicion))
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
            catch (Exception ex)
            {
                throw;
            }

        }
        #endregion

        #endregion
    }
}
