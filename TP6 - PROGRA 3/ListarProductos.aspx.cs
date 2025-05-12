using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6___PROGRA_3
{
    public partial class ListarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<ProductoSeleccionado> productos = Session["productosSeleccionados"] as List<ProductoSeleccionado>;


                if (productos != null && productos.Count != 0)
                {



                    gridProductos.DataSource = productos;
                    gridProductos.DataBind();


                }
                else
                {
                    Label1.Text = "No hay Productos seleccionados";
                }

            }
        }

        protected void gridProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridProductos.PageIndex = e.NewPageIndex;

            
            List<ProductoSeleccionado> productos = Session["productosSeleccionados"] as List<ProductoSeleccionado>;
            if (productos != null)
            {
                gridProductos.DataSource = productos;
                gridProductos.DataBind();
            }
        }


    }
}