namespace CapaPresentacion
{
    partial class RecepcionSeleccion
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
            btn_siguiente = new Button();
            pan_productos = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_siguiente
            // 
            btn_siguiente.BackColor = Color.FromArgb(0, 192, 0);
            btn_siguiente.FlatStyle = FlatStyle.Popup;
            btn_siguiente.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_siguiente.ForeColor = SystemColors.ControlLightLight;
            btn_siguiente.Location = new Point(596, 478);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(177, 45);
            btn_siguiente.TabIndex = 1;
            btn_siguiente.Text = "Siguiente";
            btn_siguiente.UseVisualStyleBackColor = false;
            btn_siguiente.Click += btn_siguiente_Click;
            // 
            // pan_productos
            // 
            pan_productos.AutoScroll = true;
            pan_productos.AutoScrollMargin = new Size(10, 10);
            pan_productos.BackColor = Color.FromArgb(65, 65, 65);
            pan_productos.Location = new Point(3, 3);
            pan_productos.Name = "pan_productos";
            pan_productos.Size = new Size(770, 469);
            pan_productos.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(3, 478);
            button1.Name = "button1";
            button1.Size = new Size(177, 45);
            button1.TabIndex = 5;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RecepcionSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            Controls.Add(button1);
            Controls.Add(pan_productos);
            Controls.Add(btn_siguiente);
            Name = "RecepcionSeleccion";
            Size = new Size(776, 526);
            Load += RecepcionSeleccion_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btn_siguiente;
        private Panel pan_productos;
        private Button button1;
    }
}
