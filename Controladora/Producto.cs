using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA = Broker;

namespace Controladora
{
    public class Producto
    {
        private Broker.BDTrabajoFinalEntities db = new Broker.BDTrabajoFinalEntities();


        public List<Entidades.Producto> BuscarArticulo(long ID)
        {
            
            List<Entidades.Producto> lista = new List<Entidades.Producto>();

            try
            {
                var resultado = from c in db.Producto
                                where (c.id_producto == ID || ID == -1)
                                select new { c.id_producto, c.id_proveedor, c.id_categoria, c.nombre, c.precio, c.stock };

                foreach (var item in resultado)
                {
                    Entidades.Producto Articulo = new Entidades.Producto
                    {
                        ID = item.id_producto,
                        ID_PROVEEDOR = item.id_proveedor,
                        ID_CATEGORIA = item.id_categoria,
                        NOMBRE = item.nombre,
                        PRECIO = long.Parse(item.precio.ToString()),
                        STOCK = long.Parse(item.stock.ToString())
                        
                        
                    };

                    lista.Add(Articulo);
                }
            }
            catch
            {

            }
            return lista;
        }

        public bool ActualizarStock(int cantidad, long ID)
        {
            DA.Producto producto= db.Producto.FirstOrDefault(x => x.id_producto == ID);
            var stock = producto.stock;
            var resultado = stock - cantidad;

            if(resultado >= 0)
            {
                producto.stock = resultado;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
