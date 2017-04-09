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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        POJOS.clsNegProveedores objNegProveedores = new POJOS.clsNegProveedores();
        DATOS.clsDatProveedores objDatProveedores = new DATOS.clsDatProveedores();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if ((txtIdProveedor.Text != "") & (txtNombre.Text != ""))
                {
                    objNegProveedores.IdProveedor = int.Parse(txtIdProveedor.Text);
                    objNegProveedores.Nombre = txtNombre.Text;
                    objNegProveedores.Telefono = txtTelefono.Text;
                    objNegProveedores.Direccion = txtDireccion.Text;

                    objDatProveedores.insertarPro(ref objNegProveedores);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Completa los campos");
                }
            }
            catch(Exception r)
            {
                MessageBox.Show(r.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
