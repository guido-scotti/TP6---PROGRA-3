using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6___PROGRA_3
{
	public class Productos
	{
        /// PROPIEDADES
        private int _idProducto;
        private string _nombreProducto;
        private decimal _precioUnidad;
        private int _cantidadUnidad;
 

        /// METODOS CONSTRUCTORES
        public Productos()
        {
            /// CONSTRUCTOR por defecto o vacío
        }

        public Productos(int idProducto)
        {
            _idProducto = idProducto;
        }

        public Productos(int idProducto, string nombreProducto, decimal precioUnidad, int cantidadUnidad)
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
        public int cantidadUnidad
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