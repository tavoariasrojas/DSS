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
        BLL.Fecha obj_fecha = new Fecha();
        BLL.Reporte objReporte = new BLL.Reporte();
        BLL.Funcional objFuncinal = new BLL.Funcional();
        BLL.Grafico objGrafico = new BLL.Grafico();
        BLL.GraficoLiveCharts objGraficoLC = new BLL.GraficoLiveCharts();

        public frm_cte_mayor_vol()
        {
            InitializeComponent();
        }
        private void frm_cte_mayor_vol_Load(object sender, EventArgs e)
        {
            obj_fecha.cargarAnos(cmb_ano_desde, "min");
            obj_fecha.cargarAnos(cmb_ano_hasta, "max");

            obj_fecha.cargarMes(cmb_mes_desde, "min");
            obj_fecha.cargarMes(cmb_mes_hasta, "max");

            cmb_tipo_cliente.SelectedIndex = 0;

            objFuncinal.cargarExpresado(cmb_expresado, "min");
            cmb_expresado.SelectedIndex = 0;
        }

        public static List<string> f_series(string tipo, int ano_desde, int mes_desde, int ano_hasta, int mes_hasta){
            string[] meses = new string[12] {"ENE-", "FEB-", "MAR-", "ABR-", "MAY-", "JUN-", "JUL-", "AGO-", "SEP-", "OCT-", "NOV-", "DIC-" };
            List<string> list = new List<string>();

            if (tipo == "A")
            {
                for (int i = ano_desde; i <= ano_hasta; i++)
                {
                    list.Add(Convert.ToString(i));
                }
            }

            if (tipo == "M")
            {
                int a = mes_desde;

                for (int i = ano_desde; i <= ano_hasta; i++)
                {
                    if (ano_desde < ano_hasta) {
                        while (a < 13)
                        {
                            list.Add(meses[a-1]+ Convert.ToString(i));
                            if (a == 13)
                            {
                                a = 1;
                            }
                            else
                            {
                              a += 1;
                            }
                            
                        }
                    }

                    if (ano_desde == ano_hasta)
                    {
                        for (int b = mes_desde; b <= mes_hasta; b++)
                        {
                            list.Add(meses[b-1] + Convert.ToString(i));
                        }
                    }
                }
            }
            return list;
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

            if (rb_anual.Checked)
            {
                List<string> series = new List<string>();

                string tipo_reporte = "A";

                string tipo_cliente = cmb_tipo_cliente.Text.ToString();
                if (tipo_cliente == "Todos")
                {
                    tipo_cliente = "%";
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
                decimal top = nud_top.Value;
                decimal expresado = Convert.ToDecimal(cmb_expresado.SelectedValue.ToString());

                DataSet dsg = objReporte.reporteMayVolInv(tipo_reporte, tipo_cliente, tipo_moneda, mto_com, ano_desde, 0, ano_hasta, 0, top, expresado);
                series = f_series(tipo_reporte, ano_desde, 0, ano_hasta, 0);
                // objGrafico.makeChartCteMayVolInv(dsg, chart, "Título reporte", series);

                objGraficoLC.ds = dsg;
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
                dgv_info.DataSource = dsg.Tables[0];
            }

            if (rb_mensual.Checked)
            {
                List<string> series = new List<string>();

                string tipo_reporte = "M";

                string tipo_cliente = cmb_tipo_cliente.Text.ToString();
                if (tipo_cliente == "Todos")
                {
                    tipo_cliente = "%";
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
                int mes_desde = Int32.Parse(cmb_mes_desde.SelectedValue.ToString());

                int ano_hasta = Int32.Parse(cmb_ano_hasta.Text.ToString());
                int mes_hasta = Int32.Parse(cmb_mes_hasta.SelectedValue.ToString());

                decimal top = nud_top.Value;
                decimal expresado = Convert.ToDecimal(cmb_expresado.SelectedValue.ToString());

                DataSet dsg = objReporte.reporteMayVolInv(tipo_reporte, tipo_cliente, tipo_moneda, mto_com, ano_desde, mes_desde, ano_hasta, mes_hasta, top, expresado);
                series = f_series(tipo_reporte, ano_desde, mes_desde, ano_hasta, mes_hasta);
                //objGrafico.makeChartCteMayVolInv(dsg, chart, "Título reporte", series);

                objGraficoLC.ds = dsg;
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
                    Title = "CÓDIGO DE CLIENTES",
                    Labels = objGraficoLC.llenarEje(),
                    Separator = new Separator
                    {
                        Step = 1
                    }
                });

                mainCartesianChart.AxisY.Add(new Axis
                {
                    Title = "MONTO EXPRESADO EN",
                    LabelFormatter = value => value.ToString("N")
                });

                dgv_info.DataSource = null;
                dgv_info.DataSource = dsg.Tables[0];
            }
        }
    }
}
