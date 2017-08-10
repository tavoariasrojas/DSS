using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BLL
{
    public class Funcional
    {
        public void cargarExpresado(ComboBox cmb, string posicion)
        {
            try
            {
                Dictionary<string, int> cmbExpresado = new Dictionary<string, int>();

                cmbExpresado.Add("Unidades", 1);
                cmbExpresado.Add("Decenas", 10);
                cmbExpresado.Add("Cientos", 100);
                cmbExpresado.Add("Miles", 1000);
                cmbExpresado.Add("Millones", 1000000);

                cmb.DataSource = new BindingSource(cmbExpresado, null);
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
    }
}
