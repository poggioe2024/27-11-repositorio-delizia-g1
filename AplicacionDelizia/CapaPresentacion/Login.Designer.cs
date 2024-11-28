namespace CapaPresentacion
{
    partial class Login
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
            lbl_cedula = new Label();
            lbl_contrasena = new Label();
            txt_cedula = new TextBox();
            txt_contrasena = new TextBox();
            btn_cancelar = new Button();
            btn_entrar = new Button();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.Font = new Font("OpenDyslexic 3", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cedula.ForeColor = SystemColors.ControlLightLight;
            lbl_cedula.Location = new Point(17, 29);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(112, 42);
            lbl_cedula.TabIndex = 0;
            lbl_cedula.Text = "Cédula";
            // 
            // lbl_contrasena
            // 
            lbl_contrasena.AutoSize = true;
            lbl_contrasena.Font = new Font("OpenDyslexic 3", 17.9999981F, FontStyle.Bold);
            lbl_contrasena.ForeColor = SystemColors.ControlLightLight;
            lbl_contrasena.Location = new Point(17, 147);
            lbl_contrasena.Name = "lbl_contrasena";
            lbl_contrasena.Size = new Size(177, 42);
            lbl_contrasena.TabIndex = 1;
            lbl_contrasena.Text = "Contraseña";
            // 
            // txt_cedula
            // 
            txt_cedula.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            txt_cedula.Location = new Point(17, 74);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(370, 42);
            txt_cedula.TabIndex = 2;
            // 
            // txt_contrasena
            // 
            txt_contrasena.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            txt_contrasena.Location = new Point(17, 192);
            txt_contrasena.Name = "txt_contrasena";
            txt_contrasena.PasswordChar = '*';
            txt_contrasena.Size = new Size(317, 42);
            txt_contrasena.TabIndex = 3;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(192, 0, 0);
            btn_cancelar.FlatStyle = FlatStyle.Popup;
            btn_cancelar.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_cancelar.ForeColor = SystemColors.ControlLightLight;
            btn_cancelar.Location = new Point(17, 456);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(177, 45);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.FromArgb(0, 192, 0);
            btn_entrar.FlatStyle = FlatStyle.Popup;
            btn_entrar.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_entrar.ForeColor = SystemColors.ControlLightLight;
            btn_entrar.Location = new Point(210, 456);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(177, 45);
            btn_entrar.TabIndex = 5;
            btn_entrar.Text = "Iniciar Sesión";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 22, 22);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lbl_cedula);
            panel1.Controls.Add(btn_entrar);
            panel1.Controls.Add(lbl_contrasena);
            panel1.Controls.Add(btn_cancelar);
            panel1.Controls.Add(txt_cedula);
            panel1.Controls.Add(txt_contrasena);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 520);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(343, 192);
            button1.Name = "button1";
            button1.Size = new Size(44, 42);
            button1.TabIndex = 6;
            button1.Text = "👁";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.delizia_logo;
            pictureBox1.Location = new Point(461, 337);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Login";
            Size = new Size(776, 526);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_cedula;
        private Label lbl_contrasena;
        private TextBox txt_cedula;
        private TextBox txt_contrasena;
        private Button btn_cancelar;
        private Button btn_entrar;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
