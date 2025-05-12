using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6___PROGRA_3

{
    public partial class InicioEj2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                
            }

        }

        protected void linkButton_Click(object sender, EventArgs e)
        {
            Session["productosSeleccionados"]=null;
        }
    }
}