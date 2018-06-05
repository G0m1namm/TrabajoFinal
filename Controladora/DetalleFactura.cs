using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class DetalleFactura
    {
        private Broker.BDTrabajoFinalEntities db = new Broker.BDTrabajoFinalEntities();

        public bool CrearDetalle(Entidades.DetalleFactura detalle)
        {
            bool resultado = false;
            try
            {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                AutoMapper.Mapper.CreateMap<Entidades.DetalleFactura, Broker.DetalleFactura>();
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos 

                Broker.Factura objetoDetalle = AutoMapper.Mapper.Map<Broker.Factura>(detalle);
                db.Factura.Add(objetoDetalle);
                db.SaveChanges();

                resultado = true;
            }

            catch
            {

            }
            return resultado;
        }

        public List<Entidades.DetalleFactura> BuscarDetalle(long ID)
        {
            List<Entidades.DetalleFactura> lista = new List<Entidades.DetalleFactura>();

            try
            {
                var resultado = from c in db.DetalleFactura
                                join e in db.Producto
                                on c.id_producto equals e.id_producto
                                where (c.id_factura == ID)
                                select new { c.id_factura, c.id_producto, c.cantidad_vendida, c.monto_total, e.nombre };

                foreach (var item in resultado)
                {
                    Entidades.DetalleFactura Detalle = new Entidades.DetalleFactura
                    {
                        ID_FACTURA = item.id_factura,
                        ID_PRODUCTO = int.Parse(item.id_producto.ToString()),
                        CANTIDAD_VENDIDA = int.Parse(item.cantidad_vendida.ToString()),
                        MONTO_TOTAL = float.Parse(item.monto_total.ToString())
                    };

                    lista.Add(Detalle);
                }
            }
            catch
            {

            }
            return lista;
        }

    }
}
