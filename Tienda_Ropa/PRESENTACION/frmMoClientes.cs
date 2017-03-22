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
    public partial class frmMoClientes : Form
    {
        public frmMoClientes()
        {
            InitializeComponent();
        }

        POJOS.clsNegClientes objNegClientes = new POJOS.clsNegClientes();
        DATOS.clsDatClientes objDatClientes = new DATOS.clsDatClientes();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtIdCliente.Text != "") & (txtNombre.Text != ""))
            {
                objNegClientes.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                objNegClientes.Nombre = txtNombre.Text;
                objNegClientes.Telefono = txtTelefono.Text;
                objNegClientes.Direccion = txtDireccion.Text;

                objDatClientes.modificarCl(ref objNegClientes);
            }
            else
            {
                MessageBox.Show("Completa los campos");
            }
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
