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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.il_menu = new System.Windows.Forms.ImageList(this.components);
            this.ss_main = new System.Windows.Forms.StatusStrip();
            this.tssl_usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_servidor = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_database = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_fecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.t_main = new System.Windows.Forms.Timer(this.components);
            this.tssl_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // il_menu
            // 
            this.il_menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_menu.ImageStream")));
            this.il_menu.TransparentColor = System.Drawing.Color.Transparent;
            this.il_menu.Images.SetKeyName(0, "default_32.png");
            this.il_menu.Images.SetKeyName(1, "password_32.png");
            this.il_menu.Images.SetKeyName(2, "exit_blue_32.png");
            this.il_menu.Images.SetKeyName(3, "resumen_clientes_32.png");
            this.il_menu.Images.SetKeyName(4, "bolsa_dinero_32.png");
            this.il_menu.Images.SetKeyName(5, "cliente_informacion_32.png");
            this.il_menu.Images.SetKeyName(6, "cliente_profile_32.png");
            this.il_menu.Images.SetKeyName(7, "grafico_ascenso_32.png");
            this.il_menu.Images.SetKeyName(8, "informacion_usuario_32.png");
            this.il_menu.Images.SetKeyName(9, "listado_32.png");
            this.il_menu.Images.SetKeyName(10, "rendimiento_32.png");
            this.il_menu.Images.SetKeyName(11, "report_green_32.png");
            this.il_menu.Images.SetKeyName(12, "roles_32.png");
            // 
            // ss_main
            // 
            this.ss_main.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ss_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_usuario,
            this.tssl_servidor,
            this.tssl_database,
            this.tssl_fecha,
            this.tssl_hora});
            this.ss_main.Location = new System.Drawing.Point(0, 403);
            this.ss_main.Name = "ss_main";
            this.ss_main.Size = new System.Drawing.Size(823, 25);
            this.ss_main.TabIndex = 1;
            this.ss_main.Text = "statusStrip1";
            // 
            // tssl_usuario
            // 
            this.tssl_usuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tssl_usuario.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tssl_usuario.Image = ((System.Drawing.Image)(resources.GetObject("tssl_usuario.Image")));
            this.tssl_usuario.Name = "tssl_usuario";
            this.tssl_usuario.Size = new System.Drawing.Size(155, 20);
            this.tssl_usuario.Spring = true;
            this.tssl_usuario.Text = "Usuario actual:";
            // 
            // tssl_servidor
            // 
            this.tssl_servidor.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssl_servidor.Image = ((System.Drawing.Image)(resources.GetObject("tssl_servidor.Image")));
            this.tssl_servidor.Name = "tssl_servidor";
            this.tssl_servidor.Size = new System.Drawing.Size(155, 20);
            this.tssl_servidor.Spring = true;
            this.tssl_servidor.Text = "Conectado al servidor:";
            // 
            // tssl_database
            // 
            this.tssl_database.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssl_database.Image = ((System.Drawing.Image)(resources.GetObject("tssl_database.Image")));
            this.tssl_database.Name = "tssl_database";
            this.tssl_database.Size = new System.Drawing.Size(155, 20);
            this.tssl_database.Spring = true;
            this.tssl_database.Text = "Utilizando base de datos:";
            // 
            // tssl_fecha
            // 
            this.tssl_fecha.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssl_fecha.Image = ((System.Drawing.Image)(resources.GetObject("tssl_fecha.Image")));
            this.tssl_fecha.Name = "tssl_fecha";
            this.tssl_fecha.Size = new System.Drawing.Size(155, 20);
            this.tssl_fecha.Spring = true;
            this.tssl_fecha.Text = "Fecha:";
            // 
            // t_main
            // 
            this.t_main.Interval = 1000;
            this.t_main.Tick += new System.EventHandler(this.t_main_Tick);
            // 
            // tssl_hora
            // 
            this.tssl_hora.Image = ((System.Drawing.Image)(resources.GetObject("tssl_hora.Image")));
            this.tssl_hora.Name = "tssl_hora";
            this.tssl_hora.Size = new System.Drawing.Size(155, 20);
            this.tssl_hora.Spring = true;
            this.tssl_hora.Text = "Hora actual:";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 428);
            this.Controls.Add(this.ss_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_main";
            this.Text = "Bienvenido al Sistema de Toma de Desiciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_main_FormClosed);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ss_main.ResumeLayout(false);
            this.ss_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList il_menu;
        private System.Windows.Forms.StatusStrip ss_main;
        private System.Windows.Forms.ToolStripStatusLabel tssl_usuario;
        private System.Windows.Forms.ToolStripStatusLabel tssl_servidor;
        private System.Windows.Forms.ToolStripStatusLabel tssl_database;
        private System.Windows.Forms.ToolStripStatusLabel tssl_fecha;
        private System.Windows.Forms.Timer t_main;
        private System.Windows.Forms.ToolStripStatusLabel tssl_hora;
    }
}