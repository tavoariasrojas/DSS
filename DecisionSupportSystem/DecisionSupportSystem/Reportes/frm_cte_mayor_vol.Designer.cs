namespace DecisionSupportSystem.Reportes
{
    partial class frm_cte_mayor_vol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cte_mayor_vol));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.cmb_mes_hasta = new System.Windows.Forms.ComboBox();
            this.cmb_mes_desde = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_ano_hasta = new System.Windows.Forms.ComboBox();
            this.cmb_ano_desde = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_dol = new System.Windows.Forms.RadioButton();
            this.rb_col = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_tipo_cliente = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_mensual = new System.Windows.Forms.RadioButton();
            this.rb_anual = new System.Windows.Forms.RadioButton();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb_comision = new System.Windows.Forms.RadioButton();
            this.rb_transado = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nud_top = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_top)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.btn_generar);
            this.groupBox1.Controls.Add(this.cmb_mes_hasta);
            this.groupBox1.Controls.Add(this.cmb_mes_desde);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_ano_hasta);
            this.groupBox1.Controls.Add(this.cmb_ano_desde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 705);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de filtro";
            // 
            // btn_generar
            // 
            this.btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_generar.Image = ((System.Drawing.Image)(resources.GetObject("btn_generar.Image")));
            this.btn_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generar.Location = new System.Drawing.Point(51, 630);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(156, 49);
            this.btn_generar.TabIndex = 11;
            this.btn_generar.Text = "&GENERAR";
            this.btn_generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // cmb_mes_hasta
            // 
            this.cmb_mes_hasta.Enabled = false;
            this.cmb_mes_hasta.FormattingEnabled = true;
            this.cmb_mes_hasta.Location = new System.Drawing.Point(135, 223);
            this.cmb_mes_hasta.Name = "cmb_mes_hasta";
            this.cmb_mes_hasta.Size = new System.Drawing.Size(107, 28);
            this.cmb_mes_hasta.TabIndex = 10;
            // 
            // cmb_mes_desde
            // 
            this.cmb_mes_desde.Enabled = false;
            this.cmb_mes_desde.FormattingEnabled = true;
            this.cmb_mes_desde.Location = new System.Drawing.Point(6, 223);
            this.cmb_mes_desde.Name = "cmb_mes_desde";
            this.cmb_mes_desde.Size = new System.Drawing.Size(107, 28);
            this.cmb_mes_desde.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mes hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mes desde";
            // 
            // cmb_ano_hasta
            // 
            this.cmb_ano_hasta.FormattingEnabled = true;
            this.cmb_ano_hasta.Location = new System.Drawing.Point(135, 146);
            this.cmb_ano_hasta.Name = "cmb_ano_hasta";
            this.cmb_ano_hasta.Size = new System.Drawing.Size(107, 28);
            this.cmb_ano_hasta.TabIndex = 6;
            // 
            // cmb_ano_desde
            // 
            this.cmb_ano_desde.FormattingEnabled = true;
            this.cmb_ano_desde.Location = new System.Drawing.Point(6, 146);
            this.cmb_ano_desde.Name = "cmb_ano_desde";
            this.cmb_ano_desde.Size = new System.Drawing.Size(107, 28);
            this.cmb_ano_desde.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Año hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Año desde";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_dol);
            this.groupBox4.Controls.Add(this.rb_col);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 456);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 69);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de moneda";
            // 
            // rb_dol
            // 
            this.rb_dol.AutoSize = true;
            this.rb_dol.Location = new System.Drawing.Point(134, 25);
            this.rb_dol.Name = "rb_dol";
            this.rb_dol.Size = new System.Drawing.Size(89, 24);
            this.rb_dol.TabIndex = 1;
            this.rb_dol.Text = "Dólares";
            this.rb_dol.UseVisualStyleBackColor = true;
            // 
            // rb_col
            // 
            this.rb_col.AutoSize = true;
            this.rb_col.Checked = true;
            this.rb_col.Location = new System.Drawing.Point(21, 25);
            this.rb_col.Name = "rb_col";
            this.rb_col.Size = new System.Drawing.Size(92, 24);
            this.rb_col.TabIndex = 0;
            this.rb_col.TabStop = true;
            this.rb_col.Text = "Colones";
            this.rb_col.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_tipo_cliente);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 69);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de cliente";
            // 
            // cmb_tipo_cliente
            // 
            this.cmb_tipo_cliente.FormattingEnabled = true;
            this.cmb_tipo_cliente.Items.AddRange(new object[] {
            "Todos",
            "Físico",
            "Jurídico"});
            this.cmb_tipo_cliente.Location = new System.Drawing.Point(21, 25);
            this.cmb_tipo_cliente.Name = "cmb_tipo_cliente";
            this.cmb_tipo_cliente.Size = new System.Drawing.Size(193, 28);
            this.cmb_tipo_cliente.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_mensual);
            this.groupBox2.Controls.Add(this.rb_anual);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 69);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango de tiempo";
            // 
            // rb_mensual
            // 
            this.rb_mensual.AutoSize = true;
            this.rb_mensual.Location = new System.Drawing.Point(134, 25);
            this.rb_mensual.Name = "rb_mensual";
            this.rb_mensual.Size = new System.Drawing.Size(94, 24);
            this.rb_mensual.TabIndex = 1;
            this.rb_mensual.Text = "Mensual";
            this.rb_mensual.UseVisualStyleBackColor = true;
            this.rb_mensual.CheckedChanged += new System.EventHandler(this.rb_mensual_CheckedChanged);
            // 
            // rb_anual
            // 
            this.rb_anual.AutoSize = true;
            this.rb_anual.Checked = true;
            this.rb_anual.Location = new System.Drawing.Point(21, 25);
            this.rb_anual.Name = "rb_anual";
            this.rb_anual.Size = new System.Drawing.Size(75, 24);
            this.rb_anual.TabIndex = 0;
            this.rb_anual.TabStop = true;
            this.rb_anual.Text = "Anual";
            this.rb_anual.UseVisualStyleBackColor = true;
            this.rb_anual.CheckedChanged += new System.EventHandler(this.rb_anual_CheckedChanged);
            // 
            // dgv_info
            // 
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_info.Location = new System.Drawing.Point(0, 828);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.RowTemplate.Height = 28;
            this.dgv_info.Size = new System.Drawing.Size(1778, 316);
            this.dgv_info.TabIndex = 1;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(276, 12);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1490, 810);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb_comision);
            this.groupBox5.Controls.Add(this.rb_transado);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 375);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(246, 69);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Campo de interés";
            // 
            // rb_comision
            // 
            this.rb_comision.AutoSize = true;
            this.rb_comision.Location = new System.Drawing.Point(134, 25);
            this.rb_comision.Name = "rb_comision";
            this.rb_comision.Size = new System.Drawing.Size(99, 24);
            this.rb_comision.TabIndex = 1;
            this.rb_comision.Text = "Comisión";
            this.rb_comision.UseVisualStyleBackColor = true;
            // 
            // rb_transado
            // 
            this.rb_transado.AutoSize = true;
            this.rb_transado.Checked = true;
            this.rb_transado.Location = new System.Drawing.Point(21, 25);
            this.rb_transado.Name = "rb_transado";
            this.rb_transado.Size = new System.Drawing.Size(101, 24);
            this.rb_transado.TabIndex = 0;
            this.rb_transado.TabStop = true;
            this.rb_transado.Text = "Transado";
            this.rb_transado.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nud_top);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(6, 537);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(246, 69);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cantidad máxima";
            // 
            // nud_top
            // 
            this.nud_top.Location = new System.Drawing.Point(79, 25);
            this.nud_top.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_top.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_top.Name = "nud_top";
            this.nud_top.Size = new System.Drawing.Size(66, 26);
            this.nud_top.TabIndex = 0;
            this.nud_top.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frm_cte_mayor_vol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 1144);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dgv_info);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1800, 1200);
            this.MinimumSize = new System.Drawing.Size(1800, 1200);
            this.Name = "frm_cte_mayor_vol";
            this.Text = "Reporte de clientes con mayor volumen de operaciones";
            this.Load += new System.EventHandler(this.frm_cte_mayor_vol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_top)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_dol;
        private System.Windows.Forms.RadioButton rb_col;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_tipo_cliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_mensual;
        private System.Windows.Forms.RadioButton rb_anual;
        private System.Windows.Forms.ComboBox cmb_mes_hasta;
        private System.Windows.Forms.ComboBox cmb_mes_desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_ano_hasta;
        private System.Windows.Forms.ComboBox cmb_ano_desde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_comision;
        private System.Windows.Forms.RadioButton rb_transado;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown nud_top;
    }
}