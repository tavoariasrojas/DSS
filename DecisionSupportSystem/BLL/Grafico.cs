using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace BLL
{
    public class Grafico
    {
        #region Graficos Resumidos
        public void makeChartGeneroG(DataSet ds, Chart cht, String titulo)
        {
            cht.Titles.Add(titulo);
            cht.DataSource = ds.Tables[0];

            ChartArea chtArea = new ChartArea("area");
            cht.ChartAreas.Add(chtArea);
            cht.ChartAreas["area"].AxisY.Title = "Género";

            Series series1 = new Series();
            series1.XValueMember = "GENERO";
            series1.YValueMembers = "CANTIDAD";
            series1.Label = "#PERCENT{P2}";

            series1.LegendText = "#AXISLABEL";

            cht.Series.Add(series1);
            cht.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            cht.ChartAreas[0].Area3DStyle.Enable3D = true;
            cht.ChartAreas[0].Area3DStyle.Inclination = 40;
        }

        public void makeChartGeneroD(DataSet ds, Chart cht, String titulo)
        {
            cht.Titles.Add(titulo);
            cht.DataSource = ds.Tables[0];

            ChartArea chtArea = new ChartArea("area");
            cht.ChartAreas.Add(chtArea);
            cht.ChartAreas["area"].AxisY.Interval = 25;
            cht.ChartAreas["area"].AxisY.Title = "Cantidad de clientes";

            Series series1 = new Series();
            series1.XValueMember = "GENERO";
            series1.YValueMembers = "SAMACANT";
            series1.LegendText = "SAMA";
            series1.Label = "#VALY";
            //series1.Label = "#PERCENT{P2}";
            series1.CustomProperties = "PointWidth=0.8";

            Series series2 = new Series();
            series2.XValueMember = "GENERO";
            series2.YValueMembers = "CPGCANT";
            series2.LegendText = "CPG";
            series2.Label = "#VALY";
            series2.CustomProperties = "PointWidth=0.8";

            cht.Series.Add(series1);
            cht.Series.Add(series2);

            cht.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            cht.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        public void makeChartEdad(DataSet ds, Chart cht, String titulo)
        {
            cht.Titles.Add(titulo);
            cht.DataSource = ds.Tables[0];

            ChartArea chtArea = new ChartArea("area");
            cht.ChartAreas.Add(chtArea);
            /*Quitar líneas del gráfico*/
            //cht.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //cht.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            Series series1 = new Series();
            series1.XValueMember = "RANGO";
            series1.YValueMembers = "CANTIDAD";
            series1.LegendText = "RANGOS";
            cht.Series.Add(series1);
            cht.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            //cht.Series[0]["LineTension"] = "0.6";
        }

        public void makeChartTipoG(DataSet ds, Chart cht, String titulo)
        {
            cht.Titles.Add(titulo);
            cht.DataSource = ds.Tables[0];

            ChartArea chtArea = new ChartArea("area");
            cht.ChartAreas.Add(chtArea);

            Series series1 = new Series();
            series1.XValueMember = "GENERO";
            series1.YValueMembers = "CANTIDAD";
            series1.Label = "#PERCENT{P2}";

            series1.LegendText = "#AXISLABEL ";

            cht.Series.Add(series1);
            cht.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            cht.ChartAreas[0].Area3DStyle.Enable3D = true;
            cht.ChartAreas[0].Area3DStyle.Inclination = 40;
        }
        #endregion

        #region Grafico Clientes Mayor Volumen Inversion
        public void makeChartCteMayVOlInv(DataSet ds, Chart cht, String titulo, List<string> series)
        {
            cht.DataSource = ds.Tables[0];
            int cantidad = 0;

            cantidad = cht.ChartAreas.Count;
            if (cht.ChartAreas.Count > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    cht.ChartAreas.RemoveAt(0);
                }
            }

            cantidad = cht.Series.Count;
            if (cht.Series.Count > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    cht.Series.RemoveAt(0);
                }
            }

            cantidad = cht.Titles.Count;
            if (cht.Titles.Count > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    cht.Titles.RemoveAt(0);
                }
            }

            cht.Titles.Add(titulo);
            ChartArea chtArea = new ChartArea("area");
            chtArea.IsSameFontSizeForAllAxes = true;
            cht.ChartAreas.Add(chtArea);

            for (int i = 0; i < series.Count; i++)
            {
                cht.Series.Add(new Series(series[i]));
                cht.Series[i].XValueMember = "CODIGO";
                cht.Series[i].YValueMembers = series[i].ToString();
                cht.Series[i].CustomProperties = "PointWidth=0.8";
                cht.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
            chtArea.RecalculateAxesScale();
            chtArea.CursorX.IsUserSelectionEnabled = true;
        }
        #endregion
    }
}