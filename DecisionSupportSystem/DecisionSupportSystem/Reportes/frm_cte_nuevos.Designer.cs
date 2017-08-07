namespace DecisionSupportSystem.Reportes
{
    partial class frm_cte_nuevos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cte_nuevos));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btn_generar = new System.Windows.Forms.Button();
            this.gb_filtro = new System.Windows.Forms.GroupBox();
            this.gb_fecha = new System.Windows.Forms.GroupBox();
            this.cmb_semana_hasta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_semana_desde = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_mes_hasta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_mes_desde = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_ano_hasta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_ano_desde = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_semana = new System.Windows.Forms.RadioButton();
            this.rb_mes = new System.Windows.Forms.RadioButton();
            this.rb_ano = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gb_filtro.SuspendLayout();
            this.gb_fecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_generar
            // 
            this.btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_generar.Image = ((System.Drawing.Image)(resources.GetObject("btn_generar.Image")));
            this.btn_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generar.Location = new System.Drawing.Point(134, 251);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(129, 49);
            this.btn_generar.TabIndex = 2;
            this.btn_generar.Text = "&Generar";
            this.btn_generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // gb_filtro
            // 
            this.gb_filtro.Controls.Add(this.gb_fecha);
            this.gb_filtro.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_filtro.Location = new System.Drawing.Point(0, 0);
            this.gb_filtro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_filtro.Name = "gb_filtro";
            this.gb_filtro.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_filtro.Size = new System.Drawing.Size(396, 835);
            this.gb_filtro.TabIndex = 1;
            this.gb_filtro.TabStop = false;
            this.gb_filtro.Text = "Filtros para la consulta";
            // 
            // gb_fecha
            // 
            this.gb_fecha.Controls.Add(this.cmb_semana_hasta);
            this.gb_fecha.Controls.Add(this.btn_generar);
            this.gb_fecha.Controls.Add(this.label5);
            this.gb_fecha.Controls.Add(this.cmb_semana_desde);
            this.gb_fecha.Controls.Add(this.label6);
            this.gb_fecha.Controls.Add(this.cmb_mes_hasta);
            this.gb_fecha.Controls.Add(this.label3);
            this.gb_fecha.Controls.Add(this.cmb_mes_desde);
            this.gb_fecha.Controls.Add(this.label4);
            this.gb_fecha.Controls.Add(this.cmb_ano_hasta);
            this.gb_fecha.Controls.Add(this.label2);
            this.gb_fecha.Controls.Add(this.cmb_ano_desde);
            this.gb_fecha.Controls.Add(this.label1);
            this.gb_fecha.Controls.Add(this.rb_semana);
            this.gb_fecha.Controls.Add(this.rb_mes);
            this.gb_fecha.Controls.Add(this.rb_ano);
            this.gb_fecha.Location = new System.Drawing.Point(18, 29);
            this.gb_fecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_fecha.Name = "gb_fecha";
            this.gb_fecha.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_fecha.Size = new System.Drawing.Size(366, 311);
            this.gb_fecha.TabIndex = 2;
            this.gb_fecha.TabStop = false;
            this.gb_fecha.Text = "Clientes nuevos por fechas";
            // 
            // cmb_semana_hasta
            // 
            this.cmb_semana_hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_semana_hasta.Enabled = false;
            this.cmb_semana_hasta.FormattingEnabled = true;
            this.cmb_semana_hasta.Location = new System.Drawing.Point(196, 209);
            this.cmb_semana_hasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_semana_hasta.Name = "cmb_semana_hasta";
            this.cmb_semana_hasta.Size = new System.Drawing.Size(106, 28);
            this.cmb_semana_hasta.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Semana hasta";
            // 
            // cmb_semana_desde
            // 
            this.cmb_semana_desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_semana_desde.Enabled = false;
            this.cmb_semana_desde.FormattingEnabled = true;
            this.cmb_semana_desde.Location = new System.Drawing.Point(16, 209);
            this.cmb_semana_desde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_semana_desde.Name = "cmb_semana_desde";
            this.cmb_semana_desde.Size = new System.Drawing.Size(106, 28);
            this.cmb_semana_desde.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Semana desde";
            // 
            // cmb_mes_hasta
            // 
            this.cmb_mes_hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mes_hasta.Enabled = false;
            this.cmb_mes_hasta.FormattingEnabled = true;
            this.cmb_mes_hasta.Location = new System.Drawing.Point(196, 151);
            this.cmb_mes_hasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_mes_hasta.Name = "cmb_mes_hasta";
            this.cmb_mes_hasta.Size = new System.Drawing.Size(157, 28);
            this.cmb_mes_hasta.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mes hasta";
            // 
            // cmb_mes_desde
            // 
            this.cmb_mes_desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mes_desde.Enabled = false;
            this.cmb_mes_desde.FormattingEnabled = true;
            this.cmb_mes_desde.Location = new System.Drawing.Point(16, 151);
            this.cmb_mes_desde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_mes_desde.Name = "cmb_mes_desde";
            this.cmb_mes_desde.Size = new System.Drawing.Size(157, 28);
            this.cmb_mes_desde.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mes desde";
            // 
            // cmb_ano_hasta
            // 
            this.cmb_ano_hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ano_hasta.Enabled = false;
            this.cmb_ano_hasta.FormattingEnabled = true;
            this.cmb_ano_hasta.Location = new System.Drawing.Point(196, 92);
            this.cmb_ano_hasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_ano_hasta.Name = "cmb_ano_hasta";
            this.cmb_ano_hasta.Size = new System.Drawing.Size(106, 28);
            this.cmb_ano_hasta.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Año hasta";
            // 
            // cmb_ano_desde
            // 
            this.cmb_ano_desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ano_desde.Enabled = false;
            this.cmb_ano_desde.FormattingEnabled = true;
            this.cmb_ano_desde.Location = new System.Drawing.Point(16, 92);
            this.cmb_ano_desde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_ano_desde.Name = "cmb_ano_desde";
            this.cmb_ano_desde.Size = new System.Drawing.Size(106, 28);
            this.cmb_ano_desde.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Año desde";
            // 
            // rb_semana
            // 
            this.rb_semana.AutoSize = true;
            this.rb_semana.Location = new System.Drawing.Point(254, 29);
            this.rb_semana.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_semana.Name = "rb_semana";
            this.rb_semana.Size = new System.Drawing.Size(102, 24);
            this.rb_semana.TabIndex = 5;
            this.rb_semana.TabStop = true;
            this.rb_semana.Text = "Semanas";
            this.rb_semana.UseVisualStyleBackColor = true;
            this.rb_semana.Click += new System.EventHandler(this.rb_semana_Click);
            // 
            // rb_mes
            // 
            this.rb_mes.AutoSize = true;
            this.rb_mes.Location = new System.Drawing.Point(126, 29);
            this.rb_mes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_mes.Name = "rb_mes";
            this.rb_mes.Size = new System.Drawing.Size(81, 24);
            this.rb_mes.TabIndex = 4;
            this.rb_mes.TabStop = true;
            this.rb_mes.Text = "Meses";
            this.rb_mes.UseVisualStyleBackColor = true;
            this.rb_mes.Click += new System.EventHandler(this.rb_mes_Click);
            // 
            // rb_ano
            // 
            this.rb_ano.AutoSize = true;
            this.rb_ano.Location = new System.Drawing.Point(9, 29);
            this.rb_ano.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_ano.Name = "rb_ano";
            this.rb_ano.Size = new System.Drawing.Size(71, 24);
            this.rb_ano.TabIndex = 3;
            this.rb_ano.TabStop = true;
            this.rb_ano.Text = "Años";
            this.rb_ano.UseVisualStyleBackColor = true;
            this.rb_ano.Click += new System.EventHandler(this.rb_ano_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(396, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chart1.Size = new System.Drawing.Size(1354, 835);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // frm_cte_nuevos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 835);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.gb_filtro);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_cte_nuevos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de nuevos clientes";
            this.Load += new System.EventHandler(this.frm_clientes_nuevos_Load);
            this.gb_filtro.ResumeLayout(false);
            this.gb_fecha.ResumeLayout(false);
            this.gb_fecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.GroupBox gb_filtro;
        private System.Windows.Forms.GroupBox gb_fecha;
        private System.Windows.Forms.ComboBox cmb_semana_hasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_semana_desde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_mes_hasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_mes_desde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_ano_hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_ano_desde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_semana;
        private System.Windows.Forms.RadioButton rb_mes;
        private System.Windows.Forms.RadioButton rb_ano;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}