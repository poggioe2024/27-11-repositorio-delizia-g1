namespace CapaPresentacion
{
    partial class AdministracionUsuariosAgregar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            label10 = new Label();
            label8 = new Label();
            menu_rol = new NumericUpDown();
            label4 = new Label();
            txt_correo = new TextBox();
            btn_activo_si = new RadioButton();
            label7 = new Label();
            txt_contrasena = new TextBox();
            btn_activo_no = new RadioButton();
            txt_telefono = new TextBox();
            lbl_activo = new Label();
            panel2 = new Panel();
            label9 = new Label();
            label1 = new Label();
            txt_cedula = new TextBox();
            label2 = new Label();
            txt_nombre = new TextBox();
            label3 = new Label();
            txt_apellido = new TextBox();
            label6 = new Label();
            txt_direccion = new TextBox();
            btn_ingresar = new Button();
            btn_anterior = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_rol).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_ingresar);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 469);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(65, 65, 65);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(menu_rol);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txt_correo);
            panel3.Controls.Add(btn_activo_si);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txt_contrasena);
            panel3.Controls.Add(btn_activo_no);
            panel3.Controls.Add(txt_telefono);
            panel3.Controls.Add(lbl_activo);
            panel3.Location = new Point(394, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(373, 414);
            panel3.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(21, 291);
            label5.Name = "label5";
            label5.Size = new Size(41, 25);
            label5.TabIndex = 12;
            label5.Text = "Rol";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("OpenDyslexic 3", 17.9999981F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(10, 10);
            label10.Name = "label10";
            label10.Size = new Size(247, 42);
            label10.TabIndex = 22;
            label10.Text = "Datos de inicio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(10, 68);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 14;
            label8.Text = "Teléfono";
            // 
            // menu_rol
            // 
            menu_rol.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            menu_rol.Location = new Point(21, 319);
            menu_rol.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            menu_rol.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            menu_rol.Name = "menu_rol";
            menu_rol.Size = new Size(120, 34);
            menu_rol.TabIndex = 20;
            menu_rol.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(10, 133);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 6;
            label4.Text = "Correo";
            // 
            // txt_correo
            // 
            txt_correo.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            txt_correo.Location = new Point(10, 161);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(225, 34);
            txt_correo.TabIndex = 7;
            // 
            // btn_activo_si
            // 
            btn_activo_si.AutoSize = true;
            btn_activo_si.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            btn_activo_si.ForeColor = SystemColors.ControlLightLight;
            btn_activo_si.Location = new Point(187, 319);
            btn_activo_si.Name = "btn_activo_si";
            btn_activo_si.Size = new Size(48, 29);
            btn_activo_si.TabIndex = 17;
            btn_activo_si.TabStop = true;
            btn_activo_si.Text = "Sí";
            btn_activo_si.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(10, 198);
            label7.Name = "label7";
            label7.Size = new Size(109, 25);
            label7.TabIndex = 8;
            label7.Text = "Contraseña";
            // 
            // txt_contrasena
            // 
            txt_contrasena.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            txt_contrasena.Location = new Point(10, 226);
            txt_contrasena.Name = "txt_contrasena";
            txt_contrasena.Size = new Size(225, 34);
            txt_contrasena.TabIndex = 9;
            // 
            // btn_activo_no
            // 
            btn_activo_no.AutoSize = true;
            btn_activo_no.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            btn_activo_no.ForeColor = SystemColors.ControlLightLight;
            btn_activo_no.Location = new Point(241, 319);
            btn_activo_no.Name = "btn_activo_no";
            btn_activo_no.Size = new Size(52, 29);
            btn_activo_no.TabIndex = 18;
            btn_activo_no.TabStop = true;
            btn_activo_no.Text = "No";
            btn_activo_no.UseVisualStyleBackColor = true;
            // 
            // txt_telefono
            // 
            txt_telefono.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            txt_telefono.Location = new Point(10, 96);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(225, 34);
            txt_telefono.TabIndex = 15;
            // 
            // lbl_activo
            // 
            lbl_activo.AutoSize = true;
            lbl_activo.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            lbl_activo.ForeColor = SystemColors.ControlLightLight;
            lbl_activo.Location = new Point(189, 291);
            lbl_activo.Name = "lbl_activo";
            lbl_activo.Size = new Size(68, 25);
            lbl_activo.TabIndex = 19;
            lbl_activo.Text = "Activo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(65, 65, 65);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_cedula);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_nombre);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_apellido);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_direccion);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 414);
            panel2.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("OpenDyslexic 3", 17.9999981F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(10, 10);
            label9.Name = "label9";
            label9.Size = new Size(272, 42);
            label9.TabIndex = 22;
            label9.Text = "Datos personales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(10, 68);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 0;
            label1.Text = "Cédula";
            // 
            // txt_cedula
            // 
            txt_cedula.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            txt_cedula.Location = new Point(10, 96);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(358, 34);
            txt_cedula.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(10, 133);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            txt_nombre.Location = new Point(10, 161);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(358, 34);
            txt_nombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(10, 198);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // txt_apellido
            // 
            txt_apellido.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            txt_apellido.Location = new Point(10, 226);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(358, 34);
            txt_apellido.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(10, 263);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 10;
            label6.Text = "Dirección";
            // 
            // txt_direccion
            // 
            txt_direccion.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            txt_direccion.Location = new Point(10, 291);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(358, 34);
            txt_direccion.TabIndex = 11;
            // 
            // btn_ingresar
            // 
            btn_ingresar.Location = new Point(299, 421);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(177, 45);
            btn_ingresar.TabIndex = 16;
            btn_ingresar.Text = "Crear usuario";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // btn_anterior
            // 
            btn_anterior.BackColor = Color.FromArgb(192, 0, 0);
            btn_anterior.FlatStyle = FlatStyle.Popup;
            btn_anterior.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_anterior.ForeColor = SystemColors.ControlLightLight;
            btn_anterior.Location = new Point(6, 478);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(177, 45);
            btn_anterior.TabIndex = 27;
            btn_anterior.Text = "Anterior";
            btn_anterior.UseVisualStyleBackColor = false;
            btn_anterior.Click += btn_anterior_Click;
            // 
            // AdministracionUsuariosAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            Controls.Add(btn_anterior);
            Controls.Add(panel1);
            Name = "AdministracionUsuariosAgregar";
            Size = new Size(776, 526);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menu_rol).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TextBox txt_direccion;
        private Label label6;
        private TextBox txt_contrasena;
        private Label label7;
        private TextBox txt_correo;
        private Label label4;
        private TextBox txt_apellido;
        private Label label3;
        private TextBox txt_nombre;
        private Label label2;
        private TextBox txt_cedula;
        private Label label1;
        private TextBox txt_telefono;
        private Label label8;
        private Button btn_ingresar;
        private RadioButton btn_activo_no;
        private RadioButton btn_activo_si;
        private NumericUpDown menu_rol;
        private Label lbl_activo;
        private Panel panel3;
        private Label label10;
        private Panel panel2;
        private Label label9;
        private Button btn_anterior;
    }
}
