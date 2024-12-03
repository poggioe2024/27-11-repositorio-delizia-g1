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
    public partial class CocinaPedidos : UserControl
    {
        Ventana padre;
        Funcionario user;
        List<Pedido> pedidos;
        List<CocinaPedido> pedidos_graficos = new List<CocinaPedido>();
        private Thread hilo;
        private bool salir = false;
        public CocinaPedidos(Ventana padre, Funcionario user)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;

            int x = 800 / 2 - this.Width / 2;
            int y = 560 / 2 - this.Height / 2;

            Location = new Point(x, y);

            LCocina lcocina = new LCocina();
            pedidos = lcocina.obtener_datos_pedidos();

            mostrar_pedidos(pedidos);

            hilo = new Thread(comparar_listas);
            hilo.Start();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            salir = true;
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new CocinaMenu(padre, user));
        }

        private void mostrar_pedidos(List<Pedido> pedidos)
        {
            int x = 5;
            int y = 20;
            int contador = 0;
            foreach (Pedido pedido in pedidos)
            {
                CocinaPedido cp = new CocinaPedido(pedido, this);
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

            foreach (CocinaPedido pedido in pedidos_graficos)
            {
                this.pan_pedidos.Controls.Add(pedido);
            }
        }

        public void comparar_listas()
        {
            while (salir != true)
            {
                Thread.Sleep(3000);

                LCocina lcocina = new LCocina();
                List<Pedido> pedidos_nuevos = lcocina.obtener_datos_pedidos();

                pedidos.Clear();
                pedidos = lcocina.obtener_datos_pedidos();

                actualizar_pantalla();
                /*
                if (pedidos_nuevos.Count == pedidos.Count)
                {
                    // compara uno a uno
                    bool igual = true;
                    for (int i = 0; i < pedidos.Count; i++)
                    {
                        if (pedidos[i].id != pedidos_nuevos[i].id)
                        {
                            igual = false;
                        }
                    }
                    // si no es igual
                    if (!igual)
                    {
                        pedidos.Clear();
                        foreach (Pedido p in pedidos_nuevos)
                        {
                            pedidos.Add(p);
                        }
                        actualizar_pantalla();
                    }
                }
                else if (pedidos_nuevos.Count > pedidos.Count)
                {
                    // compara uno a uno y agrega los diferentes
                    List<Producto> lista_temporal = new List<Producto>();
                    for (int i = 0; i < pedidos_nuevos.Count; i++)
                    {
                        for (int k = 0; k < pedidos.Count; i++)
                        {
                            if (pedidos[k].id == pedidos_nuevos[i].id)
                            {
                                //lista_temporal.Add(pedidos_nuevos[i]);
                            }
                        }
                            
                    }
                }
                else
                {
                    // error
                }*/
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
    }
}
