using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.BodegaApp.WF.Models
{
    public class PedidoCabecera
    {
        public string id_pedido { get; set; } = Guid.NewGuid().ToString();
        public DateTime fecha { get; set; }
        public string id_cliente { get; set; }
        public decimal venta_total { get; set; }
    }
}
