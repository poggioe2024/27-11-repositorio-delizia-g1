using CapaDatos;
using CapaLogica;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AdmininistracionProductos : UserControl
    {
        Ventana padre;
        Funcionario user;
        public AdmininistracionProductos(Ventana padre, Funcionario user)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new AdministracionMenu(padre, user));
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            LAdministracion l = new LAdministracion();
            string consulta = "INSERT INTO `productos`(`Nombre`, `Precio`, `Tipo`) VALUES ('" + txt_nombre.Text + "','" + double.Parse(txt_precio.Text) + "','" + int.Parse(txt_tipo.Text) + "')";
            l.agregar_productos(consulta);
        }
    }
}
