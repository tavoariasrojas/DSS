using BLL;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DecisionSupportSystem.Reportes
{
    public partial class frm_prod_mayor_rentd_com : Form
    {
        Fecha objFecha = new Fecha();
        Funciones objFunciones = new Funciones();
        Funcional objFuncional = new Funcional();
        Reporte objReporte = new Reporte();
        Grafico objGrafico = new Grafico();
        GraficoLiveCharts objGraficoLC = new GraficoLiveCharts();

        public frm_prod_mayor_rentd_com()
        {
            InitializeComponent();
        }

        private void frm_prod_mayor_rentd_com_Load(object sender, EventArgs e)
        {
            objFecha.cargarAnos(cmb_ano_desde, "min");
            objFecha.cargarAnos(cmb_ano_hasta, "max");

            objFecha.cargarMes(cmb_mes_desde, "min");
            objFecha.cargarMes(cmb_mes_hasta, "max");

            objFuncional.cargarTipoTitulo(chk_box_list_instrumento);
            //objFuncinal.cargarTipoTitulo(cmb_instrumento, "min");
        }

        /*public static List<string> f_series(string tipo, int ano_desde, int mes_desde, int ano_hasta, int mes_hasta)
        {
            string[] meses = new string[12] { "ENE-", "FEB-", "MAR-", "ABR-", "MAY-", "JUN-", "JUL-", "AGO-", "SEP-", "OCT-", "NOV-", "DIC-" };

            List<string> list = new List<string>();

            if (tipo.Equals("A"))
            {
                while (ano_desde <= ano_hasta)
                {
                    list.Add(Convert.ToString(ano_desde));
                    ano_desde += 1;
                }
            }

            if (tipo.Equals("M"))
            {
                DateTime fecha_inicial = new DateTime(ano_desde, mes_desde, 1);
                DateTime fecha_hasta = new DateTime(ano_hasta, mes_hasta, 1);

                while (fecha_inicial <= fecha_hasta)
                {
                    list.Add(meses[fecha_inicial.Month - 1] + Convert.ToString(fecha_inicial.Year));
                    fecha_inicial = fecha_inicial.AddMonths(1);
                }
            }
            return list;
        }*/

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

            string tipo_instrumento = string.Empty;
            foreach (string elemento in chk_box_list_instrumento.CheckedItems)
            {
                tipo_instrumento += elemento.ToString() + ",";
            }

            if (string.IsNullOrEmpty(tipo_instrumento))
            {
                MessageBox.Show("Debe seleccionar al menos 1 tipo de instrumento", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                tipo_instrumento = tipo_instrumento.Substring(0, tipo_instrumento.Length - 1);
            }

            string tipo_moneda = string.Empty;
            if (rb_col.Checked)
            {
                tipo_moneda = "COL";
            }

            if (rb_dol.Checked)
            {
                tipo_moneda = "DOL";
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
            decimal top = 1;

            DataSet ds = objReporte.reporteProdRend(tipo_reporte, tipo_instrumento, tipo_moneda, ano_desde, mes_desde, ano_hasta, mes_hasta, top);
            List<string> series = new List<string>();
            series = objFunciones.generarSeries(tipo_reporte, ano_desde, mes_desde, ano_hasta, mes_hasta);

            objGraficoLC.ds = ds;
            objGraficoLC.lista = series;
            objGraficoLC.limpiarGrafico(mainCartesianChart);
            objGraficoLC.campo = "TIPO";

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
                Title = "CÓDIGO DE CLIENTES",
                Labels = objGraficoLC.llenarEje(),
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            });

            mainCartesianChart.AxisY.Add(new Axis
            {
                Title = "MONTO EXPRESADO EN",
                LabelFormatter = value => value.ToString("N")
            });

            dgv_info.DataSource = null;
            dgv_info.DataSource = ds.Tables[0];
        }
    }
}
