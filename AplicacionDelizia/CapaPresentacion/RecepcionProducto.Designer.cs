namespace CapaPresentacion
{
    partial class RecepcionProducto
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
            btn_restar = new Button();
            btn_sumar = new Button();
            lbl_cantidad = new Label();
            lbl_precio = new Label();
            png_producto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)png_producto).BeginInit();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Dock = DockStyle.Top;
            lbl_nombre.Font = new Font("OpenDyslexic 3", 9.999998F, FontStyle.Bold);
            lbl_nombre.Location = new Point(0, 0);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(202, 25);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre del producto";
            // 
            // btn_restar
            // 
            btn_restar.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_restar.Location = new Point(3, 207);
            btn_restar.Name = "btn_restar";
            btn_restar.Size = new Size(40, 40);
            btn_restar.TabIndex = 1;
            btn_restar.Text = "-";
            btn_restar.UseVisualStyleBackColor = true;
            btn_restar.Click += btn_restar_Click;
            // 
            // btn_sumar
            // 
            btn_sumar.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            btn_sumar.Location = new Point(157, 207);
            btn_sumar.Name = "btn_sumar";
            btn_sumar.Size = new Size(40, 40);
            btn_sumar.TabIndex = 2;
            btn_sumar.Text = "+";
            btn_sumar.UseVisualStyleBackColor = true;
            btn_sumar.Click += btn_sumar_Click;
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            lbl_cantidad.Location = new Point(49, 207);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(102, 40);
            lbl_cantidad.TabIndex = 3;
            lbl_cantidad.Text = "0";
            lbl_cantidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_precio
            // 
            lbl_precio.Font = new Font("OpenDyslexic 3", 12.9999981F, FontStyle.Bold);
            lbl_precio.Location = new Point(49, 175);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(102, 32);
            lbl_precio.TabIndex = 4;
            lbl_precio.Text = "$Precio";
            lbl_precio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // png_producto
            // 
            png_producto.BackgroundImageLayout = ImageLayout.None;
            png_producto.Location = new Point(25, 28);
            png_producto.Name = "png_producto";
            png_producto.Size = new Size(150, 150);
            png_producto.TabIndex = 5;
            png_producto.TabStop = false;
            // 
            // RecepcionProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            Controls.Add(png_producto);
            Controls.Add(lbl_precio);
            Controls.Add(lbl_cantidad);
            Controls.Add(btn_sumar);
            Controls.Add(btn_restar);
            Controls.Add(lbl_nombre);
            Name = "RecepcionProducto";
            Size = new Size(200, 250);
            ((System.ComponentModel.ISupportInitialize)png_producto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nombre;
        private Button btn_restar;
        private Button btn_sumar;
        private Label lbl_cantidad;
        private Label lbl_precio;
        private PictureBox png_producto;
    }
}
