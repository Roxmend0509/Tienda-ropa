using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Ropa.POJOS
{
    /// <summary>
    /// Clase para los getters y setter de Clientes
    /// </summary>
    class clsNegClientes
    {
        private int _IdCliente;
        private String _Nombre;
        private String _Direccion;
        private string _Telefono;



        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public String Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
    }
}
