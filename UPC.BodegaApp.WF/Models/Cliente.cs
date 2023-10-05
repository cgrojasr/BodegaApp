using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.BodegaApp.WF.Models
{
    public class Cliente
    {
        public string id_cliente { get; set; } = Guid.NewGuid().ToString();
        public string nombre { get; set; }
    }
}
