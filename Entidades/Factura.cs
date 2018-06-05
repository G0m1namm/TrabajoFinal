using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Factura
    {
        public long ID_FACTURA { get; set; }
        public long ID_CLIENTE { get; set; }
        public string FECHA { get; set; }
        public double DESCUENTO { get; set; }
        public double MONTO_FINAL { get; set; }


    }
}
