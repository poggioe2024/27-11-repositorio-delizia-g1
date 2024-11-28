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
    public partial class SeguimientoPedido : UserControl
    {
        Seguimiento s;
        Pedido pedido;
        public SeguimientoPedido(Seguimiento s, Pedido p)
        {
            InitializeComponent();

            this.s = s;
            this.pedido = p;

            switch (pedido.estado)
            {
                case 1:
                    lbl_estado.Text = "EN PREPARACIÓN";
                    pan_estado.BackColor = Color.Yellow;
                    break;
                case 2:
                    lbl_estado.Text = "EN ESPERA";
                    pan_estado.BackColor = Color.Orange;
                    break;
                case 3:
                    lbl_estado.Text = "EN CAMINO";
                    pan_estado.BackColor = Color.LightBlue;
                    break;
                case 4:
                    lbl_estado.Text = "ENTREGADO";
                    pan_estado.BackColor = Color.Green;
                    Controls.Remove(btn_cancelar);
                    break;
                case 5:
                    lbl_estado.Text = "CANCELADO";
                    pan_estado.BackColor = Color.Red;
                    Controls.Remove(btn_cancelar);
                    break;
                default:
                    lbl_estado.Text = "DESCONOCIDO";
                    pan_estado.BackColor = Color.Red;
                    break;
            }

            lbl_id.Text = "" + pedido.id;
            lbl_nombre.Text = pedido.nombre_cliente;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            LRecepcion lRecepcion = new LRecepcion();
            lRecepcion.cancelar_pedido(pedido.id);

            s.actualizar_pantalla();
        }
    }
}
