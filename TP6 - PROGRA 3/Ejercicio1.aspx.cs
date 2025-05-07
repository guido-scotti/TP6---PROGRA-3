using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
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

        private void CargarProductos()
        {
            GestionNeptuno gestion = new GestionNeptuno();
            DataTable tabla = gestion.ObtenerProductos(); // Asegurate que esto devuelva los datos actualizados
            gridProductos.DataSource = tabla;
            gridProductos.DataBind();
        }

        protected void gridProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gridProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string idProducto = ((Label)gridProductos.Rows[e.RowIndex].FindControl("lbl_item_idprod")).Text;
            Productos producto = new Productos(Convert.ToInt32(idProducto));
            GestionNeptuno gestion = new GestionNeptuno();
            gestion.eliminarProducto(producto);
            CargarProductos();
        }

        protected void gridProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridProductos.EditIndex = e.NewEditIndex;
            CargarProductos();
        }

        protected void gridProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridProductos.EditIndex = -1;
            CargarProductos(); 
        }


        protected void gridProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // Obtener los controles desde la fila que se está editando
            string idTexto = ((Label)gridProductos.Rows[e.RowIndex].FindControl("lbl_it_idProducto"))?.Text;
            string nuevoNombre = ((TextBox)gridProductos.Rows[e.RowIndex].FindControl("txtNombre"))?.Text;
            string nuevoPrecioTexto = ((TextBox)gridProductos.Rows[e.RowIndex].FindControl("txtPrecio"))?.Text;
            string nuevaCantidadTexto = ((TextBox)gridProductos.Rows[e.RowIndex].FindControl("txtCantidad"))?.Text;

   
            if (!int.TryParse(idTexto, out int id))
            {
               // lblError.Text = "El ID del producto no es válido.";
                return;
            }

            if (!decimal.TryParse(nuevoPrecioTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal nuevoPrecio))
            {
                //lblError.Text = "El precio ingresado no es válido.";
                return;
            }

            if (!int.TryParse(nuevaCantidadTexto, out int nuevaCantidad))
            {
                //lblError.Text = "La cantidad ingresada no es válida.";
                return;
            }

       
            Productos producto = new Productos(id, nuevoNombre, nuevoPrecio, nuevaCantidad);

       
            GestionNeptuno gestion = new GestionNeptuno();
            gestion.ActualizarProducto(producto);

        
            gridProductos.EditIndex = -1;
            CargarProductos();
        }
    }
}