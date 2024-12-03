namespace CapaPresentacion
{
    partial class RepartoMenu
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
            btn_mis_pedidos = new Button();
            btn_tomar_pedidos = new Button();
            panel1 = new Panel();
            lbl_cedula = new Label();
            btn_salir = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_mis_pedidos
            // 
            btn_mis_pedidos.BackColor = Color.FromArgb(238, 198, 6);
            btn_mis_pedidos.FlatStyle = FlatStyle.Popup;
            btn_mis_pedidos.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_mis_pedidos.Location = new Point(17, 118);
            btn_mis_pedidos.Name = "btn_mis_pedidos";
            btn_mis_pedidos.Size = new Size(177, 45);
            btn_mis_pedidos.TabIndex = 0;
            btn_mis_pedidos.Text = "Mis pedidos";
            btn_mis_pedidos.UseVisualStyleBackColor = false;
            btn_mis_pedidos.Click += btn_mis_pedidos_Click;
            // 
            // btn_tomar_pedidos
            // 
            btn_tomar_pedidos.BackColor = Color.FromArgb(238, 198, 6);
            btn_tomar_pedidos.FlatStyle = FlatStyle.Popup;
            btn_tomar_pedidos.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_tomar_pedidos.Location = new Point(17, 169);
            btn_tomar_pedidos.Name = "btn_tomar_pedidos";
            btn_tomar_pedidos.Size = new Size(177, 45);
            btn_tomar_pedidos.TabIndex = 1;
            btn_tomar_pedidos.Text = "Tomar pedidos";
            btn_tomar_pedidos.UseVisualStyleBackColor = false;
            btn_tomar_pedidos.Click += btn_tomar_pedidos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 22, 22);
            panel1.Controls.Add(lbl_cedula);
            panel1.Controls.Add(btn_tomar_pedidos);
            panel1.Controls.Add(btn_salir);
            panel1.Controls.Add(btn_mis_pedidos);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 520);
            panel1.TabIndex = 8;
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.Font = new Font("OpenDyslexic 3", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cedula.ForeColor = SystemColors.ControlLightLight;
            lbl_cedula.Location = new Point(17, 29);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(129, 42);
            lbl_cedula.TabIndex = 0;
            lbl_cedula.Text = "Reparto";
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
            btn_salir.Click += btn_salir_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.delizia_logo;
            pictureBox1.Location = new Point(461, 337);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // RepartoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "RepartoMenu";
            Size = new Size(776, 526);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_mis_pedidos;
        private Button btn_tomar_pedidos;
        private Panel panel1;
        private Label lbl_cedula;
        private Button btn_salir;
        private PictureBox pictureBox1;
    }
}
