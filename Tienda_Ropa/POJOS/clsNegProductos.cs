using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace Tienda_Ropa.POJOS
{
    class clsNegProductos
    {
        private int _IdProducto;
        private String _Nombre;
        private String _Talla;
        private double _PrecioCompra;
        private double _PrecioVenta;
        private int _Existencia;
        private String _descrip;
        private Image _Imagen;
        private int _IdCategoria;
        private int _IdProveedor;


        public Image Imagen
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }
        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }

        public int IdProveedor
        {
            get { return _IdProveedor; }
            set { _IdProveedor = value; }
        }

        public int IdCategoria
        {
            get { return _IdCategoria; }
            set { _IdCategoria = value; }
        }

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public String Talla
        {
            get { return _Talla; }
            set { _Talla = value; }
        }

        public double PrecioCompra
        {
            get { return _PrecioCompra; }
            set { _PrecioCompra = value; }
        }

        public double PrecioVenta
        {
            get { return _PrecioVenta; }
            set { _PrecioVenta = value; }
        }

        public int Existencia
        {
            get { return _Existencia; }
            set { _Existencia = value; }
        }

        public String descrip
        {
            get { return _descrip; }
            set { _descrip = value; }
        }
    }
}
