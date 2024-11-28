namespace CapaPresentacion
{
    partial class SeguimientoPedido
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
            lbl_nombre = new Label();
            lbl_id = new Label();
            lbl_estado = new Label();
            pan_estado = new Panel();
            btn_cancelar = new Button();
            pan_estado.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("OpenDyslexic 3", 8.999998F, FontStyle.Bold);
            lbl_nombre.Location = new Point(12, 34);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(132, 21);
            lbl_nombre.TabIndex = 5;
            lbl_nombre.Text = "Nombre Cliente";
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("OpenDyslexic 3", 10.9999981F, FontStyle.Bold);
            lbl_id.Location = new Point(12, 3);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(103, 26);
            lbl_id.TabIndex = 4;
            lbl_id.Text = "Id Pedido";
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.Font = new Font("OpenDyslexic 3", 8.999998F, FontStyle.Bold);
            lbl_estado.Location = new Point(18, 13);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(75, 21);
            lbl_estado.TabIndex = 6;
            lbl_estado.Text = "ESTADO";
            // 
            // pan_estado
            // 
            pan_estado.Controls.Add(lbl_estado);
            pan_estado.Location = new Point(12, 71);
            pan_estado.Name = "pan_estado";
            pan_estado.Size = new Size(180, 44);
            pan_estado.TabIndex = 7;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(192, 0, 0);
            btn_cancelar.FlatStyle = FlatStyle.Popup;
            btn_cancelar.Font = new Font("OpenDyslexic 3", 8.999998F, FontStyle.Bold);
            btn_cancelar.ForeColor = SystemColors.ControlLightLight;
            btn_cancelar.Location = new Point(58, 129);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(96, 34);
            btn_cancelar.TabIndex = 8;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // SeguimientoPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            Controls.Add(btn_cancelar);
            Controls.Add(pan_estado);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_id);
            Name = "SeguimientoPedido";
            Size = new Size(209, 175);
            pan_estado.ResumeLayout(false);
            pan_estado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nombre;
        private Label lbl_id;
        private Label lbl_estado;
        private Panel pan_estado;
        private Button btn_cancelar;
    }
}
