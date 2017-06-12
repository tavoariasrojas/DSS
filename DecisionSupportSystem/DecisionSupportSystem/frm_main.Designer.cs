namespace DecisionSupportSystem
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.ms_td_main = new System.Windows.Forms.MenuStrip();
            this.mi_archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_td_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_td_main
            // 
            this.ms_td_main.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.ms_td_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_archivo});
            this.ms_td_main.Location = new System.Drawing.Point(0, 0);
            this.ms_td_main.Name = "ms_td_main";
            this.ms_td_main.Size = new System.Drawing.Size(2072, 38);
            this.ms_td_main.TabIndex = 1;
            this.ms_td_main.Text = "menuStrip1";
            // 
            // mi_archivo
            // 
            this.mi_archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_salir});
            this.mi_archivo.Name = "mi_archivo";
            this.mi_archivo.Size = new System.Drawing.Size(95, 34);
            this.mi_archivo.Text = "Archivo";
            // 
            // mi_salir
            // 
            this.mi_salir.Name = "mi_salir";
            this.mi_salir.Size = new System.Drawing.Size(239, 34);
            this.mi_salir.Text = "Salir";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2072, 1279);
            this.Controls.Add(this.ms_td_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_td_main;
            this.Name = "frm_main";
            this.Text = "Bienvenido al Sistema de Toma de Desiciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ms_td_main.ResumeLayout(false);
            this.ms_td_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_td_main;
        private System.Windows.Forms.ToolStripMenuItem mi_archivo;
        private System.Windows.Forms.ToolStripMenuItem mi_salir;
    }
}