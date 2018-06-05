using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System.Data;

namespace Controladora
{
    public class MongoBD
    {
        protected static IMongoClient cliente = new MongoClient("mongodb://G0m1n4mm:G0m1nyu@ds141524.mlab.com:41524/dbtopicos");
        protected static IMongoDatabase database = cliente.GetDatabase("dbtopicos");

        public string[] ConsultarComentarios(double ID)
        {
            string[] resultados = new string[5];

            var coleccion = database.GetCollection<BsonDocument>("Cliente_nosql");
            var filter = Builders<BsonDocument>.Filter.Eq("Id_cliente", ID);
            var result = coleccion.Find(filter).FirstOrDefault();

            if (result != null)
            {
                resultados[0] = result["Id_cliente"] != null ? result["Id_cliente"].ToString() : string.Empty;
                resultados[1] = result["puntuacion"] != null ? result["puntuacion"].ToString() : string.Empty;
                resultados[2] = result["Comentario"] != null ? result["Comentarios"].ToString() : string.Empty;
                resultados[3] = result["telefonos"] != null ? result["telefonos"].ToString() : string.Empty;
                resultados[4] = result["lista_deseos"] != null ? result["lista_deseos"].ToString() : string.Empty;
            }

            else
            {

            }

            return resultados;
        }
    }
}
