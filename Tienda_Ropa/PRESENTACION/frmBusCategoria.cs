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
    public partial class frmBusCategoria : Form
    {

        POJOS.clsNegCategorias objPB = new POJOS.clsNegCategorias();
        DATOS.clsDatCategorias objdatC = new DATOS.clsDatCategorias();
        public frmBusCategoria()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((txtCategoria.Text != ""))
            {
                objPB.IdCategoria = Convert.ToInt32(txtCategoria.Text);
                dataGridView1.DataSource = objdatC.leerDatosIDC(ref objPB);

                if (objdatC.buscarCporIDC(ref objPB) == null)
                {
                    MessageBox.Show("Dato no Encontrado");
                }
                txtCategoria.Text = "";
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
