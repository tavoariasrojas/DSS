using BLL;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DecisionSupportSystem.Reportes
{
    public partial class frm_cte_info_general : Form
    {
        Reporte objReporte = new Reporte();
        Funciones objFunciones = new Funciones();
        int PushOut = 0;

        public frm_cte_info_general()
        {
            InitializeComponent();
        }

        private void frm_cte_info_general_Load(object sender, EventArgs e)
        {
            cargarTotalTipo();
            cargarTipoSama();
            cargarTipoCfs();

            cargarTotalGenero();
            cargarGeneroSama();
            cargarGeneroCfs();
        }

        private void cargarTotalTipo()
        {
            DataSet ds = objReporte.reporteCteInfo("T", "A", "");
            Dictionary<string, Int32> dic = objFunciones.convertirDStoDictionary(ds);
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y);

            foreach (var item in dic)
            {
                pieChartTotalTipo.Series.Add(
                    new PieSeries
                    {
                        Title = item.Key,
                        Values = new ChartValues<double> { item.Value },
                        PushOut = PushOut,
                        DataLabels = true,
                        LabelPoint = labelPoint
                    }
                );
            }
            pieChartTotalTipo.LegendLocation = LegendLocation.Bottom;
        }

        private void cargarTipoSama()
        {
            DataSet ds = objReporte.reporteCteInfo("T", "A", "SAMA");
            Dictionary<string, Int32> dic = objFunciones.convertirDStoDictionary(ds);
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y);

            foreach (var item in dic)
            {
                pieChartCteTipoSama.Series.Add(
                    new PieSeries
                    {
                        Title = item.Key,
                        Values = new ChartValues<double> { item.Value },
                        PushOut = PushOut,
                        DataLabels = true,
                        LabelPoint = labelPoint
                    }
                );
            }
            pieChartCteTipoSama.LegendLocation = LegendLocation.Bottom;
        }

        private void cargarTipoCfs()
        {
            DataSet ds = objReporte.reporteCteInfo("T", "A", "CFS");
            Dictionary<string, Int32> dic = objFunciones.convertirDStoDictionary(ds);
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y);

            foreach (var item in dic)
            {
                pieChartCteTipoCfs.Series.Add(
                    new PieSeries
                    {
                        Title = item.Key,
                        Values = new ChartValues<double> { item.Value },
                        PushOut = PushOut,
                        DataLabels = true,
                        LabelPoint = labelPoint
                    }
                );
            }
            pieChartCteTipoCfs.LegendLocation = LegendLocation.Bottom;
        }

        private void cargarTotalGenero()
        {
            DataSet ds = objReporte.reporteCteInfo("G", "A", "");
            Dictionary<string, Int32> dic = objFunciones.convertirDStoDictionary(ds);
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y);

            foreach (var item in dic)
            {
                pieChartTotalGenero.Series.Add(
                    new PieSeries
                    {
                        Title = item.Key,
                        Values = new ChartValues<double> { item.Value },
                        PushOut = PushOut,
                        DataLabels = true,
                        LabelPoint = labelPoint
                    }
                );
            }
            //pieChartTotalGenero.InnerRadius = 100;
            pieChartTotalGenero.LegendLocation = LegendLocation.Bottom;
        }

        private void cargarGeneroSama()
        {
            DataSet ds = objReporte.reporteCteInfo("G", "A", "SAMA");
            Dictionary<string, Int32> dic = objFunciones.convertirDStoDictionary(ds);
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y);

            foreach (var item in dic)
            {
                pieChartCteGeneroSama.Series.Add(
                    new PieSeries
                    {
                        Title = item.Key,
                        Values = new ChartValues<double> { item.Value },
                        PushOut = PushOut,
                        DataLabels = true,
                        LabelPoint = labelPoint
                    }
                );
            }
            //pieChartCteGeneroSama.InnerRadius = 100;
            pieChartCteGeneroSama.LegendLocation = LegendLocation.Bottom;
        }

        private void cargarGeneroCfs()
        {
            DataSet ds = objReporte.reporteCteInfo("G", "A", "CFS");
            Dictionary<string, Int32> dic = objFunciones.convertirDStoDictionary(ds);
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y);

            foreach (var item in dic)
            {
                pieChartCteGeneroCfs.Series.Add(
                    new PieSeries
                    {
                        Title = item.Key,
                        Values = new ChartValues<double> { item.Value },
                        PushOut = PushOut,
                        DataLabels = true,
                        LabelPoint = labelPoint
                    }
                );
            }
            //pieChartCteGeneroCfs.InnerRadius = 100;
            pieChartCteGeneroCfs.LegendLocation = LegendLocation.Bottom;
        }
    }
}
