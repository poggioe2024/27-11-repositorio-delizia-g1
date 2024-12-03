using CapaLogica;
using Mysqlx.Datatypes;
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
    public partial class Seguimiento : UserControl
    {
        Ventana padre;
        Funcionario user;

        private Thread hilo;
        private bool salir = false;

        List<Pedido> pedidos;
        List<SeguimientoPedido> pedidos_graficos = new List<SeguimientoPedido>();

        int idioma;
        public Seguimiento(Ventana padre, Funcionario user)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;

            int x = 800 / 2 - this.Width / 2;
            int y = 560 / 2 - this.Height / 2;

            Location = new Point(x, y);

            pedidos = new List<Pedido>();

            LReparto lreparto = new LReparto();
            pedidos = lreparto.obtener_pedidos_s();

            mostrar_pedidos(pedidos);
        }

        public Seguimiento(Ventana padre, Funcionario user, int idioma)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;

            int x = 800 / 2 - this.Width / 2;
            int y = 560 / 2 - this.Height / 2;

            Location = new Point(x, y);

            pedidos = new List<Pedido>();

            LReparto lreparto = new LReparto();
            pedidos = lreparto.obtener_pedidos_s();


            this.idioma = idioma;

            if (idioma == 1)
            {
                btn_salir.Text = "Back";
            }

            mostrar_pedidos(pedidos);

            hilo = new Thread(actualizar);
            hilo.Start();
        }

        public void actualizar()
        {
            while (salir != true)
            {
                Thread.Sleep(3000);

                LReparto lcocina = new LReparto();

                pedidos.Clear();
                pedidos = lcocina.obtener_pedidos_s();

                actualizar_pantalla();
            }
        }

        private void mostrar_pedidos(List<Pedido> pedidos)
        {
            int x = 5;
            int y = 20;
            int contador = 0;
            foreach (Pedido pedido in pedidos)
            {
                SeguimientoPedido cp = new SeguimientoPedido(this, pedido);
                if (contador % 3 == 0)
                {
                    if (contador == 0)
                    {
                        x = 5;
                        y = 20;
                    }
                    else
                    {
                        x = 5;
                        y += 5 + cp.Height;
                    }
                }
                else
                {
                    x += 5 + cp.Width;
                }
                cp.Location = new Point(x, y);
                contador++;
                pedidos_graficos.Add(cp);
            }

            foreach (SeguimientoPedido pedido in pedidos_graficos)
            {
                this.pan_pedidos.Controls.Add(pedido);
            }
        }

        public void actualizar_pantalla()
        {
            if (pan_pedidos.InvokeRequired)
            {
                pan_pedidos.Invoke(new Action(() =>
                {
                    pan_pedidos.Controls.Clear();

                    pedidos_graficos.Clear();

                    mostrar_pedidos(pedidos);
                }));
            }
            else
            {
                pan_pedidos.Controls.Clear();

                pedidos_graficos.Clear();

                mostrar_pedidos(pedidos);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            
        }

        public AdministracionMenu m;

        public Seguimiento(Ventana padre, Funcionario user, AdministracionMenu m)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;
            this.m = m;

            int x = 800 / 2 - this.Width / 2;
            int y = 560 / 2 - this.Height / 2;

            Location = new Point(x, y);

            pedidos = new List<Pedido>();

            LReparto lreparto = new LReparto();
            pedidos = lreparto.obtener_pedidos_s();

            mostrar_pedidos(pedidos);
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            salir = true;
            padre.Controls.Remove(this);
            if (m != null)
            {
                padre.Controls.Add(new AdministracionMenu(padre, user));

            }
            else
            {
                padre.Controls.Add(new RecepcionMenu(padre, user, idioma));

            }
        }
    }
}
