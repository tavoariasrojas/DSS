using System;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace BLL
{
    public class Grafico
    {
        public void makeChartGeneroG(DataSet ds, Chart cht, String titulo)
        {
            cht.Titles.Add(titulo);
            cht.DataSource = ds.Tables[0];

            ChartArea chtArea = new ChartArea("area");
            cht.ChartAreas.Add(chtArea);

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

            Series series1 = new Series();
            series1.XValueMember = "GENERO";
            series1.YValueMembers = "SAMA";
            series1.LegendText = "SAMA";
            series1.Label = "#PERCENT{P2}";

            Series series2 = new Series();
            series2.XValueMember = "GENERO";
            series2.YValueMembers = "CPG";
            series2.LegendText = "CPG";
            series2.Label = "#PERCENT{P2}";

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

            Series series1 = new Series();
            series1.XValueMember = "RANGO";
            series1.YValueMembers = "CANTIDAD";
            series1.Label = "#PERCENT{P2}";
            series1.LegendText = "#AXISLABEL";
            series1.CustomProperties = "PointWidth=0.5";

            cht.Series.Add(series1);
            cht.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
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

            series1.LegendText = "#AXISLABEL";

            cht.Series.Add(series1);
            cht.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            cht.ChartAreas[0].Area3DStyle.Enable3D = true;
            cht.ChartAreas[0].Area3DStyle.Inclination = 40;
        }
    }
}
