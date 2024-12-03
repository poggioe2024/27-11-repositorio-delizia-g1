using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class RecepcionMenu : UserControl
    {
        Ventana padre;
        Funcionario user;
        int idioma;
        //238, 198, 6
        public RecepcionMenu(Ventana padre, Funcionario user, int idioma)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;
            this.idioma = idioma;

            int x = 800 / 2 - this.Width / 2;
            int y = 560 / 2 - this.Height / 2;

            Location = new Point(x, y);

            if (idioma == 1)
            {
                lbl_cedula.Text = "Front desk";
                btn_nuevopedido.Text = "New order";
                btn_seguimiento.Text = "Tracking";
                btn_salir.Text = "Exit";
            }
        }

        public RecepcionMenu(Ventana padre, Funcionario user)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;

            int x = 800 / 2 - this.Width / 2;
            int y = 560 / 2 - this.Height / 2;

            Location = new Point(x, y);
        }

        private void btn_nuevopedido_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new RecepcionSeleccion(padre, user, null, idioma));
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new Login(padre, idioma));
        }

        private void btn_seguimiento_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new Seguimiento(padre, user, idioma));
        }
    }
}
