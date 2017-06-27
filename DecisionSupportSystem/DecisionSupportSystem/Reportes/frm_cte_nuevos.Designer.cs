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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_mes = new System.Windows.Forms.RadioButton();
            this.rb_ano = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_ejecutivo = new System.Windows.Forms.RadioButton();
            this.rb_asesor = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_fec_hasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_fec_desde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgv_reporte = new System.Windows.Forms.DataGridView();
            this.chart_cliente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.btn_generar);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de información";
            // 
            // btn_generar
            // 
            this.btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_generar.Image = ((System.Drawing.Image)(resources.GetObject("btn_generar.Image")));
            this.btn_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generar.Location = new System.Drawing.Point(39, 272);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(81, 39);
            this.btn_generar.TabIndex = 1;
            this.btn_generar.Text = "&Generar";
            this.btn_generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_mes);
            this.groupBox4.Controls.Add(this.rb_ano);
            this.groupBox4.Location = new System.Drawing.Point(9, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 72);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ver por";
            // 
            // rb_mes
            // 
            this.rb_mes.AutoSize = true;
            this.rb_mes.Location = new System.Drawing.Point(7, 42);
            this.rb_mes.Name = "rb_mes";
            this.rb_mes.Size = new System.Drawing.Size(56, 17);
            this.rb_mes.TabIndex = 6;
            this.rb_mes.Text = "Meses";
            this.rb_mes.UseVisualStyleBackColor = true;
            // 
            // rb_ano
            // 
            this.rb_ano.AutoSize = true;
            this.rb_ano.Checked = true;
            this.rb_ano.Location = new System.Drawing.Point(7, 19);
            this.rb_ano.Name = "rb_ano";
            this.rb_ano.Size = new System.Drawing.Size(49, 17);
            this.rb_ano.TabIndex = 5;
            this.rb_ano.TabStop = true;
            this.rb_ano.Text = "Años";
            this.rb_ano.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_ejecutivo);
            this.groupBox3.Controls.Add(this.rb_asesor);
            this.groupBox3.Location = new System.Drawing.Point(9, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 76);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agrupados por";
            // 
            // rb_ejecutivo
            // 
            this.rb_ejecutivo.AutoSize = true;
            this.rb_ejecutivo.Location = new System.Drawing.Point(7, 42);
            this.rb_ejecutivo.Name = "rb_ejecutivo";
            this.rb_ejecutivo.Size = new System.Drawing.Size(74, 17);
            this.rb_ejecutivo.TabIndex = 9;
            this.rb_ejecutivo.Text = "Ejecutivos";
            this.rb_ejecutivo.UseVisualStyleBackColor = true;
            // 
            // rb_asesor
            // 
            this.rb_asesor.AutoSize = true;
            this.rb_asesor.Checked = true;
            this.rb_asesor.Location = new System.Drawing.Point(7, 19);
            this.rb_asesor.Name = "rb_asesor";
            this.rb_asesor.Size = new System.Drawing.Size(57, 17);
            this.rb_asesor.TabIndex = 8;
            this.rb_asesor.TabStop = true;
            this.rb_asesor.Text = "Asesor";
            this.rb_asesor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_fec_hasta);
            this.groupBox2.Controls.Add(this.dtp_fec_desde);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas";
            // 
            // dtp_fec_hasta
            // 
            this.dtp_fec_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fec_hasta.Location = new System.Drawing.Point(53, 42);
            this.dtp_fec_hasta.Name = "dtp_fec_hasta";
            this.dtp_fec_hasta.Size = new System.Drawing.Size(81, 20);
            this.dtp_fec_hasta.TabIndex = 3;
            // 
            // dtp_fec_desde
            // 
            this.dtp_fec_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fec_desde.Location = new System.Drawing.Point(53, 16);
            this.dtp_fec_desde.Name = "dtp_fec_desde";
            this.dtp_fec_desde.Size = new System.Drawing.Size(81, 20);
            this.dtp_fec_desde.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgv_reporte);
            this.groupBox5.Location = new System.Drawing.Point(165, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(434, 507);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resultado";
            // 
            // dgv_reporte
            // 
            this.dgv_reporte.AllowUserToAddRows = false;
            this.dgv_reporte.AllowUserToDeleteRows = false;
            this.dgv_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reporte.Location = new System.Drawing.Point(6, 17);
            this.dgv_reporte.Name = "dgv_reporte";
            this.dgv_reporte.ReadOnly = true;
            this.dgv_reporte.Size = new System.Drawing.Size(422, 484);
            this.dgv_reporte.TabIndex = 0;
            // 
            // chart_cliente
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_cliente.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_cliente.Legends.Add(legend1);
            this.chart_cliente.Location = new System.Drawing.Point(678, 80);
            this.chart_cliente.Name = "chart_cliente";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_cliente.Series.Add(series1);
            this.chart_cliente.Size = new System.Drawing.Size(300, 300);
            this.chart_cliente.TabIndex = 2;
            this.chart_cliente.Text = "chart1";
            // 
            // frm_clientes_nuevos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 507);
            this.Controls.Add(this.chart_cliente);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_clientes_nuevos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de nuevos clientes";
            this.Load += new System.EventHandler(this.frm_clientes_nuevos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_fec_hasta;
        private System.Windows.Forms.DateTimePicker dtp_fec_desde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_ejecutivo;
        private System.Windows.Forms.RadioButton rb_asesor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_mes;
        private System.Windows.Forms.RadioButton rb_ano;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgv_reporte;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cliente;
    }
}