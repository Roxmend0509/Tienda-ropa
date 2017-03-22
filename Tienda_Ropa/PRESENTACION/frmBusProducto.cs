using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Ropa.PRESENTACION
{
    public partial class frmBusProducto : Form
    {

        POJOS.clsNegProductos objPB = new POJOS.clsNegProductos();
        DATOS.clsDatProductos objdatP = new DATOS.clsDatProductos();

        public frmBusProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((txtIdProducto.Text != ""))
            {
                objPB.IdProducto = Convert.ToInt32(txtIdProducto.Text);
                dataGridView1.DataSource = objdatP.leerDatosID(ref objPB);

                if (objdatP.buscarPporID(ref objPB) == null)
                {
                    MessageBox.Show("Dato no Encontrado");
                }
                txtIdProducto.Text = "";
            }
            else
            {
                MessageBox.Show("Ingresa algun dato, para realizar la busqueda");
            }
        }

    private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
