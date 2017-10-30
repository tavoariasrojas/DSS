namespace DecisionSupportSystem.Mantenimiento
{
    partial class frm_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_usuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_valida_clave = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nup_dias = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_cambiar_clave = new System.Windows.Forms.CheckBox();
            this.chk_conexiones = new System.Windows.Forms.CheckBox();
            this.chk_supervisor = new System.Windows.Forms.CheckBox();
            this.chk_auditoria = new System.Windows.Forms.CheckBox();
            this.chk_inactivo = new System.Windows.Forms.CheckBox();
            this.txt_clave_nueva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.axSupport_usuario = new AxSUPPORT1Lib.AxSupport1();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_dias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axSupport_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_usuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar usuario";
            // 
            // cmb_usuario
            // 
            this.cmb_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_usuario.FormattingEnabled = true;
            this.cmb_usuario.Location = new System.Drawing.Point(61, 21);
            this.cmb_usuario.Name = "cmb_usuario";
            this.cmb_usuario.Size = new System.Drawing.Size(271, 21);
            this.cmb_usuario.TabIndex = 0;
            this.cmb_usuario.SelectedValueChanged += new System.EventHandler(this.cmb_usuario_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_valida_clave);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txt_clave_nueva);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_usuario);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(0, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 348);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información sobre el usuario";
            // 
            // txt_valida_clave
            // 
            this.txt_valida_clave.Location = new System.Drawing.Point(125, 105);
            this.txt_valida_clave.MaxLength = 50;
            this.txt_valida_clave.Name = "txt_valida_clave";
            this.txt_valida_clave.PasswordChar = '*';
            this.txt_valida_clave.Size = new System.Drawing.Size(121, 20);
            this.txt_valida_clave.TabIndex = 3;
            this.txt_valida_clave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_valida_clave.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Verifica contraseña";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_fecha);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.nup_dias);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.chk_cambiar_clave);
            this.groupBox3.Controls.Add(this.chk_conexiones);
            this.groupBox3.Controls.Add(this.chk_supervisor);
            this.groupBox3.Controls.Add(this.chk_auditoria);
            this.groupBox3.Controls.Add(this.chk_inactivo);
            this.groupBox3.Location = new System.Drawing.Point(77, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 192);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuración adicional";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Enabled = false;
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(108, 16);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(80, 20);
            this.dtp_fecha.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fecha vencimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "días";
            // 
            // nup_dias
            // 
            this.nup_dias.Location = new System.Drawing.Point(114, 163);
            this.nup_dias.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nup_dias.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nup_dias.Name = "nup_dias";
            this.nup_dias.Size = new System.Drawing.Size(38, 20);
            this.nup_dias.TabIndex = 6;
            this.nup_dias.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cambiar clave cada";
            // 
            // chk_cambiar_clave
            // 
            this.chk_cambiar_clave.AutoSize = true;
            this.chk_cambiar_clave.Location = new System.Drawing.Point(68, 141);
            this.chk_cambiar_clave.Name = "chk_cambiar_clave";
            this.chk_cambiar_clave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_cambiar_clave.Size = new System.Drawing.Size(120, 17);
            this.chk_cambiar_clave.TabIndex = 4;
            this.chk_cambiar_clave.Text = "Cambiar contraseña";
            this.chk_cambiar_clave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_cambiar_clave.UseVisualStyleBackColor = true;
            // 
            // chk_conexiones
            // 
            this.chk_conexiones.AutoSize = true;
            this.chk_conexiones.Location = new System.Drawing.Point(64, 116);
            this.chk_conexiones.Name = "chk_conexiones";
            this.chk_conexiones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_conexiones.Size = new System.Drawing.Size(124, 17);
            this.chk_conexiones.TabIndex = 3;
            this.chk_conexiones.Text = "Conexiones múltiples";
            this.chk_conexiones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_conexiones.UseVisualStyleBackColor = true;
            // 
            // chk_supervisor
            // 
            this.chk_supervisor.AutoSize = true;
            this.chk_supervisor.Location = new System.Drawing.Point(112, 91);
            this.chk_supervisor.Name = "chk_supervisor";
            this.chk_supervisor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_supervisor.Size = new System.Drawing.Size(76, 17);
            this.chk_supervisor.TabIndex = 2;
            this.chk_supervisor.Text = "Supervisor";
            this.chk_supervisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_supervisor.UseVisualStyleBackColor = true;
            // 
            // chk_auditoria
            // 
            this.chk_auditoria.AutoSize = true;
            this.chk_auditoria.Location = new System.Drawing.Point(119, 66);
            this.chk_auditoria.Name = "chk_auditoria";
            this.chk_auditoria.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_auditoria.Size = new System.Drawing.Size(69, 17);
            this.chk_auditoria.TabIndex = 1;
            this.chk_auditoria.Text = "Auditoría";
            this.chk_auditoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_auditoria.UseVisualStyleBackColor = true;
            // 
            // chk_inactivo
            // 
            this.chk_inactivo.AutoSize = true;
            this.chk_inactivo.Location = new System.Drawing.Point(86, 41);
            this.chk_inactivo.Name = "chk_inactivo";
            this.chk_inactivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_inactivo.Size = new System.Drawing.Size(102, 17);
            this.chk_inactivo.TabIndex = 0;
            this.chk_inactivo.Text = "Usuario inactivo";
            this.chk_inactivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_inactivo.UseVisualStyleBackColor = true;
            // 
            // txt_clave_nueva
            // 
            this.txt_clave_nueva.Location = new System.Drawing.Point(125, 77);
            this.txt_clave_nueva.MaxLength = 50;
            this.txt_clave_nueva.Name = "txt_clave_nueva";
            this.txt_clave_nueva.PasswordChar = '*';
            this.txt_clave_nueva.Size = new System.Drawing.Size(121, 20);
            this.txt_clave_nueva.TabIndex = 2;
            this.txt_clave_nueva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_clave_nueva.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña de usuario";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(125, 49);
            this.txt_usuario.MaxLength = 30;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(121, 20);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código de usuario";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(125, 21);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(207, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre completo";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(118, 410);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(105, 32);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "&GUARDAR";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // axSupport_usuario
            // 
            this.axSupport_usuario.Enabled = true;
            this.axSupport_usuario.Location = new System.Drawing.Point(22, 406);
            this.axSupport_usuario.Name = "axSupport_usuario";
            this.axSupport_usuario.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSupport_usuario.OcxState")));
            this.axSupport_usuario.Size = new System.Drawing.Size(38, 36);
            this.axSupport_usuario.TabIndex = 9;
            // 
            // frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.axSupport_usuario);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_usuario";
            this.Text = "Mantenimiento de usuario";
            this.Load += new System.EventHandler(this.frm_usuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_dias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axSupport_usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nup_dias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_cambiar_clave;
        private System.Windows.Forms.CheckBox chk_conexiones;
        private System.Windows.Forms.CheckBox chk_supervisor;
        private System.Windows.Forms.CheckBox chk_auditoria;
        private System.Windows.Forms.CheckBox chk_inactivo;
        private System.Windows.Forms.TextBox txt_clave_nueva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_valida_clave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label8;
        private AxSUPPORT1Lib.AxSupport1 axSupport_usuario;
    }
}