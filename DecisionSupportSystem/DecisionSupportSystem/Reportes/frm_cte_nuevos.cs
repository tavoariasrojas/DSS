using System;
using System.Windows.Forms;
using BLL;

namespace DecisionSupportSystem.Reportes
{
    public partial class frm_cte_nuevos : Form
    {
        BLL.Consulta obj_consulta = new BLL.Consulta();
        public frm_cte_nuevos()
        {
            InitializeComponent();
        }

        private void frm_clientes_nuevos_Load(object sender, EventArgs e)
        {
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            string ver, agrupado;

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
            chart_cliente.DataSource = obj_consulta.reporteClientesNuevos().Tables[0];
        }
    }
}
