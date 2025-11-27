using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Factura
    {
        public int Id {  get; set; }
        public DateTime Fecha { get; set; }
        public int IdMetodoPago { get; set; }
        public decimal Total { get; set; }

    }
}
