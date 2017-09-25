namespace DecisionSupportSystem.Mantenimiento
{
    partial class frm_mant_roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mant_roles));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_usuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_rol_disponible = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lv_rol_asignado = new System.Windows.Forms.ListView();
            this.btn_d_right = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_d_left = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_usuarios);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un usuario";
            // 
            // cmb_usuarios
            // 
            this.cmb_usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_usuarios.FormattingEnabled = true;
            this.cmb_usuarios.Location = new System.Drawing.Point(51, 19);
            this.cmb_usuarios.Name = "cmb_usuarios";
            this.cmb_usuarios.Size = new System.Drawing.Size(192, 21);
            this.cmb_usuarios.TabIndex = 1;
            this.cmb_usuarios.SelectedValueChanged += new System.EventHandler(this.cmb_usuarios_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_rol_disponible);
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roles disponibles";
            // 
            // lv_rol_disponible
            // 
            this.lv_rol_disponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_rol_disponible.Location = new System.Drawing.Point(3, 16);
            this.lv_rol_disponible.Name = "lv_rol_disponible";
            this.lv_rol_disponible.Size = new System.Drawing.Size(469, 281);
            this.lv_rol_disponible.TabIndex = 2;
            this.lv_rol_disponible.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lv_rol_asignado);
            this.groupBox3.Location = new System.Drawing.Point(509, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 300);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Roles asignados";
            // 
            // lv_rol_asignado
            // 
            this.lv_rol_asignado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_rol_asignado.Location = new System.Drawing.Point(3, 16);
            this.lv_rol_asignado.Name = "lv_rol_asignado";
            this.lv_rol_asignado.Size = new System.Drawing.Size(469, 281);
            this.lv_rol_asignado.TabIndex = 1;
            this.lv_rol_asignado.UseCompatibleStateImageBehavior = false;
            // 
            // btn_d_right
            // 
            this.btn_d_right.Image = ((System.Drawing.Image)(resources.GetObject("btn_d_right.Image")));
            this.btn_d_right.Location = new System.Drawing.Point(478, 97);
            this.btn_d_right.Name = "btn_d_right";
            this.btn_d_right.Size = new System.Drawing.Size(28, 30);
            this.btn_d_right.TabIndex = 3;
            this.btn_d_right.UseVisualStyleBackColor = true;
            this.btn_d_right.Click += new System.EventHandler(this.btn_d_right_Click);
            // 
            // btn_right
            // 
            this.btn_right.Image = ((System.Drawing.Image)(resources.GetObject("btn_right.Image")));
            this.btn_right.Location = new System.Drawing.Point(478, 155);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(28, 30);
            this.btn_right.TabIndex = 4;
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.Image = ((System.Drawing.Image)(resources.GetObject("btn_left.Image")));
            this.btn_left.Location = new System.Drawing.Point(478, 213);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(28, 30);
            this.btn_left.TabIndex = 5;
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_d_left
            // 
            this.btn_d_left.Image = ((System.Drawing.Image)(resources.GetObject("btn_d_left.Image")));
            this.btn_d_left.Location = new System.Drawing.Point(478, 271);
            this.btn_d_left.Name = "btn_d_left";
            this.btn_d_left.Size = new System.Drawing.Size(28, 30);
            this.btn_d_left.TabIndex = 6;
            this.btn_d_left.UseVisualStyleBackColor = true;
            this.btn_d_left.Click += new System.EventHandler(this.btn_d_left_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(440, 355);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(105, 32);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "&GUARDAR";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // frm_mant_roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 392);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_d_left);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_d_right);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_mant_roles";
            this.Text = "Mantenimiento de roles por usuario";
            this.Load += new System.EventHandler(this.frm_mant_roles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lv_rol_asignado;
        private System.Windows.Forms.Button btn_d_right;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_d_left;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ListView lv_rol_disponible;
    }
}