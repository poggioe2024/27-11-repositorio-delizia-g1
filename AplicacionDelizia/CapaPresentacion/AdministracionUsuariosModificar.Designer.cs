namespace CapaPresentacion
{
    partial class AdministracionUsuariosModificar
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
            btn_anterior = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            activo = new GroupBox();
            btn_activo_si = new RadioButton();
            btn_activo_no = new RadioButton();
            label5 = new Label();
            label10 = new Label();
            label8 = new Label();
            menu_rol = new NumericUpDown();
            label4 = new Label();
            txt_correo = new TextBox();
            label7 = new Label();
            txt_contrasena = new TextBox();
            txt_telefono = new TextBox();
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
            btn_modificar = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            activo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_rol).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_anterior
            // 
            btn_anterior.BackColor = Color.FromArgb(192, 0, 0);
            btn_anterior.FlatStyle = FlatStyle.Popup;
            btn_anterior.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_anterior.ForeColor = SystemColors.ControlLightLight;
            btn_anterior.Location = new Point(3, 478);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(177, 45);
            btn_anterior.TabIndex = 28;
            btn_anterior.Text = "Anterior";
            btn_anterior.UseVisualStyleBackColor = false;
            btn_anterior.Click += btn_anterior_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_modificar);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 469);
            panel1.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(65, 65, 65);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(activo);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(menu_rol);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txt_correo);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txt_contrasena);
            panel3.Controls.Add(txt_telefono);
            panel3.Location = new Point(394, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(373, 414);
            panel3.TabIndex = 23;
            // 
            // activo
            // 
            activo.Controls.Add(btn_activo_si);
            activo.Controls.Add(btn_activo_no);
            activo.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            activo.ForeColor = SystemColors.ControlLightLight;
            activo.Location = new Point(147, 279);
            activo.Name = "activo";
            activo.Size = new Size(200, 100);
            activo.TabIndex = 23;
            activo.TabStop = false;
            activo.Text = "Activo";
            // 
            // btn_activo_si
            // 
            btn_activo_si.AutoSize = true;
            btn_activo_si.Checked = true;
            btn_activo_si.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            btn_activo_si.ForeColor = SystemColors.ControlLightLight;
            btn_activo_si.Location = new Point(15, 30);
            btn_activo_si.Name = "btn_activo_si";
            btn_activo_si.Size = new Size(48, 29);
            btn_activo_si.TabIndex = 17;
            btn_activo_si.TabStop = true;
            btn_activo_si.Text = "Sí";
            btn_activo_si.UseVisualStyleBackColor = true;
            // 
            // btn_activo_no
            // 
            btn_activo_no.AutoSize = true;
            btn_activo_no.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            btn_activo_no.ForeColor = SystemColors.ControlLightLight;
            btn_activo_no.Location = new Point(110, 30);
            btn_activo_no.Name = "btn_activo_no";
            btn_activo_no.Size = new Size(52, 29);
            btn_activo_no.TabIndex = 18;
            btn_activo_no.Text = "No";
            btn_activo_no.UseVisualStyleBackColor = true;
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
            // txt_telefono
            // 
            txt_telefono.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            txt_telefono.Location = new Point(10, 96);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(225, 34);
            txt_telefono.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(65, 65, 65);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
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
            txt_cedula.Size = new Size(292, 34);
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
            // btn_modificar
            // 
            btn_modificar.Location = new Point(299, 421);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(177, 45);
            btn_modificar.TabIndex = 16;
            btn_modificar.Text = "Modificar usuario";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_ingresar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(308, 96);
            button1.Name = "button1";
            button1.Size = new Size(60, 34);
            button1.TabIndex = 24;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdministracionUsuariosModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            Controls.Add(panel1);
            Controls.Add(btn_anterior);
            Name = "AdministracionUsuariosModificar";
            Size = new Size(776, 526);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            activo.ResumeLayout(false);
            activo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menu_rol).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_anterior;
        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private Label label10;
        private Label label8;
        private NumericUpDown menu_rol;
        private Label label4;
        private TextBox txt_correo;
        private RadioButton btn_activo_si;
        private Label label7;
        private TextBox txt_contrasena;
        private RadioButton btn_activo_no;
        private TextBox txt_telefono;
        private Panel panel2;
        private Label label9;
        private Label label1;
        private TextBox txt_cedula;
        private Label label2;
        private TextBox txt_nombre;
        private Label label3;
        private TextBox txt_apellido;
        private Label label6;
        private TextBox txt_direccion;
        private Button btn_modificar;
        private GroupBox activo;
        private Button button1;
    }
}
