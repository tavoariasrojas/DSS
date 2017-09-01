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
        BLL.Fecha obj_fecha = new Fecha();
        BLL.Reporte objReporte = new BLL.Reporte();
        BLL.Funcional objFuncinal = new BLL.Funcional();
        BLL.Grafico objGrafico = new BLL.Grafico();
        BLL.GraficoLiveCharts objGraficoLC = new BLL.GraficoLiveCharts();

        public frm_prod_mayor_rentd_com()
        {
            InitializeComponent();
        }

        private void frm_prod_mayor_rentd_com_Load(object sender, EventArgs e)
        {
            obj_fecha.cargarAnos(cmb_ano_desde, "min");
            obj_fecha.cargarAnos(cmb_ano_hasta, "max");

            obj_fecha.cargarMes(cmb_mes_desde, "min");
            obj_fecha.cargarMes(cmb_mes_hasta, "max");

            objFuncinal.cargarTipoTitulo(chk_box_list_instrumento);
            //objFuncinal.cargarTipoTitulo(cmb_instrumento, "min");
        }

        public static List<string> f_series(string tipo, int ano_desde, int mes_desde, int ano_hasta, int mes_hasta)
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

                string tipo_instrumento = string.Empty;
                foreach(string elemento in chk_box_list_instrumento.CheckedItems)
                {
                    tipo_instrumento += elemento.ToString()+",";
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

                if (tipo_instrumento.ToUpper() == "TODOS")
                {
                    tipo_instrumento = "%";
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
                decimal top = nud_top.Value;

                DataSet dsg = objReporte.reporteProdRend(tipo_reporte, tipo_instrumento, tipo_moneda, ano_desde, 0, ano_hasta, 0, top);
                series = f_series(tipo_reporte, ano_desde, 0, ano_hasta, 0);
                objGraficoLC.ds = dsg;
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
                dgv_info.DataSource = dsg.Tables[0];
            }

            if (rb_mensual.Checked)
            {
                List<string> series = new List<string>();

                string tipo_reporte = "M";

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
                    tipo_instrumento = tipo_instrumento.Substring(0, tipo_instrumento.Length - 2);
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

                /*string mto_com = string.Empty;
                if (rb_transado.Checked)
                {
                    mto_com = "transado";
                }

                if (rb_comision.Checked)
                {
                    mto_com = "comision";
                }*/

                int ano_desde = Int32.Parse(cmb_ano_desde.Text.ToString());
                int mes_desde = Int32.Parse(cmb_mes_desde.SelectedValue.ToString());

                int ano_hasta = Int32.Parse(cmb_ano_hasta.Text.ToString());
                int mes_hasta = Int32.Parse(cmb_mes_hasta.SelectedValue.ToString());

                decimal top = nud_top.Value;

                DataSet dsg = objReporte.reporteProdRend(tipo_reporte, tipo_instrumento, tipo_moneda, ano_desde, mes_desde, ano_hasta, mes_hasta, top);
                series = f_series(tipo_reporte, ano_desde, mes_desde, ano_hasta, mes_hasta);

                objGraficoLC.ds = dsg;
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
