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
    public partial class AdministracionMenu : UserControl
    {
        Ventana padre;
        Funcionario user;
        public AdministracionMenu(Ventana padre, Funcionario user)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;
            int x = 800 / 2 - this.Width / 2;
            int y = 560 / 2 - this.Height / 2;

            Location = new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new Login(padre));
        }

        private void btn_agregar_usuario_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new AdministracionUsuariosAgregar(padre, user));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new AdmininistracionProductos(padre, user));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new AdministracionUsuariosModificar(padre, user));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new Seguimiento(padre, user, this));
        }
    }
}
