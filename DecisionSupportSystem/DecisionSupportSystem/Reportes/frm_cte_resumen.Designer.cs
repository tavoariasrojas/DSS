namespace DecisionSupportSystem.Reportes
{
    partial class frm_cte_resumen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cht_cte_genero = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cht_cte_genero_det = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cht_cte_edad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cht_cte_tipo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cht_cte_tipo_det = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cht_cte_genero)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_cte_genero_det)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_cte_edad)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_cte_tipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_cte_tipo_det)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cht_cte_genero
            // 
            this.cht_cte_genero.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.cht_cte_genero.Legends.Add(legend1);
            this.cht_cte_genero.Location = new System.Drawing.Point(0, 0);
            this.cht_cte_genero.Name = "cht_cte_genero";
            this.cht_cte_genero.Size = new System.Drawing.Size(444, 161);
            this.cht_cte_genero.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 386);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gráficos por género";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cht_cte_genero);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cht_cte_genero_det);
            this.splitContainer1.Size = new System.Drawing.Size(444, 367);
            this.splitContainer1.SplitterDistance = 161;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // cht_cte_genero_det
            // 
            this.cht_cte_genero_det.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.cht_cte_genero_det.Legends.Add(legend2);
            this.cht_cte_genero_det.Location = new System.Drawing.Point(0, 0);
            this.cht_cte_genero_det.Name = "cht_cte_genero_det";
            this.cht_cte_genero_det.Size = new System.Drawing.Size(444, 205);
            this.cht_cte_genero_det.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cht_cte_edad);
            this.groupBox2.Location = new System.Drawing.Point(5, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1255, 220);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gráfico por edad";
            // 
            // cht_cte_edad
            // 
            this.cht_cte_edad.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.cht_cte_edad.Legends.Add(legend3);
            this.cht_cte_edad.Location = new System.Drawing.Point(3, 16);
            this.cht_cte_edad.Name = "cht_cte_edad";
            this.cht_cte_edad.Size = new System.Drawing.Size(1249, 201);
            this.cht_cte_edad.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.splitContainer2);
            this.groupBox3.Location = new System.Drawing.Point(856, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 386);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráficos por tipo";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cht_cte_tipo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.cht_cte_tipo_det);
            this.splitContainer2.Size = new System.Drawing.Size(398, 367);
            this.splitContainer2.SplitterDistance = 161;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // cht_cte_tipo
            // 
            this.cht_cte_tipo.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.cht_cte_tipo.Legends.Add(legend4);
            this.cht_cte_tipo.Location = new System.Drawing.Point(0, 0);
            this.cht_cte_tipo.Name = "cht_cte_tipo";
            this.cht_cte_tipo.Size = new System.Drawing.Size(398, 161);
            this.cht_cte_tipo.TabIndex = 0;
            // 
            // cht_cte_tipo_det
            // 
            this.cht_cte_tipo_det.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.cht_cte_tipo_det.Legends.Add(legend5);
            this.cht_cte_tipo_det.Location = new System.Drawing.Point(0, 0);
            this.cht_cte_tipo_det.Name = "cht_cte_tipo_det";
            this.cht_cte_tipo_det.Size = new System.Drawing.Size(398, 205);
            this.cht_cte_tipo_det.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(458, 130);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.SystemColors.ActiveBorder;
            series1.EmptyPointStyle.LabelBorderWidth = 10;
            series1.EmptyPointStyle.MarkerBorderWidth = 20;
            series1.EmptyPointStyle.MarkerSize = 10;
            series1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.MarkerStep = 5;
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.Empty;
            series1.ShadowOffset = 1;
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(392, 217);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // frm_cte_resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 612);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_cte_resumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen de información de clientes";
            this.Load += new System.EventHandler(this.frm_cte_resumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cht_cte_genero)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cht_cte_genero_det)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cht_cte_edad)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cht_cte_tipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_cte_tipo_det)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cht_cte_genero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_cte_genero_det;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_cte_edad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_cte_tipo;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_cte_tipo_det;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}