﻿using System;
using System.Collections.Generic;

namespace TrabajoFinal
{
    public partial class FormularioHistorial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BotonBuscarVenta_Click(object sender, EventArgs e)
        {
            long.TryParse(CampoID.Text, out long ID);

            Controladora.Factura controladora = new Controladora.Factura();
            List<Entidades.Factura> lista = controladora.BuscarVenta(ID);
            EtiquetaHistorialVenta.Text = "Facturas/ventas encontradas.";
            gdvHistorialVenta.DataSource = lista;
            gdvHistorialVenta.DataBind();
        }

        protected void BotonBuscarDetalle_Click(object sender, EventArgs e)
        {
            long.TryParse(CampoID.Text, out long ID);
            
            Controladora.DetalleFactura controladora = new Controladora.DetalleFactura();
            List<Entidades.DetalleFactura> lista = controladora.BuscarDetalle(ID);
            EtiquetaHistorialDetalle.Text = "Detalle de la factura con ID " + CampoID.Text;
            gdvHistorialDetalle.DataSource = lista;
            gdvHistorialDetalle.DataBind();
        }

        protected void BotonLimpiar_Click1(object sender, EventArgs e)
        {
            EtiquetaHistorialVenta.Text = "";
            EtiquetaHistorialDetalle.Text = "";
            
            gdvHistorialVenta.DataSource = null;
            gdvHistorialDetalle.DataSource = null;

            gdvHistorialVenta.DataBind();
            gdvHistorialDetalle.DataBind();
        }
    }
}