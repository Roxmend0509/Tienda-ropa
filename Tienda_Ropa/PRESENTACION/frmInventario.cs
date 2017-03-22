using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Ropa
{
    public partial class frmInventario : Form
    {
        DATOS.clsDatProductos productos = new DATOS.clsDatProductos();


        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productos.leerDatos();
        }
    }
}
