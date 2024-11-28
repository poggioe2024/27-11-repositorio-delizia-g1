namespace CapaPresentacion
{
    partial class RecepcionMenu
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
            btn_nuevopedido = new Button();
            btn_salir = new Button();
            panel1 = new Panel();
            lbl_cedula = new Label();
            btn_seguimiento = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_nuevopedido
            // 
            btn_nuevopedido.BackColor = Color.FromArgb(238, 198, 6);
            btn_nuevopedido.FlatStyle = FlatStyle.Popup;
            btn_nuevopedido.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_nuevopedido.ForeColor = SystemColors.ControlText;
            btn_nuevopedido.Location = new Point(17, 118);
            btn_nuevopedido.Name = "btn_nuevopedido";
            btn_nuevopedido.Size = new Size(177, 45);
            btn_nuevopedido.TabIndex = 0;
            btn_nuevopedido.Text = "Nuevo pedido";
            btn_nuevopedido.UseVisualStyleBackColor = false;
            btn_nuevopedido.Click += btn_nuevopedido_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.FromArgb(192, 0, 0);
            btn_salir.FlatStyle = FlatStyle.Popup;
            btn_salir.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_salir.ForeColor = SystemColors.ControlLightLight;
            btn_salir.Location = new Point(17, 220);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(177, 45);
            btn_salir.TabIndex = 1;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 22, 22);
            panel1.Controls.Add(btn_seguimiento);
            panel1.Controls.Add(lbl_cedula);
            panel1.Controls.Add(btn_salir);
            panel1.Controls.Add(btn_nuevopedido);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 420);
            panel1.TabIndex = 7;
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.Font = new Font("OpenDyslexic 3", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cedula.ForeColor = SystemColors.ControlLightLight;
            lbl_cedula.Location = new Point(17, 29);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(160, 42);
            lbl_cedula.TabIndex = 0;
            lbl_cedula.Text = "Recepción";
            // 
            // btn_seguimiento
            // 
            btn_seguimiento.BackColor = Color.FromArgb(238, 198, 6);
            btn_seguimiento.FlatStyle = FlatStyle.Popup;
            btn_seguimiento.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_seguimiento.Location = new Point(17, 169);
            btn_seguimiento.Name = "btn_seguimiento";
            btn_seguimiento.Size = new Size(177, 45);
            btn_seguimiento.TabIndex = 3;
            btn_seguimiento.Text = "Seguimiento";
            btn_seguimiento.UseVisualStyleBackColor = false;
            btn_seguimiento.Click += btn_seguimiento_Click;
            // 
            // RecepcionMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "RecepcionMenu";
            Size = new Size(776, 426);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_nuevopedido;
        private Button btn_salir;
        private Panel panel1;
        private Label lbl_cedula;
        private Button btn_seguimiento;
    }
}
