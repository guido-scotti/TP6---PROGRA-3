using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6___PROGRA_3
{

    public class ProductoSeleccionado //EJERCICIO 2
    {
        public string IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string IdProveedor { get; set; }
        public string PrecioUnitario { get; set; }
    }

    public class Productos //EJERCICIO 1
    {
        /// PROPIEDADES
        private int _idProducto;
        private string _nombreProducto;
        private decimal _precioUnidad;
        private string _cantidadUnidad;
 

        /// METODOS CONSTRUCTORES
        public Productos()
        {
            /// CONSTRUCTOR por defecto o vacío
        }

        public Productos(int idProducto)
        {
            _idProducto = idProducto;
        }

        public Productos(int idProducto, string nombreProducto, decimal precioUnidad, string cantidadUnidad)
        {
            _idProducto = idProducto;
            _nombreProducto = nombreProducto;
            _precioUnidad = precioUnidad;
            _cantidadUnidad = cantidadUnidad;
        }

        /// METODOS GETTER Y SETTERS
        public int IdProducto
        {
            get
            {
                return _idProducto;
            }
            set
            {
                _idProducto = value;
            }
        }
        public string nombreProducto
        {
            get
            {
                return _nombreProducto;
            }
            set
            {
                _nombreProducto = value;
            }
        }
        public decimal precioUnidad
        {
            get
            {
                return _precioUnidad;
            }
            set
            {
                _precioUnidad = value;
            }
        }
        public string cantidadUnidad
        {
            get
            {
                return _cantidadUnidad;
            }
            set
            {
                _cantidadUnidad = value;
            }
        }
    }
}