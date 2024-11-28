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
    public partial class Login : UserControl
    {
        Ventana padre;
        public Login(Ventana padre)
        {
            InitializeComponent();
            this.padre = padre;
            // 816, 489

            int x = 800 / 2 - this.Width / 2;
            int y = 560 / 2 - this.Height / 2;

            Location = new Point(x, y);
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            int rol_usuario;

            try
            {
                // obtenemos los datos del inicio
                string cedula_ingresada = txt_cedula.Text;
                string contrasena_ingresada = txt_contrasena.Text;

                LLogin llogin = new LLogin();

                // MessageBox.Show("", llogin.testing());

                // obtenemos los datos del usuario que se loguea

                Funcionario sesion_actual = llogin.check_usuario(cedula_ingresada, contrasena_ingresada);

                if (sesion_actual != null) // si no devuelve null obtiene el rol del usuario
                {
                    rol_usuario = sesion_actual.rol;
                }
                else // si devuelve null establece rol a -1 y da error
                {
                    rol_usuario = -1;
                }

                switch (rol_usuario)
                {
                    case -2:
                        MessageBox.Show("Contraseña incorrecta. Por favor intente de nuevo.", "ERROR");
                        break;
                    case -1:
                        MessageBox.Show("Usuario inactivo. Si se trata de un error consulte con su supervisor.", "ERROR");
                        break;
                    case 1:
                        this.Dispose(); // elimina el login de la memoria
                        padre.Controls.Remove(this); // elimina visualmente el login

                        llogin.registrar_log(sesion_actual); // registra el inicio de sesion
                        padre.Controls.Add(new RecepcionMenu(padre, sesion_actual)); // da acceso a la app de recepcion
                        break;
                    case 2:
                        this.Dispose(); // elimina el login de la memoria
                        padre.Controls.Remove(this); // elimina visualmente el login

                        llogin.registrar_log(sesion_actual); // registra el inicio de sesion
                        padre.Controls.Add(new CocinaMenu(padre, sesion_actual)); // da acceso a la app de cocina
                        break;
                    case 3:
                        this.Dispose(); // elimina el login de la memoria
                        padre.Controls.Remove(this); // elimina visualmente el login

                        llogin.registrar_log(sesion_actual); // registra el inicio de sesion
                        padre.Controls.Add(new RepartoMenu(padre, sesion_actual)); // da acceso a la app de reparto
                        break;
                    case 4:
                        this.Dispose(); // elimina el login de la memoria
                        padre.Controls.Remove(this); // elimina visualmente el login

                        llogin.registrar_log(sesion_actual); // registra el inicio de sesion
                        padre.Controls.Add(new AdministracionMenu(padre, sesion_actual)); // da acceso a la app de reparto
                        break;
                    default:
                        // muestra un mensaje de error
                        MessageBox.Show("Error desconocido.", "ERROR");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos de usuario incompletos o incorrectos. Intente de nuevo.", "ERROR");
            }


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_cedula.Text = string.Empty; // borra el texto en cedula
            txt_contrasena.Text = string.Empty; // borra el texto en contraseña
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c = "" + txt_contrasena.PasswordChar;
            if (c == "*")
            {
                txt_contrasena.PasswordChar = '\0';
            }
            else
            {
                txt_contrasena.PasswordChar = '*';
            }
        }
    }
}
