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
    public partial class frmOpClientes : Form
    {

        DATOS.clsDatClientes clientes = new DATOS.clsDatClientes();
        POJOS.clsNegClientes objNCli = new POJOS.clsNegClientes();

        public frmOpClientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOpClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientes.leerDatos();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            this.Close();
            PRESENTACION.frmClientes clientes = new PRESENTACION.frmClientes();

            clientes.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Close();
            objNCli.IdCliente = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            objNCli = clientes.buscarCLI(ref objNCli);

            PRESENTACION.frmMoClientes objfrmDatosCli = new PRESENTACION.frmMoClientes();
            objfrmDatosCli.txtIdCliente.Text = Convert.ToString(objNCli.IdCliente);
            objfrmDatosCli.txtNombre.Text = objNCli.Nombre;
            objfrmDatosCli.txtDireccion.Text = objNCli.Direccion;
            objfrmDatosCli.txtTelefono.Text = Convert.ToString(objNCli.Telefono);
            objfrmDatosCli.ShowDialog();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            objNCli.IdCliente = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            clientes.eliminarCli(ref objNCli);
            MessageBox.Show("Cliente Eliminado");

            dataGridView1.DataSource = clientes.leerDatos();
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBusClientes c = new frmBusClientes();

            c.ShowDialog();
        }
    }
}
