using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class Factura
    {
        private Broker.BDTrabajoFinalEntities db = new Broker.BDTrabajoFinalEntities();

        public bool CrearVenta(Entidades.Factura venta)
        {
            bool resultado = false;
            try
            {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                AutoMapper.Mapper.CreateMap<Entidades.Factura, Broker.Factura>();
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos 

                Broker.Factura objetoVenta = AutoMapper.Mapper.Map<Broker.Factura>(venta);
                db.Factura.Add(objetoVenta);
                db.SaveChanges();

                resultado = true;
            }
            catch

            {

            }
            return resultado;
        }

        public List<Entidades.Factura> BuscarVenta(long ID)
        {
            List<Entidades.Factura> lista = new List<Entidades.Factura>();

            try
            {
                var resultado = from c in db.Factura
                                join e in db.Cliente
                                on c.id_cliente equals e.id_cliente
                                where (c.id_factura == ID || ID == -1)
                                select new { c.id_factura, c.id_cliente, c.fecha, c.descuento, c.monto_final, e.nombre };

                foreach (var item in resultado)
                {

                    Entidades.Factura venta = new Entidades.Factura
                    {
                        ID_FACTURA = item.id_factura,
                        ID_CLIENTE = item.id_cliente,
                        FECHA = item.fecha,
                        DESCUENTO = float.Parse(item.descuento.ToString()),
                        MONTO_FINAL = double.Parse(item.monto_final.ToString())
                    };

                    lista.Add(venta);
                }
            }
            catch
            {

            }
            return lista;
        }
    }
}
