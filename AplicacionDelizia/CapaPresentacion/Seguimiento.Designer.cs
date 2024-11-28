namespace CapaPresentacion
{
    partial class Seguimiento
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
            btn_salir = new Button();
            pan_pedidos = new Panel();
            SuspendLayout();
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.FromArgb(192, 0, 0);
            btn_salir.FlatStyle = FlatStyle.Popup;
            btn_salir.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_salir.ForeColor = SystemColors.ControlLightLight;
            btn_salir.Location = new Point(3, 478);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(177, 45);
            btn_salir.TabIndex = 7;
            btn_salir.Text = "Atrás";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click_1;
            // 
            // pan_pedidos
            // 
            pan_pedidos.AutoScroll = true;
            pan_pedidos.AutoScrollMargin = new Size(10, 10);
            pan_pedidos.BackColor = Color.FromArgb(65, 65, 65);
            pan_pedidos.Location = new Point(3, 3);
            pan_pedidos.Name = "pan_pedidos";
            pan_pedidos.Size = new Size(770, 469);
            pan_pedidos.TabIndex = 6;
            // 
            // Seguimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            Controls.Add(btn_salir);
            Controls.Add(pan_pedidos);
            Name = "Seguimiento";
            Size = new Size(776, 526);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_salir;
        private Panel pan_pedidos;
    }
}
