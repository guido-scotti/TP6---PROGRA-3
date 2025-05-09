using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP6___PROGRA_3
{
	public partial class WebForm2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }

        //METODO PARA CARGAR LA GRID CON LOS PRODUCTOS
        private void CargarProductos()
        {
            GestionNeptuno gestion = new GestionNeptuno();
            string query = "SELECT IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad FROM Productos";
            DataTable tabla = gestion.ObtenerProductos(query); 
            gridProductos.DataSource = tabla;
            gridProductos.DataBind();
        }

        protected void gridProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //EVENTO DE ELIMINACION DE FILA
        protected void gridProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string idProducto = ((Label)gridProductos.Rows[e.RowIndex].FindControl("lbl_item_idprod")).Text;
            Productos producto = new Productos(Convert.ToInt32(idProducto));
            GestionNeptuno gestion = new GestionNeptuno();
            gestion.eliminarProducto(producto);
            CargarProductos();
        }

        //EVENTO DE EDICION DE FILA
        protected void gridProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridProductos.EditIndex = e.NewEditIndex;
            CargarProductos();
        }

        //EVENTO DE CANCELACION DE EDICION DE FILA
        protected void gridProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridProductos.EditIndex = -1;
            CargarProductos(); 
        }

        //EVENTO DE ACTUALIZACION DE EDICION DE FILA
        protected void gridProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            int id = Convert.ToInt32(((Label)gridProductos.Rows[e.RowIndex].FindControl("lbl_edit_idProd")).Text);
            string nuevoNombre = ((TextBox)gridProductos.Rows[e.RowIndex].FindControl("txt_edit_nombreProd")).Text;
            string nuevaCantidad = ((TextBox)gridProductos.Rows[e.RowIndex].FindControl("txt_edit_cantUnidad")).Text;
            string precioTexto = ((TextBox)gridProductos.Rows[e.RowIndex].FindControl("txt_edit_precioUnidad")).Text;

            decimal nuevoPrecio;
            if (!decimal.TryParse(precioTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out nuevoPrecio))
            {
                // Manejo de error si no se puede convertir el precio
                return;
            }

            Productos producto = new Productos(id, nuevoNombre, nuevoPrecio, nuevaCantidad);

       
            GestionNeptuno gestion = new GestionNeptuno();
            gestion.ActualizarProducto(producto);

        
            gridProductos.EditIndex = -1;
            CargarProductos();
        }

        //EVENTO DE PAGINACION
        protected void gridProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridProductos.PageIndex = e.NewPageIndex;
            CargarProductos();
        }

    }
}