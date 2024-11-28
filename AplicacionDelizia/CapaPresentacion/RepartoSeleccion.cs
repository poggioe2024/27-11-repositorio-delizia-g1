
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
    public partial class RepartoSeleccion : UserControl
    {
        public Funcionario user;
        Ventana padre;
        List<Pedido> pedidos;
        List<RepartoPedido> pedidos_graficos = new List<RepartoPedido>();
        public RepartoSeleccion(Ventana padre, Funcionario user)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;

            int x = 800 / 2 - this.Width / 2;
            int y = 560 / 2 - this.Height / 2;

            Location = new Point(x, y);

            pedidos = new List<Pedido>();

            LReparto lreparto = new LReparto();
            pedidos = lreparto.obtener_pedidos_libres();

            mostrar_pedidos(pedidos);
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new RepartoMenu(padre, user));
        }

        // copia

        private void mostrar_pedidos(List<Pedido> pedidos)
        {
            int x = 5;
            int y = 20;
            int contador = 0;
            foreach (Pedido pedido in pedidos)
            {
                RepartoPedido cp = new RepartoPedido(this, pedido);
                if (contador % 5 == 0)
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

            foreach (RepartoPedido pedido in pedidos_graficos)
            {
                this.pan_pedidos.Controls.Add(pedido);
            }
        }

        public void actualizar_pantalla()
        {
            pan_pedidos.Controls.Clear();

            pedidos.Clear();
            pedidos_graficos.Clear();

            LReparto lreparto = new LReparto();
            pedidos = lreparto.obtener_pedidos_libres();

            mostrar_pedidos(pedidos);
        }
    }
}
