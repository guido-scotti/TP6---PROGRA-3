using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP6___PROGRA_3
{
	public class AccesoDatos
	{
        string cadenaConexion = @"Data Source=DESKTOP-GUU4RQA\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public SqlDataAdapter ObtenerAdaptador(string consultaSQL)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(consultaSQL, conexion);
            return adaptador;
        }

        private SqlConnection obtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }

        public void ejecutarConsulta(string consulta)
        {
            SqlConnection conexion = obtenerConexion(); 
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            conexion.Open();
            cmd.ExecuteNonQuery();  
            conexion.Close();
        }
        
    }
}