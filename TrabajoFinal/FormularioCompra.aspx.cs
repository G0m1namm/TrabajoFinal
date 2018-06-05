using System;

namespace TrabajoFinal
{
    public partial class FormularioCompra : System.Web.UI.Page
    {
       // private String user_id  { get;set; };
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.user_id= Request.QueryString["id_client"];
        }

        protected void BotonNuevaFactura_Click(object sender, EventArgs e)
        {
            String id = Request.QueryString["id_client"];

            Console.WriteLine(id);
            bool resultado;
            Controladora.Factura controladora = new Controladora.Factura();
            Controladora.DetalleFactura detalle = new Controladora.DetalleFactura();
            Controladora.Producto producto = new Controladora.Producto();

            Entidades.Producto entidadProducto = producto.BuscarArticulo(long.Parse(CampoIDProducto.Text))[0];

            if (producto.ActualizarStock(int.Parse(CampoCantidad.Text), long.Parse(CampoIDProducto.Text)))
            {
                Entidades.Factura entidadVenta = new Entidades.Factura
                {
                    ID_FACTURA = int.Parse(CampoIDVenta2.Text),
                    FECHA = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString(),
                    DESCUENTO = 0,
                    ID_CLIENTE = int.Parse(id),
                    MONTO_FINAL=entidadProducto.PRECIO* int.Parse(CampoCantidad.Text)
                };

                Entidades.DetalleFactura entidadDetalle = new Entidades.DetalleFactura
                {
                    CANTIDAD_VENDIDA = int.Parse(CampoCantidad.Text),
                    MONTO_TOTAL = entidadProducto.PRECIO*int.Parse(CampoCantidad.Text),
                    ID_FACTURA = int.Parse(CampoIDVenta2.Text),
                    ID_PRODUCTO = int.Parse(CampoIDProducto.Text)
                };

                resultado = controladora.CrearVenta(entidadVenta);

                if (resultado)
                {
                    EtiquetaConfirmacion.Text = "Se ha creado la factura. ";
                    EtiquetaConfirmacion.CssClass = "alert-success";
                }

                else
                {
                    EtiquetaConfirmacion.Text = "No se pudo crear la factura. ";
                    EtiquetaConfirmacion.CssClass = "alert-danger";
                }
            }
            else
            {
                EtiquetaConfirmacion.Text = "No hay cantidad disponible en stock. ";
                EtiquetaConfirmacion.CssClass = "alert-danger";
            }
            
        }

        protected void BotonArticulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormularioArticulo.aspx");
        }

        protected void BotonComportamiento_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormularioComportamiento.aspx");
        }

        protected void CampoIDCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}