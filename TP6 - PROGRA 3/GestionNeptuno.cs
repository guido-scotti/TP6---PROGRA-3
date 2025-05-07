using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;

namespace TP6___PROGRA_3
{
	public class GestionNeptuno
    {
        public DataTable ObtenerProductos()
        {
            AccesoDatos datos = new AccesoDatos();
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = datos.ObtenerAdaptador("SELECT IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad FROM Productos");
            adaptador.Fill(ds, "Productos");
            return ds.Tables["Productos"];
        }

        public void eliminarProducto(Productos producto)
        {
            string consulta = "DELETE FROM Productos WHERE IdProducto = " + producto.IdProducto;
            AccesoDatos datos = new AccesoDatos();
            datos.ejecutarConsulta(consulta);
        }

        public void ActualizarProducto(Productos producto)
        {
            string consulta = $"UPDATE Productos SET NombreProducto = '{producto.nombreProducto}', PrecioUnidad = {producto.precioUnidad.ToString(CultureInfo.InvariantCulture)}, CantidadUnidad = {producto.cantidadUnidad} WHERE IdProducto = {producto.IdProducto}";
            AccesoDatos datos = new AccesoDatos();
            datos.ejecutarConsulta(consulta);
        }
    }
}