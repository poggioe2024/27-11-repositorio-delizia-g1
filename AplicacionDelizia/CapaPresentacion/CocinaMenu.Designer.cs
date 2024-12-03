namespace CapaPresentacion
{
    partial class CocinaMenu
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
            btn_verpedidos = new Button();
            panel1 = new Panel();
            lbl_cedula = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_verpedidos
            // 
            btn_verpedidos.BackColor = Color.FromArgb(238, 198, 6);
            btn_verpedidos.FlatStyle = FlatStyle.Popup;
            btn_verpedidos.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_verpedidos.Location = new Point(17, 118);
            btn_verpedidos.Name = "btn_verpedidos";
            btn_verpedidos.Size = new Size(177, 45);
            btn_verpedidos.TabIndex = 0;
            btn_verpedidos.Text = "Ver pedidos";
            btn_verpedidos.UseVisualStyleBackColor = false;
            btn_verpedidos.Click += btn_verpedidos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 22, 22);
            panel1.Controls.Add(lbl_cedula);
            panel1.Controls.Add(btn_verpedidos);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 520);
            panel1.TabIndex = 9;
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
            lbl_cedula.Text = "Cocina";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(17, 169);
            button1.Name = "button1";
            button1.Size = new Size(177, 45);
            button1.TabIndex = 1;
            button1.Text = "Salir";
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
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // CocinaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "CocinaMenu";
            Size = new Size(776, 526);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_verpedidos;
        private Panel panel1;
        private Label lbl_cedula;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
