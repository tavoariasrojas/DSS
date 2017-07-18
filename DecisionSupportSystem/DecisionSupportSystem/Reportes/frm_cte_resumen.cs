using System;
using System.Data;
using System.Windows.Forms;


namespace DecisionSupportSystem.Reportes
{
    public partial class frm_cte_resumen : Form
    {
        BLL.Reporte objReporte = new BLL.Reporte();
        BLL.Grafico objGrafico = new BLL.Grafico();

        public frm_cte_resumen()
        {
            InitializeComponent();
        }

        private void frm_cte_resumen_Load(object sender, EventArgs e)
        {
            DataSet dsg = objReporte.reporteCteGenero("G");
            objGrafico.makeChartGeneroG(dsg, cht_cte_genero, "Gráfico Distribución de Clientes por Género");

            DataSet dsd = objReporte.reporteCteGenero("D");
            objGrafico.makeChartGeneroD(dsd, cht_cte_genero_det, "Gráfico Distribución de Género por Asesor");

            DataSet dse = objReporte.reporteCteEdad();
            objGrafico.makeChartEdad(dse, cht_cte_edad, "Gráfico Distribución de Clientes por Edad");
        }
    }
}
