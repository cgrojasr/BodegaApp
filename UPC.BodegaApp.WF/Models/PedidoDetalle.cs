using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.BodegaApp.WF.Models
{
    public class PedidoDetalle
    {
        public string id_pedido_detalle { get; set; } = Guid.NewGuid().ToString();
        public string id_pedido_cabecera { get; set; }
        public string id_producto { get; set; }
        public string nombre_producto { get; set; }
        public int cantidad { get; set; }
        public decimal valor_unitario { get; set; }
        public decimal valor_venta_total { get; set; }
    }
}
