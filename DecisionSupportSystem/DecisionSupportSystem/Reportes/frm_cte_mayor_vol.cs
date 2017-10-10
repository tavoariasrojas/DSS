using System;
using System.Windows.Forms;
using BLL;
using System.Data;
using System.Collections.Generic;
using LiveCharts.Wpf;

namespace DecisionSupportSystem.Reportes
{
    public partial class frm_cte_mayor_vol : Form
    {
        Fecha objFecha = new Fecha();
        Funciones objFunciones = new Funciones();
        Funcional objFuncional = new Funcional();
        Reporte objReporte = new Reporte();
        Grafico objGrafico = new Grafico();
        GraficoLiveCharts objGraficoLC = new GraficoLiveCharts();

        public frm_cte_mayor_vol()
        {
            InitializeComponent();
        }
        private void frm_cte_mayor_vol_Load(object sender, EventArgs e)
        {
            objFecha.cargarAnos(cmb_ano_desde, "min");
            objFecha.cargarAnos(cmb_ano_hasta, "max");

            objFecha.cargarMes(cmb_mes_desde, "min");
            objFecha.cargarMes(cmb_mes_hasta, "max");

            objFuncional.cargarTipoCliente(cmb_tipo_cliente, "min");
            //cmb_tipo_cliente.SelectedIndex = 0;

            objFuncional.cargarExpresado(cmb_expresado, "min");
        }

        private void rb_anual_CheckedChanged(object sender, EventArgs e)
        {
            cmb_mes_desde.Enabled = false;
            cmb_mes_hasta.Enabled = false;
        }

        private void rb_mensual_CheckedChanged(object sender, EventArgs e)
        {
            cmb_mes_desde.Enabled = true;
            cmb_mes_hasta.Enabled = true;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(cmb_ano_desde.Text.ToString()) > Int32.Parse(cmb_ano_hasta.Text.ToString()))
            {
                MessageBox.Show("El año de desde no puede ser mayor al año hasta", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Int32.Parse(cmb_ano_desde.Text.ToString()) == Int32.Parse(cmb_ano_hasta.Text.ToString()) && Int32.Parse(cmb_mes_desde.SelectedValue.ToString()) > Int32.Parse(cmb_mes_hasta.SelectedValue.ToString()))
            {
                MessageBox.Show("El mes de desde no puede ser mayor al mes hasta cuando tienen el mismo año", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tipo_reporte = String.Empty;
            if (rb_anual.Checked)
            {
                tipo_reporte = "A";
            }
            if (rb_mensual.Checked)
            {
                tipo_reporte = "M";
            }

            string tipo_cliente = cmb_tipo_cliente.SelectedValue.ToString();
            string titulo_eje_x = String.Empty;
            if (tipo_cliente.ToUpper().Equals("%"))
            {
                titulo_eje_x = "CÓDIGO DE CLIENTES";
            }
            else
            {
                titulo_eje_x = "CÓDIGO DE CLIENTES "+ tipo_cliente.ToUpper();
            }

            string tipo_moneda = string.Empty;
            string moneda = string.Empty;
            if (rb_col.Checked)
            {
                tipo_moneda = "COL";
                moneda = "COLONES";
            }

            if (rb_dol.Checked)
            {
                tipo_moneda = "DOL";
                moneda = "DÓLARES";
            }

            string mto_com = string.Empty;
            if (rb_transado.Checked)
            {
                mto_com = "transado";
            }
            if (rb_comision.Checked)
            {
                mto_com = "comision";
            }

            int ano_desde = Int32.Parse(cmb_ano_desde.Text.ToString());
            int ano_hasta = Int32.Parse(cmb_ano_hasta.Text.ToString());
            int mes_desde = 0;
            int mes_hasta = 0;
            if (tipo_reporte.Equals("M"))
            {
                mes_desde = Int32.Parse(cmb_mes_desde.SelectedValue.ToString());
                mes_hasta = Int32.Parse(cmb_mes_hasta.SelectedValue.ToString());
            }
            decimal top = nud_top.Value;
            decimal expresado = Convert.ToDecimal(cmb_expresado.SelectedValue.ToString());

            DataSet ds = objReporte.reporteMayVolInv(tipo_reporte, tipo_cliente, tipo_moneda, mto_com, ano_desde, mes_desde, ano_hasta, mes_hasta, top, expresado);
            List<string> series = new List<string>();
            series = objFunciones.generarSeries(tipo_reporte, ano_desde, mes_desde, ano_hasta, mes_hasta);
            // objGrafico.makeChartCteMayVolInv(dsg, chart, "Título reporte", series);

            objGraficoLC.ds = ds;
            objGraficoLC.lista = series;
            objGraficoLC.limpiarGrafico(mainCartesianChart);
            objGraficoLC.campo = "CODIGO";


            for (int i = 0; i < series.Count; i++)
            {
                mainCartesianChart.Series.Add(new ColumnSeries
                {
                    Title = series[i].ToString(),
                    Values = objGraficoLC.llenarChartValues(series[i].ToString()),
                    Width = 1,
                    DataLabels = true,
                    LabelPoint = point => point.Y.ToString("N")
                });
            }

            mainCartesianChart.AxisX.Add(new Axis
            {
                Title = titulo_eje_x,
                Labels = objGraficoLC.llenarEje(),
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            });

            mainCartesianChart.AxisY.Add(new Axis
            {
                Title = "MONTO EXPRESADO EN "+ moneda + " [" + cmb_expresado.Text.ToUpper() + "]",
                LabelFormatter = value => value.ToString("N")

            });

            dgv_info.DataSource = null;
            dgv_info.DataSource = ds.Tables[0];
            objFunciones.formatearDataGrid(dgv_info);
        }
    }
}
