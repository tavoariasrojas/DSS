using System;
using System.Windows.Forms;
using BLL;
using System.Data;

namespace DecisionSupportSystem.Reportes
{
    public partial class frm_cte_nuevos : Form
    {
        BLL.Consulta obj_consulta = new Consulta();
        BLL.Fecha obj_fecha = new Fecha();

        public frm_cte_nuevos()
        {
            InitializeComponent();
        }

        private void frm_clientes_nuevos_Load(object sender, EventArgs e)
        {
        }

        private void rb_ano_Click(object sender, EventArgs e)
        {
            if (rb_ano.Checked)
            {
                cmb_ano_desde.Enabled = true;
                cmb_ano_hasta.Enabled = true;
                obj_fecha.cargarAnos(cmb_ano_desde, "min");
                obj_fecha.cargarAnos(cmb_ano_hasta, "max");

                cmb_mes_desde.Enabled = false;
                cmb_mes_hasta.Enabled = false;
                cmb_mes_desde.Items.Clear();
                cmb_mes_hasta.Items.Clear();

                cmb_semana_desde.Enabled = false;
                cmb_semana_hasta.Enabled = false;
                cmb_semana_desde.Items.Clear();
                cmb_semana_hasta.Items.Clear();
            }
        }

        private void rb_mes_Click(object sender, EventArgs e)
        {
            if (rb_mes.Checked)
            {
                cmb_ano_desde.Enabled = true;
                cmb_ano_hasta.Enabled = true;
                obj_fecha.cargarAnos(cmb_ano_desde, "min");
                obj_fecha.cargarAnos(cmb_ano_hasta, "max");

                cmb_mes_desde.Enabled = true;
                cmb_mes_hasta.Enabled = true;
                obj_fecha.cargarMes(cmb_mes_desde, "min");
                obj_fecha.cargarMes(cmb_mes_hasta, "max");

                cmb_semana_desde.Enabled = false;
                cmb_semana_hasta.Enabled = false;
                cmb_semana_desde.Items.Clear();
                cmb_semana_hasta.Items.Clear();
            }
        }

        private void rb_semana_Click(object sender, EventArgs e)
        {
            if (rb_semana.Checked)
            {
                cmb_ano_desde.Enabled = true;
                cmb_ano_hasta.Enabled = true;
                obj_fecha.cargarAnos(cmb_ano_desde, "min");
                obj_fecha.cargarAnos(cmb_ano_hasta, "max");

                cmb_semana_desde.Enabled = true;
                cmb_semana_hasta.Enabled = true;
                obj_fecha.cargarSemana(cmb_semana_desde, Int32.Parse(cmb_ano_desde.SelectedItem.ToString()), "min");
                obj_fecha.cargarSemana(cmb_semana_hasta, Int32.Parse(cmb_ano_hasta.SelectedItem.ToString()), "max");

                cmb_mes_desde.Enabled = false;
                cmb_mes_hasta.Enabled = false;
                cmb_mes_desde.Items.Clear();
                cmb_mes_hasta.Items.Clear();
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (rb_ano.Checked)
           {
                int ano_desde = int.Parse(cmb_ano_desde.SelectedItem.ToString());
                int ano_hasta = int.Parse(cmb_ano_hasta.SelectedItem.ToString());

                obj_consulta.sql_query = "SELECT ano AÑO, "+
                                                "CAST((SUM(sama) * 1. / (SUM(sama) + SUM(cfs)) * 100) AS decimal) SAMA, " +
                                                "CAST((SUM(cfs) * 1. / (SUM(sama) + SUM(cfs)) * 100) AS decimal) CPG " +
                                            "FROM " +
                                                "(SELECT DATEPART(YEAR, fecha_insercion)ano, " +
                                                    "CASE " +
                                                        "WHEN asesor_actual = 'SAMA' THEN COUNT(*) " +
                                                        "ELSE 0 " +
                                                    "END sama, " +
                                                    "CASE " +
                                                        "WHEN asesor_actual = 'CFS' THEN COUNT(*) " +
                                                        "ELSE 0 " +
                                                    "END cfs " +
                                                "FROM cliente " +
                                                "WHERE DATEPART(yy, fecha_insercion) BETWEEN "+ano_desde+" AND "+ano_hasta+" " +
                                                "AND estado = 'A' " +
                                                "GROUP BY DATEPART(YEAR, fecha_insercion), asesor_actual " +
                                                ")tabla " +
                                            "GROUP BY ano";

                //dgv_reporte.DataSource = obj_consulta.reporteClientesNuevos().Tables[0];
                cargarGrafico(obj_consulta.reporteClientesNuevos());

                //chart_cliente.DataSource = obj_consulta.reporteClientesNuevos().Tables[0]
    }

    /*   string ver, agrupado;

       obj_consulta.fecha_ini = dtp_fec_desde.Value;
       obj_consulta.fecha_fin = dtp_fec_hasta.Value;

       int anos = 0, meses = 0;
       ver = string.Empty;
       agrupado = string.Empty;

       anos = obj_consulta.fecha_fin.Year - obj_consulta.fecha_ini.Year;
       meses = obj_consulta.fecha_fin.Month - obj_consulta.fecha_ini.Month;

       if (rb_ano.Checked)
       {
           if(anos > 0)
           {
               ver = "A";
           }
           else
           {
               MessageBox.Show("Debe existir mas de un año de diferencia entre las fechas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               return;
           }
       }

       if (rb_mes.Checked)
       {
           if(meses >= 0 && anos <= 0)
           {
               ver = "M";
           }
           else
           {
               MessageBox.Show("Las fechas no puede pasar de un año.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               return;
           }
       }

       if (rb_asesor.Checked)
       {
           agrupado = "A";
       }
       if (rb_ejecutivo.Checked)
       {
           agrupado = "E";
       }

       if (ver.Equals("A") && agrupado.Equals("A"))
       {
           obj_consulta.sql_query = "SELECT YEAR(fecha_insercion) Año, " +
                                               "asesor Asesor, " +
                                               "COUNT(*) Cantidad " +
                                       "FROM cliente " +
                                       "WHERE estado = 'A' " +
                                       "AND fecha_insercion BETWEEN @fec_ini AND @fec_fin " +
                                       "GROUP BY YEAR(fecha_insercion), asesor " +
                                       "ORDER BY 1, 2";
       }

       if (ver.Equals("A") && agrupado.Equals("E"))
       {
           obj_consulta.sql_query = "SELECT YEAR(fecha_insercion) Año, " +
                                               "ejecutivo Ejecutivo, " +
                                               "COUNT(*) Cantidad " +
                                       "FROM cliente " +
                                       "WHERE estado = 'A' " +
                                       "AND fecha_insercion BETWEEN @fec_ini AND @fec_fin " +
                                       "GROUP BY YEAR(fecha_insercion), ejecutivo " +
                                       "ORDER BY 1, 2";
       }

       if (ver.Equals("M") && agrupado.Equals("A"))
       {
           obj_consulta.sql_query = "SELECT RTRIM(CAST( MONTH(fecha_insercion) AS  char)) +' - '+ DATENAME(MONTH, fecha_insercion) Mes, " +
                                               "asesor Asesor, " +
                                               "COUNT(*) Cantidad " +
                                       "FROM cliente " +
                                       "WHERE estado = 'A' " +
                                       "AND fecha_insercion BETWEEN @fec_ini AND @fec_fin " +
                                       "GROUP BY RTRIM(CAST( MONTH(fecha_insercion) AS  char)) +' - '+ DATENAME(MONTH, fecha_insercion), asesor " +
                                       "ORDER BY RTRIM(CAST( MONTH(fecha_insercion) AS  char)) +' - '+ DATENAME(MONTH, fecha_insercion)";
       }

       if (ver.Equals("M") && agrupado.Equals("E"))
       {
           obj_consulta.sql_query = "SELECT RTRIM(CAST( MONTH(fecha_insercion) AS  char)) +' - '+ DATENAME(MONTH, fecha_insercion) Mes, " +
                                           "ejecutivo Ejecutivo, " +
                                           "COUNT(*)Cantidad " +
                                   "FROM cliente " +
                                   "WHERE estado = 'A' " +
                                   "AND fecha_insercion BETWEEN @fec_ini AND @fec_fin  " +
                                   "GROUP BY RTRIM(CAST( MONTH(fecha_insercion) AS  char)) +' - '+ DATENAME(MONTH, fecha_insercion), ejecutivo " +
                                   "ORDER BY RTRIM(CAST( MONTH(fecha_insercion) AS  char)) +' - '+ DATENAME(MONTH, fecha_insercion)";
       }

       dgv_reporte.DataSource = obj_consulta.reporteClientesNuevos().Tables[0];
       chart_cliente.DataSource = obj_consulta.reporteClientesNuevos().Tables[0];*/
}

        public void cargarGrafico(DataSet ds)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.DataSource = ds.Tables[0];
            chart1.Titles.Add("Clientes nuevos por años");

            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            series1.XValueMember = "AÑO";
            series1.YValueMembers = "SAMA";
            series1.LegendText = "Sama";
            //series1.Label = "#PERCENT{P2}";

            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            series2.XValueMember = "AÑO";
            series2.YValueMembers = "CPG";
            series2.LegendText = "Cpg";
            //series2.Label = "#PERCENT{P2}";

            chart1.Series.Add(series1);
            chart1.Series.Add(series2);

        }

    }
}
