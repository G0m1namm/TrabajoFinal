using System;

namespace Entidades
{
    [Serializable]
    public class Producto
    {
        public long ID { get; set; }
        public long ID_PROVEEDOR { get; set; }
        public long ID_CATEGORIA { get; set; }
        public string NOMBRE { get; set; }
        public long PRECIO { get; set; }
        public long STOCK { get; set; }
        
    }
}
