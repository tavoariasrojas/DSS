﻿namespace DecisionSupportSystem.Reportes
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.mainCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmb_ejecutivo = new System.Windows.Forms.ComboBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.cmb_mes_hasta = new System.Windows.Forms.ComboBox();
            this.cmb_mes_desde = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_ano_hasta = new System.Windows.Forms.ComboBox();
            this.cmb_ano_desde = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_asesor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_mensual = new System.Windows.Forms.RadioButton();
            this.rb_anual = new System.Windows.Forms.RadioButton();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.mainCartesianChart);
            this.groupBox7.Location = new System.Drawing.Point(180, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1100, 460);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resultado del gráfico";
            // 
            // mainCartesianChart
            // 
            this.mainCartesianChart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainCartesianChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainCartesianChart.Location = new System.Drawing.Point(3, 16);
            this.mainCartesianChart.Name = "mainCartesianChart";
            this.mainCartesianChart.Size = new System.Drawing.Size(1094, 441);
            this.mainCartesianChart.TabIndex = 0;
            this.mainCartesianChart.Text = "cartesianChart1";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dgv_info);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox9.Location = new System.Drawing.Point(0, 462);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1284, 150);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Vista de información graficada";
            // 
            // dgv_info
            // 
            this.dgv_info.AllowUserToAddRows = false;
            this.dgv_info.AllowUserToDeleteRows = false;
            this.dgv_info.AllowUserToResizeColumns = false;
            this.dgv_info.AllowUserToResizeRows = false;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_info.Location = new System.Drawing.Point(3, 16);
            this.dgv_info.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.ReadOnly = true;
            this.dgv_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_info.RowTemplate.Height = 28;
            this.dgv_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_info.Size = new System.Drawing.Size(1278, 131);
            this.dgv_info.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btn_generar);
            this.groupBox1.Controls.Add(this.cmb_mes_hasta);
            this.groupBox1.Controls.Add(this.cmb_mes_desde);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_ano_hasta);
            this.groupBox1.Controls.Add(this.cmb_ano_desde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(175, 460);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de filtro";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmb_ejecutivo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(4, 195);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(164, 42);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ejecutivo";
            // 
            // cmb_ejecutivo
            // 
            this.cmb_ejecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ejecutivo.DropDownWidth = 225;
            this.cmb_ejecutivo.FormattingEnabled = true;
            this.cmb_ejecutivo.Location = new System.Drawing.Point(4, 16);
            this.cmb_ejecutivo.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_ejecutivo.Name = "cmb_ejecutivo";
            this.cmb_ejecutivo.Size = new System.Drawing.Size(156, 21);
            this.cmb_ejecutivo.TabIndex = 0;
            // 
            // btn_generar
            // 
            this.btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_generar.Image = ((System.Drawing.Image)(resources.GetObject("btn_generar.Image")));
            this.btn_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generar.Location = new System.Drawing.Point(34, 417);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(104, 32);
            this.btn_generar.TabIndex = 11;
            this.btn_generar.Text = "&GENERAR";
            this.btn_generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // cmb_mes_hasta
            // 
            this.cmb_mes_hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mes_hasta.Enabled = false;
            this.cmb_mes_hasta.FormattingEnabled = true;
            this.cmb_mes_hasta.Location = new System.Drawing.Point(90, 125);
            this.cmb_mes_hasta.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_mes_hasta.Name = "cmb_mes_hasta";
            this.cmb_mes_hasta.Size = new System.Drawing.Size(73, 21);
            this.cmb_mes_hasta.TabIndex = 10;
            // 
            // cmb_mes_desde
            // 
            this.cmb_mes_desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mes_desde.Enabled = false;
            this.cmb_mes_desde.FormattingEnabled = true;
            this.cmb_mes_desde.Location = new System.Drawing.Point(4, 125);
            this.cmb_mes_desde.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_mes_desde.Name = "cmb_mes_desde";
            this.cmb_mes_desde.Size = new System.Drawing.Size(73, 21);
            this.cmb_mes_desde.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mes hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mes desde";
            // 
            // cmb_ano_hasta
            // 
            this.cmb_ano_hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ano_hasta.FormattingEnabled = true;
            this.cmb_ano_hasta.Location = new System.Drawing.Point(99, 85);
            this.cmb_ano_hasta.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_ano_hasta.Name = "cmb_ano_hasta";
            this.cmb_ano_hasta.Size = new System.Drawing.Size(54, 21);
            this.cmb_ano_hasta.TabIndex = 6;
            // 
            // cmb_ano_desde
            // 
            this.cmb_ano_desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ano_desde.FormattingEnabled = true;
            this.cmb_ano_desde.Location = new System.Drawing.Point(13, 85);
            this.cmb_ano_desde.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_ano_desde.Name = "cmb_ano_desde";
            this.cmb_ano_desde.Size = new System.Drawing.Size(54, 21);
            this.cmb_ano_desde.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Año hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Año desde";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_asesor);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 149);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(164, 42);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asesor";
            // 
            // cmb_asesor
            // 
            this.cmb_asesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_asesor.DropDownWidth = 225;
            this.cmb_asesor.FormattingEnabled = true;
            this.cmb_asesor.Location = new System.Drawing.Point(30, 17);
            this.cmb_asesor.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_asesor.Name = "cmb_asesor";
            this.cmb_asesor.Size = new System.Drawing.Size(86, 21);
            this.cmb_asesor.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_mensual);
            this.groupBox2.Controls.Add(this.rb_anual);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(164, 42);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango de tiempo";
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
            // frm_cte_nuevos
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
            this.Name = "frm_cte_nuevos";
            this.Text = "Reporte sobre clientes nuevos";
            this.Load += new System.EventHandler(this.frm_cte_nuevos_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private LiveCharts.WinForms.CartesianChart mainCartesianChart;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.ComboBox cmb_mes_hasta;
        private System.Windows.Forms.ComboBox cmb_mes_desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_ano_hasta;
        private System.Windows.Forms.ComboBox cmb_ano_desde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_asesor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_mensual;
        private System.Windows.Forms.RadioButton rb_anual;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmb_ejecutivo;
    }
}