﻿namespace DecisionSupportSystem.Reportes
{
    partial class frm_prod_mayor_rentd_com
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_prod_mayor_rentd_com));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_mes_hasta = new System.Windows.Forms.ComboBox();
            this.cmb_mes_desde = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_ano_hasta = new System.Windows.Forms.ComboBox();
            this.cmb_ano_desde = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_mensual = new System.Windows.Forms.RadioButton();
            this.rb_anual = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nud_top = new System.Windows.Forms.NumericUpDown();
            this.btn_generar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_dol = new System.Windows.Forms.RadioButton();
            this.rb_col = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_box_list_instrumento = new System.Windows.Forms.CheckedListBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.mainCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_top)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.btn_generar);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(175, 463);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de filtro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_mes_hasta);
            this.groupBox2.Controls.Add(this.cmb_mes_desde);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmb_ano_hasta);
            this.groupBox2.Controls.Add(this.cmb_ano_desde);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rb_mensual);
            this.groupBox2.Controls.Add(this.rb_anual);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(164, 124);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango de tiempo";
            // 
            // cmb_mes_hasta
            // 
            this.cmb_mes_hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mes_hasta.Enabled = false;
            this.cmb_mes_hasta.FormattingEnabled = true;
            this.cmb_mes_hasta.Location = new System.Drawing.Point(84, 93);
            this.cmb_mes_hasta.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_mes_hasta.Name = "cmb_mes_hasta";
            this.cmb_mes_hasta.Size = new System.Drawing.Size(73, 21);
            this.cmb_mes_hasta.TabIndex = 18;
            // 
            // cmb_mes_desde
            // 
            this.cmb_mes_desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mes_desde.Enabled = false;
            this.cmb_mes_desde.FormattingEnabled = true;
            this.cmb_mes_desde.Location = new System.Drawing.Point(4, 93);
            this.cmb_mes_desde.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_mes_desde.Name = "cmb_mes_desde";
            this.cmb_mes_desde.Size = new System.Drawing.Size(73, 21);
            this.cmb_mes_desde.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mes hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mes desde";
            // 
            // cmb_ano_hasta
            // 
            this.cmb_ano_hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ano_hasta.FormattingEnabled = true;
            this.cmb_ano_hasta.Location = new System.Drawing.Point(93, 51);
            this.cmb_ano_hasta.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_ano_hasta.Name = "cmb_ano_hasta";
            this.cmb_ano_hasta.Size = new System.Drawing.Size(54, 21);
            this.cmb_ano_hasta.TabIndex = 14;
            // 
            // cmb_ano_desde
            // 
            this.cmb_ano_desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ano_desde.FormattingEnabled = true;
            this.cmb_ano_desde.Location = new System.Drawing.Point(13, 51);
            this.cmb_ano_desde.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_ano_desde.Name = "cmb_ano_desde";
            this.cmb_ano_desde.Size = new System.Drawing.Size(54, 21);
            this.cmb_ano_desde.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Año hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Año desde";
            // 
            // rb_mensual
            // 
            this.rb_mensual.AutoSize = true;
            this.rb_mensual.Location = new System.Drawing.Point(89, 16);
            this.rb_mensual.Margin = new System.Windows.Forms.Padding(2);
            this.rb_mensual.Name = "rb_mensual";
            this.rb_mensual.Size = new System.Drawing.Size(65, 17);
            this.rb_mensual.TabIndex = 1;
            this.rb_mensual.Text = "Mensual";
            this.rb_mensual.UseVisualStyleBackColor = true;
            this.rb_mensual.CheckedChanged += new System.EventHandler(this.rb_mensual_CheckedChanged);
            // 
            // rb_anual
            // 
            this.rb_anual.AutoSize = true;
            this.rb_anual.Checked = true;
            this.rb_anual.Location = new System.Drawing.Point(14, 16);
            this.rb_anual.Margin = new System.Windows.Forms.Padding(2);
            this.rb_anual.Name = "rb_anual";
            this.rb_anual.Size = new System.Drawing.Size(52, 17);
            this.rb_anual.TabIndex = 0;
            this.rb_anual.TabStop = true;
            this.rb_anual.Text = "Anual";
            this.rb_anual.UseVisualStyleBackColor = true;
            this.rb_anual.CheckedChanged += new System.EventHandler(this.rb_anual_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nud_top);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(5, 306);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(164, 42);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cantidad máxima";
            // 
            // nud_top
            // 
            this.nud_top.Enabled = false;
            this.nud_top.Location = new System.Drawing.Point(53, 16);
            this.nud_top.Margin = new System.Windows.Forms.Padding(2);
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
            this.nud_top.Size = new System.Drawing.Size(44, 20);
            this.nud_top.TabIndex = 0;
            this.nud_top.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_top.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_generar
            // 
            this.btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Image = ((System.Drawing.Image)(resources.GetObject("btn_generar.Image")));
            this.btn_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generar.Location = new System.Drawing.Point(35, 420);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(105, 32);
            this.btn_generar.TabIndex = 11;
            this.btn_generar.Text = "&GENERAR";
            this.btn_generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_dol);
            this.groupBox4.Controls.Add(this.rb_col);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 258);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(164, 42);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de moneda";
            // 
            // rb_dol
            // 
            this.rb_dol.AutoSize = true;
            this.rb_dol.Location = new System.Drawing.Point(89, 16);
            this.rb_dol.Margin = new System.Windows.Forms.Padding(2);
            this.rb_dol.Name = "rb_dol";
            this.rb_dol.Size = new System.Drawing.Size(61, 17);
            this.rb_dol.TabIndex = 1;
            this.rb_dol.Text = "Dólares";
            this.rb_dol.UseVisualStyleBackColor = true;
            // 
            // rb_col
            // 
            this.rb_col.AutoSize = true;
            this.rb_col.Checked = true;
            this.rb_col.Location = new System.Drawing.Point(14, 16);
            this.rb_col.Margin = new System.Windows.Forms.Padding(2);
            this.rb_col.Name = "rb_col";
            this.rb_col.Size = new System.Drawing.Size(63, 17);
            this.rb_col.TabIndex = 0;
            this.rb_col.TabStop = true;
            this.rb_col.Text = "Colones";
            this.rb_col.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_box_list_instrumento);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 145);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(164, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de instrumento";
            // 
            // chk_box_list_instrumento
            // 
            this.chk_box_list_instrumento.BackColor = System.Drawing.SystemColors.Control;
            this.chk_box_list_instrumento.CheckOnClick = true;
            this.chk_box_list_instrumento.FormattingEnabled = true;
            this.chk_box_list_instrumento.Location = new System.Drawing.Point(5, 18);
            this.chk_box_list_instrumento.Name = "chk_box_list_instrumento";
            this.chk_box_list_instrumento.Size = new System.Drawing.Size(154, 79);
            this.chk_box_list_instrumento.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dgv_info);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox9.Location = new System.Drawing.Point(0, 462);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1284, 150);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Vista de información graficada";
            // 
            // dgv_info
            // 
            this.dgv_info.AllowUserToAddRows = false;
            this.dgv_info.AllowUserToDeleteRows = false;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_info.Location = new System.Drawing.Point(3, 16);
            this.dgv_info.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.ReadOnly = true;
            this.dgv_info.RowTemplate.Height = 28;
            this.dgv_info.Size = new System.Drawing.Size(1278, 131);
            this.dgv_info.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.mainCartesianChart);
            this.groupBox7.Location = new System.Drawing.Point(180, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1100, 463);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resultado del gráfico";
            // 
            // mainCartesianChart
            // 
            this.mainCartesianChart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainCartesianChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainCartesianChart.Location = new System.Drawing.Point(3, 16);
            this.mainCartesianChart.Name = "mainCartesianChart";
            this.mainCartesianChart.Size = new System.Drawing.Size(1094, 444);
            this.mainCartesianChart.TabIndex = 0;
            this.mainCartesianChart.Text = "cartesianChart1";
            // 
            // frm_prod_mayor_rentd_com
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 612);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 650);
            this.MinimumSize = new System.Drawing.Size(1300, 650);
            this.Name = "frm_prod_mayor_rentd_com";
            this.Text = "Reporte de productos con mejor rendimiento [Comisiones]";
            this.Load += new System.EventHandler(this.frm_prod_mayor_rentd_com_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_top)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown nud_top;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_dol;
        private System.Windows.Forms.RadioButton rb_col;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.GroupBox groupBox7;
        private LiveCharts.WinForms.CartesianChart mainCartesianChart;
        private System.Windows.Forms.CheckedListBox chk_box_list_instrumento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_mes_hasta;
        private System.Windows.Forms.ComboBox cmb_mes_desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_ano_hasta;
        private System.Windows.Forms.ComboBox cmb_ano_desde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_mensual;
        private System.Windows.Forms.RadioButton rb_anual;
    }
}