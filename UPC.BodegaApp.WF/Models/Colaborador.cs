using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.BodegaApp.WF.Models
{
    public class Colaborador
    {
        public string id_colaborador { get; set; } = Guid.NewGuid().ToString();
        public string nombre { get; set; }
    }
}
