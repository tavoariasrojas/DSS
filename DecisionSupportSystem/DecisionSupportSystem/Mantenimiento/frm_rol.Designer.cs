namespace DecisionSupportSystem.Mantenimiento
{
    partial class frm_rol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rol));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_roles = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nom_rol = new System.Windows.Forms.TextBox();
            this.txt_cod_rol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tv_rol = new System.Windows.Forms.TreeView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_roles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar rol";
            // 
            // cmb_roles
            // 
            this.cmb_roles.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmb_roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_roles.FormattingEnabled = true;
            this.cmb_roles.Location = new System.Drawing.Point(3, 16);
            this.cmb_roles.Name = "cmb_roles";
            this.cmb_roles.Size = new System.Drawing.Size(298, 21);
            this.cmb_roles.TabIndex = 0;
            this.cmb_roles.SelectedValueChanged += new System.EventHandler(this.cmb_roles_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_nom_rol);
            this.groupBox2.Controls.Add(this.txt_cod_rol);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle del rol";
            // 
            // txt_nom_rol
            // 
            this.txt_nom_rol.Location = new System.Drawing.Point(100, 42);
            this.txt_nom_rol.MaxLength = 60;
            this.txt_nom_rol.Multiline = true;
            this.txt_nom_rol.Name = "txt_nom_rol";
            this.txt_nom_rol.Size = new System.Drawing.Size(187, 36);
            this.txt_nom_rol.TabIndex = 3;
            // 
            // txt_cod_rol
            // 
            this.txt_cod_rol.Location = new System.Drawing.Point(100, 18);
            this.txt_cod_rol.MaxLength = 15;
            this.txt_cod_rol.Name = "txt_cod_rol";
            this.txt_cod_rol.Size = new System.Drawing.Size(115, 20);
            this.txt_cod_rol.TabIndex = 2;
            this.txt_cod_rol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cod_rol.Leave += new System.EventHandler(this.txt_cod_rol_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción del rol";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código del rol";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(100, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "&GUARDAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tv_rol);
            this.groupBox3.Location = new System.Drawing.Point(0, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 372);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones del rol";
            // 
            // tv_rol
            // 
            this.tv_rol.CheckBoxes = true;
            this.tv_rol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_rol.Location = new System.Drawing.Point(3, 16);
            this.tv_rol.Name = "tv_rol";
            this.tv_rol.Size = new System.Drawing.Size(298, 353);
            this.tv_rol.TabIndex = 0;
            this.tv_rol.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tv_rol_AfterCheck);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(0, 515);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 53);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Descripción de la opción";
            // 
            // frm_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 612);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(320, 650);
            this.MinimumSize = new System.Drawing.Size(320, 650);
            this.Name = "frm_rol";
            this.Text = "Mantenimiento de roles";
            this.Load += new System.EventHandler(this.frm_rol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_roles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nom_rol;
        private System.Windows.Forms.TextBox txt_cod_rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView tv_rol;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}