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

            cargarTotalEdad();
            cargarEdadSama();
            cargarEdadCfs();

            cargarTotalCivil();
            cargarCivilSama();
            cargarCivilCfs();
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
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Stroke = System.Windows.Media.Brushes.Transparent
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
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Stroke = System.Windows.Media.Brushes.Transparent
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
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Stroke = System.Windows.Media.Brushes.Transparent
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
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Stroke = System.Windows.Media.Brushes.Transparent
                    }
                );
            }
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
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Stroke = System.Windows.Media.Brushes.Transparent
                    }
                );
            }
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
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Stroke = System.Windows.Media.Brushes.Transparent
                    }
                );
            }
            pieChartCteGeneroCfs.LegendLocation = LegendLocation.Bottom;
        }

        private void cargarTotalEdad()
        {
            DataSet ds = objReporte.reporteCteInfo("E", "A", "");
            Dictionary<string, Int32> dic = objFunciones.convertirDStoDictionary(ds);
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y);

            foreach (var item in dic)
            {
                pieChartTotalEdad.Series.Add(
                    new PieSeries
                    {
                        Title = item.Key,
                        Values = new ChartValues<double> { item.Value },
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Stroke = System.Windows.Media.Brushes.Transparent
                    }
                );
            }
            pieChartTotalEdad.LegendLocation = LegendLocation.Right;
        }

        private void cargarEdadSama()
        {
            DataSet ds = objReporte.reporteCteInfo("E", "A", "SAMA");
            Dictionary<string, Int32> dic = objFunciones.convertirDStoDictionary(ds);
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y);

            foreach (var item in dic)
            {
                pieChartCteEdadSama.Series.Add(
                    new PieSeries
                    {
                        Title = item.Key,
                        Values = new ChartValues<double> { item.Value },
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Stroke = System.Windows.Media.Brushes.Transparent
                    }
                );
            }
            pieChartCteEdadSama.LegendLocation = LegendLocation.Right;
        }

        private void cargarEdadCfs()
        {
            DataSet ds = objReporte.reporteCteInfo("E", "A", "CFS");
            Dictionary<string, Int32> dic = objFunciones.convertirDStoDictionary(ds);
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y);

            foreach (var item in dic)
            {
                pieChartCteEdadCfs.Series.Add(
                    new PieSeries
                    {
                        Title = item.Key,
                        Values = new ChartValues<double> { item.Value },
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Stroke = System.Windows.Media.Brushes.Transparent
                    }
                );
            }
            pieChartCteEdadCfs.LegendLocation = LegendLocation.Right;
        }

        private void cargarTotalCivil()
        {
            DataSet ds = objReporte.reporteCteInfo("C", "A", "");
            Dictionary<string, Int32> dic = objFunciones.convertirDStoDictionary(ds);
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y);

            foreach (var item in dic)
            {
                pieChartTotalCivil.Series.Add(
                    new PieSeries
                    {
                        Title = item.Key,
                        Values = new ChartValues<double> { item.Value },
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Stroke = System.Windows.Media.Brushes.Transparent
                    }
                );
            }
            pieChartTotalCivil.LegendLocation = LegendLocation.Right;
        }

        private void cargarCivilSama()
        {
            DataSet ds = objReporte.reporteCteInfo("C", "A", "SAMA");
            Dictionary<string, Int32> dic = objFunciones.convertirDStoDictionary(ds);
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y);

            foreach (var item in dic)
            {
                pieChartCteCivilSama.Series.Add(
                    new PieSeries
                    {
                        Title = item.Key,
                        Values = new ChartValues<double> { item.Value },
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Stroke = System.Windows.Media.Brushes.Transparent
                    }
                );
            }
            pieChartCteCivilSama.LegendLocation = LegendLocation.Right;
        }

        private void cargarCivilCfs()
        {
            DataSet ds = objReporte.reporteCteInfo("C", "A", "CFS");
            Dictionary<string, Int32> dic = objFunciones.convertirDStoDictionary(ds);
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y);

            foreach (var item in dic)
            {
                pieChartCteCivilCfs.Series.Add(
                    new PieSeries
                    {
                        Title = item.Key,
                        Values = new ChartValues<double> { item.Value },
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Stroke = System.Windows.Media.Brushes.Transparent
                    }
                );
            }
            pieChartCteCivilCfs.LegendLocation = LegendLocation.Right;
        }
    }
}
