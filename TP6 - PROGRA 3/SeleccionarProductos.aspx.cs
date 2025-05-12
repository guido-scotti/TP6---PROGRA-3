using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6___PROGRA_3
{
	public partial class SeleccionarProductos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
                CargarProductos();
            }
		}

		private void CargarProductos()
        {
            GestionNeptuno gestion = new GestionNeptuno();
            //discriminar elementos en la query
            string query = "SELECT IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad FROM Productos";
            gridProductos.DataSource = gestion.ObtenerProductos(query);
            gridProductos.DataBind();
        }


        protected void gridProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

            GridViewRow row = gridProductos.Rows[e.NewSelectedIndex];

            string idProducto = ((Label)row.FindControl("lbl_idProd")).Text;
            string nombreProducto = ((Label)row.FindControl("lbl_nombreProducto")).Text;
            string idProveedor = ((Label)row.FindControl("lbl_idProveedor")).Text;
            string precioUnitario = ((Label)row.FindControl("lbl_precioUnitario")).Text;

            // PREGUNTO SI LA LISTA ESTA CREADA Y SI NO LO ESTA LA CREO
            List<ProductoSeleccionado> productosSeleccionados = Session["productosSeleccionados"] as List<ProductoSeleccionado>;
            if (productosSeleccionados == null)
            {
                productosSeleccionados = new List<ProductoSeleccionado>();
            }

            //CHEQUEO PARA NO DUPLICAR
            bool exists = productosSeleccionados.Any(p => p.IdProducto == idProducto);
            if (!exists)
            {
                // AGREGO EL PRODUCTO
                productosSeleccionados.Add(new ProductoSeleccionado
                {
                    IdProducto = idProducto,
                    NombreProducto = nombreProducto,
                    IdProveedor = idProveedor,
                    PrecioUnitario = precioUnitario
                });
            }

            // Save the list back to the session
            Session["productosSeleccionados"] = productosSeleccionados;

            if (nombreProducto != null)
            {
                selectedItemLabel.Text = "Producto seleccionado: " + nombreProducto;
            }
        }

        protected void gridProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridProductos.PageIndex = e.NewPageIndex;
            CargarProductos();
        }
    
    
        



    }
}