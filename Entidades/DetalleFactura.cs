using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleFactura
    {
        public long ID_FACTURA { get; set; }
        public long ID_PRODUCTO { get; set; }
        public int CANTIDAD_VENDIDA { get; set; }
        public float MONTO_TOTAL { get; set; }
    }
}
