namespace CapaPresentacion
{
    partial class AdministracionMenu
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
            lbl_cedula = new Label();
            btn_agregar_usuario = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 22, 22);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lbl_cedula);
            panel1.Controls.Add(btn_agregar_usuario);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 420);
            panel1.TabIndex = 10;
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.Font = new Font("OpenDyslexic 3", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cedula.ForeColor = SystemColors.ControlLightLight;
            lbl_cedula.Location = new Point(17, 29);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(226, 42);
            lbl_cedula.TabIndex = 0;
            lbl_cedula.Text = "Administración";
            // 
            // btn_agregar_usuario
            // 
            btn_agregar_usuario.BackColor = Color.FromArgb(238, 198, 6);
            btn_agregar_usuario.FlatStyle = FlatStyle.Popup;
            btn_agregar_usuario.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_agregar_usuario.Location = new Point(17, 118);
            btn_agregar_usuario.Name = "btn_agregar_usuario";
            btn_agregar_usuario.Size = new Size(238, 45);
            btn_agregar_usuario.TabIndex = 0;
            btn_agregar_usuario.Text = "Modificar Usuario";
            btn_agregar_usuario.UseVisualStyleBackColor = false;
            btn_agregar_usuario.Click += btn_agregar_usuario_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(17, 220);
            button1.Name = "button1";
            button1.Size = new Size(238, 45);
            button1.TabIndex = 1;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(238, 198, 6);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            button2.Location = new Point(17, 169);
            button2.Name = "button2";
            button2.Size = new Size(238, 45);
            button2.TabIndex = 2;
            button2.Text = "Modificar Producto";
            button2.UseVisualStyleBackColor = false;
            // 
            // AdministracionMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "AdministracionMenu";
            Size = new Size(776, 426);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_cedula;
        private Button btn_agregar_usuario;
        private Button button1;
        private Button button2;
    }
}
