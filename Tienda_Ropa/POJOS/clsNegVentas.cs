using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Ropa.POJOS
{
    /// <summary>
    /// Clase para los getters y setter de la venta
    /// </summary>
    class clsNegVentas
    {
            private int _IdVenta;
            private DateTime _Fecha;
            private int _IdDetalleVenta;
            private double _Total;
            private int _IdProducto;
            private double _SubTotal;
            private double _IVA;
            private int _IdCliente;

        public int IdVenta
            {
                get { return _IdVenta; }
                set { _IdVenta = value; }
            }

        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        public double Total
            {
                get { return _Total; }
                set { _Total = value; }
            }

            public DateTime Fecha
            {
                get { return _Fecha; }
                set { _Fecha = value; }
            }

            public int IdDetalleVenta
            {
                get { return _IdDetalleVenta; }
                set { _IdDetalleVenta = value; }
            }

            public int IdProducto
            {
                get { return _IdProducto; }
                set { _IdProducto = value; }
            }

            public double SubTotal
            {
                get { return _SubTotal; }
                set { _SubTotal = value; }
            }

            public double IVA
            {
                get { return _IVA; }
                set { _IVA = value; }
            }
        }
    }

