using BLL;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DecisionSupportSystem.Reportes
{
    public partial class frm_cte_nuevos : Form
    {
        Fecha objFecha = new Fecha();
        Reporte objReporte = new Reporte();
        Funciones objFunciones = new Funciones();
        Funcional objFuncional = new Funcional();
        Grafico objGrafico = new Grafico();
        GraficoLiveCharts objGraficoLC = new GraficoLiveCharts();

        public frm_cte_nuevos()
        {
            InitializeComponent();
        }

        private void frm_cte_nuevos_Load(object sender, EventArgs e)
        {
            objFecha.cargarAnos(cmb_ano_desde, "min");
            objFecha.cargarAnos(cmb_ano_hasta, "max");

            objFecha.cargarMes(cmb_mes_desde, "min");
            objFecha.cargarMes(cmb_mes_hasta, "max");

            objFuncional.cargarAsesor(cmb_asesor, "min");
            objFuncional.cargarEjecutivos(cmb_ejecutivo, 2, Convert.ToInt32(cmb_ano_desde.SelectedItem.ToString()), Convert.ToInt32(cmb_ano_hasta.SelectedItem.ToString()), cmb_asesor.SelectedValue.ToString(), "%", "min");
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

        private void cmb_ano_desde_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_ano_desde.Items.Count > 0 && cmb_ano_hasta.Items.Count > 0 && cmb_ejecutivo.Items.Count > 0)
            {
                objFuncional.cargarEjecutivos(cmb_ejecutivo, 2, Convert.ToInt32(cmb_ano_desde.SelectedItem.ToString()), Convert.ToInt32(cmb_ano_hasta.SelectedItem.ToString()), cmb_asesor.SelectedValue.ToString(), cmb_ejecutivo.Text, "min");
            }
        }

        private void cmb_ano_hasta_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_ano_desde.Items.Count > 0 && cmb_ano_hasta.Items.Count > 0 && cmb_ejecutivo.Items.Count > 0)
            {
                objFuncional.cargarEjecutivos(cmb_ejecutivo, 2, Convert.ToInt32(cmb_ano_desde.SelectedItem.ToString()), Convert.ToInt32(cmb_ano_hasta.SelectedItem.ToString()), cmb_asesor.SelectedValue.ToString(), cmb_ejecutivo.Text, "min");
            }
        }

        private void cmb_asesor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_ano_desde.Items.Count > 0 && cmb_ano_hasta.Items.Count > 0 && cmb_ejecutivo.Items.Count > 0)
            {
                objFuncional.cargarEjecutivos(cmb_ejecutivo, 2, Convert.ToInt32(cmb_ano_desde.SelectedItem.ToString()), Convert.ToInt32(cmb_ano_hasta.SelectedItem.ToString()), cmb_asesor.SelectedValue.ToString(), cmb_ejecutivo.Text, "min");
            }
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

            string titulo_eje_x = String.Empty;
            string asesor = cmb_asesor.SelectedValue.ToString();
            if (asesor.Equals("%"))
            {
                titulo_eje_x = "NOMBRE DE ASESOR";
            }
            else
            {
                titulo_eje_x = "NOMBRE DE EJECUTIVO";
            }

            string ejecutivo = cmb_ejecutivo.SelectedValue.ToString();
            if (ejecutivo.Equals("%"))
            {
                titulo_eje_x = "NOMBRE DE EJECUTIVOS";
            }
            else
            {
                titulo_eje_x = "NOMBRE DE EJECUTIVO";
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

            DataSet ds = objReporte.reporteCtesNuev(tipo_reporte, asesor, ejecutivo, ano_desde, mes_desde, ano_hasta, mes_hasta);
            List<string> series = new List<string>();
            series = objFunciones.generarSeries(tipo_reporte, ano_desde, mes_desde, ano_hasta, mes_hasta);
            //objGrafico.makeChartCteMayVolInv(dsg, chart, "Título reporte", series);

            objGraficoLC.ds = ds;
            objGraficoLC.lista = series;
            objGraficoLC.limpiarGrafico(mainCartesianChart);
            objGraficoLC.campo = "EJECUTIVO";


            for (int i = 0; i < series.Count; i++)
            {
                mainCartesianChart.Series.Add(new ColumnSeries
                {
                    Title = series[i].ToString(),
                    Values = objGraficoLC.llenarChartValues(series[i].ToString()),
                    Width = 1,
                    DataLabels = true,
                    LabelPoint = point => point.Y.ToString()
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
                },
                LabelsRotation = 15
            });

            mainCartesianChart.AxisY.Add(new Axis
            {
                //Title = "MONTO " + mto_detalle + " EN " + moneda + "[" + cmb_expresado.Text.ToUpper() + "]",
                LabelFormatter = value => value.ToString()

            });

            dgv_info.DataSource = null;
            dgv_info.DataSource = ds.Tables[0];
        }
    }
}
