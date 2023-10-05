using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPC.BodegaApp.WF.Models;

namespace UPC.BodegaApp.WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Data.Load();
            Producto_Carga();
            Cliente_Carga();
        }

        private void Producto_Carga() {
            //for (int i = 0; i < Data.catalogo_productos.Count; i++)
            //{
            //    //cbProductos = new ComboBox();
            //    var producto = Data.catalogo_productos[i];
            //    cbProductos.Items.Add(Data.catalogo_productos[i]);
            //    cbProductos.ValueMember = "id_producto";
            //    cbProductos.DisplayMember = "nombre";
            //}

            cbProductos.Items.AddRange(Data.catalogo_productos.ToArray());
            cbProductos.ValueMember = "id_producto";
            cbProductos.DisplayMember = "nombre";
        }

        private void Cliente_Carga()
        {
            cbCliente.Items.AddRange(Data.clientes.ToArray());
            cbCliente.ValueMember = "id_cliente";
            cbCliente.DisplayMember = "nombre";
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cbCliente.SelectedItem;

            var pedido = new PedidoCabecera { 
                fecha = DateTime.Now.AddDays(30),
                venta_total = 0,
                id_cliente = cliente.id_cliente,
            };
            Data.pedidos.Add(pedido);
            var id_pedido = Data.pedidos.Last().id_pedido;


            Producto producto = (Producto)cbProductos.SelectedItem;
            var detalle = new PedidoDetalle
            {
                id_producto = producto.id_producto,
                cantidad = int.Parse(txtCantidad.Text),
                id_pedido_cabecera = id_pedido,
                valor_unitario = producto.valor_venta,
                nombre_producto = producto.nombre
            };

            //var producto = Data.catalogo_productos.Find(x => x.id_producto == detalle.id_producto);
            //detalle.valor_unitario = producto.valor_venta;
            detalle.valor_venta_total = detalle.cantidad * detalle.valor_unitario;
            //detalle.nombre_producto = producto.nombre;

            Data.pedido_detalle.Add(detalle);

            dgvPedidos.Rows.Add(detalle.nombre_producto,
                detalle.cantidad,
                detalle.valor_unitario,
                detalle.valor_venta_total);
        }
    }
}
