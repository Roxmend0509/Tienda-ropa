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
    public partial class frmBusProveedor : Form
    {
        POJOS.clsNegProveedores objPB = new POJOS.clsNegProveedores();
        DATOS.clsDatProveedores objdatPro = new DATOS.clsDatProveedores();
        public frmBusProveedor()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((txtIdProveedor.Text != ""))
            {
                objPB.IdProveedor = Convert.ToInt32(txtIdProveedor.Text);
                dataGridView1.DataSource = objdatPro.leerDatosIDP(ref objPB);

                if (objdatPro.buscarPporIDP(ref objPB) == null)
                {
                    MessageBox.Show("Dato no Encontrado");
                }
                txtIdProveedor.Text = "";
            }
            else
            {
                MessageBox.Show("Ingresa algun dato, para realizar la busqueda");
            }

        }

    private void frmBusProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
