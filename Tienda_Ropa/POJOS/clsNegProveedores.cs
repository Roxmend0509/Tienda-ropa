using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Ropa.POJOS
{
    /// <summary>
    /// Clase para los getters y setter de proveedores
    /// </summary>
    class clsNegProveedores
    {
        private int _IdProveedor;
        private String _Nombre;
        private String _Direccion;
        private String _Telefono;
        


        public int IdProveedor
        {
            get { return _IdProveedor; }
            set { _IdProveedor = value; }
        }

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre= value; }
        }

        public String Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public String Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }


    }
}
