namespace CapaPresentacion
{
    partial class AdmininistracionProductos
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
            label5 = new Label();
            label10 = new Label();
            label8 = new Label();
            txt_tipo = new NumericUpDown();
            label4 = new Label();
            txt_precio = new TextBox();
            txt_nombre = new TextBox();
            btn_ingresar = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txt_tipo).BeginInit();
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
            panel1.Controls.Add(btn_ingresar);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 469);
            panel1.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(65, 65, 65);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txt_tipo);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txt_precio);
            panel3.Controls.Add(txt_nombre);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(764, 414);
            panel3.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(10, 198);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 12;
            label5.Text = "Tipo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("OpenDyslexic 3", 17.9999981F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(10, 10);
            label10.Name = "label10";
            label10.Size = new Size(305, 42);
            label10.TabIndex = 22;
            label10.Text = "Datos del producto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(10, 68);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 14;
            label8.Text = "Nombre";
            // 
            // txt_tipo
            // 
            txt_tipo.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            txt_tipo.Location = new Point(10, 226);
            txt_tipo.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            txt_tipo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txt_tipo.Name = "txt_tipo";
            txt_tipo.Size = new Size(120, 34);
            txt_tipo.TabIndex = 20;
            txt_tipo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(10, 133);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            // 
            // txt_precio
            // 
            txt_precio.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            txt_precio.Location = new Point(10, 161);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(364, 34);
            txt_precio.TabIndex = 7;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            txt_nombre.Location = new Point(10, 96);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(364, 34);
            txt_nombre.TabIndex = 15;
            // 
            // btn_ingresar
            // 
            btn_ingresar.Location = new Point(299, 421);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(177, 45);
            btn_ingresar.TabIndex = 16;
            btn_ingresar.Text = "Crear producto";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // AdmininistracionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            Controls.Add(panel1);
            Controls.Add(btn_anterior);
            Name = "AdmininistracionProductos";
            Size = new Size(776, 526);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txt_tipo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_anterior;
        private Panel panel1;
        private Button btn_ingresar;
        private Panel panel3;
        private Label label5;
        private Label label10;
        private Label label8;
        private NumericUpDown txt_tipo;
        private Label label4;
        private TextBox txt_precio;
        private TextBox txt_nombre;
    }
}
