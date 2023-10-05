using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.BodegaApp.WF.Models;

namespace UPC.BodegaApp.WF
{
    static class Data
    {
        public static List<Producto> catalogo_productos = new List<Producto>();
        public static List<PedidoCabecera> pedidos = new List<PedidoCabecera>();
        public static List<PedidoDetalle> pedido_detalle = new List<PedidoDetalle>();
        public static List<Cliente> clientes = new List<Cliente>();

        public static void Load() {
            var cliente1 = new Cliente { 
                nombre = "Juanito Alimaña"
            };
            clientes.Add(cliente1);

            var cliente2 = new Cliente
            {
                nombre = "Payaso Plim Plim"
            };
            clientes.Add(cliente2);

            var cliente3 = new Cliente
            {
                nombre = "Diego Maradona"
            };
            clientes.Add(cliente3);

            var producto1 = new Producto
            {
                nombre = "Pilsen",
                valor_venta = 4
            };
            catalogo_productos.Add(producto1);

            var producto2 = new Producto
            {
                nombre = "Mantequilla",
                valor_venta = 10
            };
            catalogo_productos.Add(producto2);

            var producto3 = new Producto
            {
                nombre = "Chisito Fiesta",
                valor_venta = 6
            };
            catalogo_productos.Add(producto3);
        }
    }
}
