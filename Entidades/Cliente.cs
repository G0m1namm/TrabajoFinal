using System;

namespace Entidades
{
    [Serializable]
    public class Cliente
    {
        public long ID { get; set; }
        public string NOMBRE { get; set; }
        public string ID_DIRECCION { get; set; }
        public string PASSWORD { get; set; }
    }
}
