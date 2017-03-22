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
    public partial class frmMoProveedores : Form
    {
        public frmMoProveedores()
        {
            InitializeComponent();
        }
        POJOS.clsNegProveedores objNegProveedores = new POJOS.clsNegProveedores();
        DATOS.clsDatProveedores objDatProveedores = new DATOS.clsDatProveedores();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtIdProveedor.Text != "") & (txtNombre.Text != ""))
            {
                objNegProveedores.IdProveedor = Convert.ToInt32(txtIdProveedor.Text);
                objNegProveedores.Nombre = txtNombre.Text;
                objNegProveedores.Telefono = txtTelefono.Text;
                objNegProveedores.Direccion = txtDireccion.Text;

                objDatProveedores.modificarPro(ref objNegProveedores);


                this.Hide();
                new frmOpProveedores().ShowDialog();
            }
            else
            {
                MessageBox.Show("Completa los campos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
