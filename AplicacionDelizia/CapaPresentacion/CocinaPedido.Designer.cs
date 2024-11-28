namespace CapaPresentacion
{
    partial class CocinaPedido
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
            pan_productos = new Panel();
            btn_cambiar_estado = new Button();
            lbl_id = new Label();
            SuspendLayout();
            // 
            // pan_productos
            // 
            pan_productos.Location = new Point(3, 35);
            pan_productos.Name = "pan_productos";
            pan_productos.Size = new Size(179, 133);
            pan_productos.TabIndex = 0;
            // 
            // btn_cambiar_estado
            // 
            btn_cambiar_estado.BackColor = Color.FromArgb(0, 192, 0);
            btn_cambiar_estado.FlatStyle = FlatStyle.Popup;
            btn_cambiar_estado.Font = new Font("OpenDyslexic 3", 8.999998F, FontStyle.Bold);
            btn_cambiar_estado.ForeColor = SystemColors.ControlLightLight;
            btn_cambiar_estado.Location = new Point(3, 174);
            btn_cambiar_estado.Name = "btn_cambiar_estado";
            btn_cambiar_estado.Size = new Size(179, 46);
            btn_cambiar_estado.TabIndex = 1;
            btn_cambiar_estado.Text = "ESTADO";
            btn_cambiar_estado.UseVisualStyleBackColor = false;
            btn_cambiar_estado.Click += btn_cambiar_estado_Click;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("OpenDyslexic 3", 8.999998F, FontStyle.Bold);
            lbl_id.Location = new Point(3, 11);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(119, 21);
            lbl_id.TabIndex = 2;
            lbl_id.Text = "Id del pedido";
            lbl_id.Click += lbl_id_Click;
            // 
            // CocinaPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            Controls.Add(lbl_id);
            Controls.Add(btn_cambiar_estado);
            Controls.Add(pan_productos);
            Name = "CocinaPedido";
            Size = new Size(185, 223);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pan_productos;
        private Button btn_cambiar_estado;
        private Label lbl_id;
    }
}
