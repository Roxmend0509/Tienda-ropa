using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Ropa.POJOS
{
    class clsNegUsuarios
    {
        private int _IdUsuario;
        private String _Nombre;
        private String _Password;
        private Char _Login;

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
    
        public String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public Char Login
        {
            get { return _Login; }
            set { _Login = value; }
        }
    }
}
