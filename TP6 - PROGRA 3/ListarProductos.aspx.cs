﻿using System;
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
                if (productos != null)
                {
                    foreach (var p in productos)
                    {

                    }
                }

            }
        }
    }
}