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
    public partial class frmBusClientes : Form
    {

        POJOS.clsNegClientes objPB = new POJOS.clsNegClientes();
        DATOS.clsDatClientes objdatCli = new DATOS.clsDatClientes();
        public frmBusClientes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((txtIdCliente.Text != ""))
            {
                objPB.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                dataGridView1.DataSource = objdatCli.leerDatosIDCli(ref objPB);

                if (objdatCli.buscarCliporIDCli(ref objPB) == null)
                {
                    MessageBox.Show("Dato no Encontrado");
                }
                txtIdCliente.Text = "";
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
