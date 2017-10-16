namespace DecisionSupportSystem.Mapa
{
    partial class frm_mapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mapa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gm_main = new LiveCharts.WinForms.GeoMap();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gm_main);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(291, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 612);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mapa de la distribución";
            // 
            // gm_main
            // 
            this.gm_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gm_main.Location = new System.Drawing.Point(3, 16);
            this.gm_main.Name = "gm_main";
            this.gm_main.Size = new System.Drawing.Size(987, 593);
            this.gm_main.TabIndex = 1;
            this.gm_main.Text = "geoMap1";
            // 
            // frm_mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 612);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 650);
            this.MinimumSize = new System.Drawing.Size(1300, 650);
            this.Name = "frm_mapa";
            this.Text = "Distribución geográfica";
            this.Load += new System.EventHandler(this.frm_mapa_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private LiveCharts.WinForms.GeoMap gm_main;
    }
}