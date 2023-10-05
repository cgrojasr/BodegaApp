using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.BodegaApp.WF.Models
{
    public class Producto
    {
        public string id_producto { get; set; } = Guid.NewGuid().ToString();
        public string nombre { get; set; } 
        public decimal valor_venta { get; set; }
    }
}
