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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CapaPresentacion
{
    public partial class AdministracionUsuariosModificar : UserControl
    {
        Funcionario user;
        Ventana padre;
        public AdministracionUsuariosModificar(Ventana padre, Funcionario user)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;

            int x = 800 / 2 - this.Width / 2;
            int y = 560 / 2 - this.Height / 2;

            Location = new Point(x, y);
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Funcionario nf = recopilar_datos();
            LAdministracion lAdministracion = new LAdministracion();
            lAdministracion.GenerarConsultaActualizar(nf);
        }

        public Funcionario recopilar_datos()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.cedula = txt_cedula.Text;
            funcionario.nombre = txt_nombre.Text;
            funcionario.apellido = txt_apellido.Text;
            funcionario.telefono = txt_telefono.Text;

            funcionario.contrasena = txt_contrasena.Text;
            funcionario.correo = txt_correo.Text;

            funcionario.direccion = txt_direccion.Text;

            funcionario.rol = int.Parse(menu_rol.Text);

            if (btn_activo_si.Checked)
            {
                funcionario.activo = "Si";
            }
            else
            {
                funcionario.activo = "No";
            }
            return funcionario;
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new AdministracionMenu(padre, user));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.cedula = txt_cedula.Text;

            LAdministracion lAdministracion = new LAdministracion();
            funcionario = lAdministracion.modificacion_obtener_funcionario(funcionario.cedula);

            // Asignar valores de Funcionario a los controles
            txt_cedula.Text = funcionario.cedula;
            txt_nombre.Text = funcionario.nombre;
            txt_apellido.Text = funcionario.apellido;
            txt_telefono.Text = funcionario.telefono;

            txt_contrasena.Text = funcionario.contrasena;
            txt_correo.Text = funcionario.correo;

            txt_direccion.Text = funcionario.direccion;

            // Convertir el entero del rol a texto
            menu_rol.Text = funcionario.rol.ToString();

            if (funcionario.activo == "Si")
            {
                btn_activo_si.Checked = true;
                btn_activo_no.Checked = false;
            }
            else
            {
                btn_activo_no.Checked = true;
                btn_activo_si.Checked = false;
            }
        }
    }
}
