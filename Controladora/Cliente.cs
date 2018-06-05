using System.Collections.Generic;
using System.Linq;

namespace Controladora
{
    public class Cliente
    {
        Broker.BDTrabajoFinalEntities db = new Broker.BDTrabajoFinalEntities();

        public bool Validar(long ID, string Password)
        {
            bool answer = false;
            string[] arreglo;
            List<string> lista = new List<string>();

            var query = from m in db.Cliente
                        where (m.id_cliente == ID)
                        select new { m.password };

            foreach (var item in query)
            {
                string resultado = item.password;
                lista.Add(resultado);
            }

            arreglo = lista.ToArray();

            if (arreglo.Length > 0)
            {
                if (arreglo[0] == Password)
                {
                    answer = true;
                }
            }

            return answer;
        }

        public List<Entidades.Cliente> BuscarCliente(long ID)
        {
            List<Entidades.Cliente> lista = new List<Entidades.Cliente>();

            try
            {
                var resultado = from c in db.Cliente
                                where (ID == -1)
                                select new { c.id_cliente, c.nombre };

                foreach (var item in resultado)
                {
                    Entidades.Cliente cliente = new Entidades.Cliente
                    {
                        ID = item.id_cliente,
                        NOMBRE = item.nombre,
                    };

                    lista.Add(cliente);
                }
            }
            catch
            {

            }
            return lista;
        }
    }
}
