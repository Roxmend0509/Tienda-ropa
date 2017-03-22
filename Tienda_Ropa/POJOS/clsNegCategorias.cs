using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Ropa.POJOS
{
    class clsNegCategorias
    {
        private int _IdCategoria;
        private String _Nombre;
        private String _Descricion;

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

        public String Descripcion
        {
            get { return _Descricion; }
            set { _Descricion = value; }
        }

    }
}
