namespace DecisionSupportSystem.Reportes
{
    partial class frm_cte_info_general
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cte_info_general));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pieChartCteTipoCfs = new LiveCharts.WinForms.PieChart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pieChartCteTipoSama = new LiveCharts.WinForms.PieChart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pieChartTotalTipo = new LiveCharts.WinForms.PieChart();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pieChartTotalGenero = new LiveCharts.WinForms.PieChart();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pieChartCteGeneroCfs = new LiveCharts.WinForms.PieChart();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pieChartCteGeneroSama = new LiveCharts.WinForms.PieChart();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(3, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 404);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente por tipo";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.pieChartCteTipoCfs);
            this.groupBox3.Location = new System.Drawing.Point(5, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 181);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Distribución de clientes [CFS]";
            // 
            // pieChartCteTipoCfs
            // 
            this.pieChartCteTipoCfs.BackColor = System.Drawing.Color.White;
            this.pieChartCteTipoCfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartCteTipoCfs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieChartCteTipoCfs.Location = new System.Drawing.Point(3, 16);
            this.pieChartCteTipoCfs.Name = "pieChartCteTipoCfs";
            this.pieChartCteTipoCfs.Size = new System.Drawing.Size(274, 162);
            this.pieChartCteTipoCfs.TabIndex = 0;
            this.pieChartCteTipoCfs.Text = "pieChart1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.pieChartCteTipoSama);
            this.groupBox2.Location = new System.Drawing.Point(5, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 181);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distribución de clientes [SAMA]";
            // 
            // pieChartCteTipoSama
            // 
            this.pieChartCteTipoSama.BackColor = System.Drawing.Color.White;
            this.pieChartCteTipoSama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartCteTipoSama.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieChartCteTipoSama.Location = new System.Drawing.Point(3, 16);
            this.pieChartCteTipoSama.Name = "pieChartCteTipoSama";
            this.pieChartCteTipoSama.Size = new System.Drawing.Size(274, 162);
            this.pieChartCteTipoSama.TabIndex = 0;
            this.pieChartCteTipoSama.Text = "pieChart1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pieChartTotalTipo);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distribución de clientes por tipo";
            // 
            // pieChartTotalTipo
            // 
            this.pieChartTotalTipo.BackColor = System.Drawing.Color.Transparent;
            this.pieChartTotalTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartTotalTipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pieChartTotalTipo.Location = new System.Drawing.Point(3, 16);
            this.pieChartTotalTipo.Name = "pieChartTotalTipo";
            this.pieChartTotalTipo.Size = new System.Drawing.Size(274, 162);
            this.pieChartTotalTipo.TabIndex = 0;
            this.pieChartTotalTipo.Text = "pieChart1";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1284, 200);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Información general";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.pieChartTotalGenero);
            this.groupBox6.Location = new System.Drawing.Point(303, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(280, 181);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Distribución de clientes por género";
            // 
            // pieChartTotalGenero
            // 
            this.pieChartTotalGenero.BackColor = System.Drawing.Color.Transparent;
            this.pieChartTotalGenero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartTotalGenero.Location = new System.Drawing.Point(3, 16);
            this.pieChartTotalGenero.Name = "pieChartTotalGenero";
            this.pieChartTotalGenero.Size = new System.Drawing.Size(274, 162);
            this.pieChartTotalGenero.TabIndex = 0;
            this.pieChartTotalGenero.Text = "pieChart1";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Location = new System.Drawing.Point(298, 206);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(291, 404);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Cliente por género";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.White;
            this.groupBox8.Controls.Add(this.pieChartCteGeneroCfs);
            this.groupBox8.Location = new System.Drawing.Point(5, 221);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(280, 181);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Distribución de clientes [CFS]";
            // 
            // pieChartCteGeneroCfs
            // 
            this.pieChartCteGeneroCfs.BackColor = System.Drawing.Color.White;
            this.pieChartCteGeneroCfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartCteGeneroCfs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieChartCteGeneroCfs.Location = new System.Drawing.Point(3, 16);
            this.pieChartCteGeneroCfs.Name = "pieChartCteGeneroCfs";
            this.pieChartCteGeneroCfs.Size = new System.Drawing.Size(274, 162);
            this.pieChartCteGeneroCfs.TabIndex = 0;
            this.pieChartCteGeneroCfs.Text = "pieChart1";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.White;
            this.groupBox9.Controls.Add(this.pieChartCteGeneroSama);
            this.groupBox9.Location = new System.Drawing.Point(5, 18);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(280, 181);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Distribución de clientes [SAMA]";
            // 
            // pieChartCteGeneroSama
            // 
            this.pieChartCteGeneroSama.BackColor = System.Drawing.Color.White;
            this.pieChartCteGeneroSama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartCteGeneroSama.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieChartCteGeneroSama.Location = new System.Drawing.Point(3, 16);
            this.pieChartCteGeneroSama.Name = "pieChartCteGeneroSama";
            this.pieChartCteGeneroSama.Size = new System.Drawing.Size(274, 162);
            this.pieChartCteGeneroSama.TabIndex = 0;
            this.pieChartCteGeneroSama.Text = "pieChart1";
            // 
            // frm_cte_info_general
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 612);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 650);
            this.MinimumSize = new System.Drawing.Size(1300, 650);
            this.Name = "frm_cte_info_general";
            this.Text = "Información general de clientes";
            this.Load += new System.EventHandler(this.frm_cte_info_general_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private LiveCharts.WinForms.PieChart pieChartCteTipoCfs;
        private System.Windows.Forms.GroupBox groupBox2;
        private LiveCharts.WinForms.PieChart pieChartCteTipoSama;
        private System.Windows.Forms.GroupBox groupBox1;
        private LiveCharts.WinForms.PieChart pieChartTotalTipo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private LiveCharts.WinForms.PieChart pieChartTotalGenero;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private LiveCharts.WinForms.PieChart pieChartCteGeneroCfs;
        private System.Windows.Forms.GroupBox groupBox9;
        private LiveCharts.WinForms.PieChart pieChartCteGeneroSama;
    }
}