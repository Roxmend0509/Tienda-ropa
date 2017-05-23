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
    /// <summary>
    /// Formulario en donde se realizan las modificaciones de datos de un proveedor
    /// </summary>
    public partial class frmMoProveedores : Form
    {
        public frmMoProveedores()
        {
            InitializeComponent();
        }
        //objetos que se usarán en la interfaz
        POJOS.clsNegProveedores objNegProveedores = new POJOS.clsNegProveedores();
        DATOS.clsDatProveedores objDatProveedores = new DATOS.clsDatProveedores();
        /// <summary>
        /// Boton que permite capturar los datos de las cajas de texto y
        /// almacenarlos en el objeto de proveedores para su almacenamiento en la base de datos
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtIdProveedor.Text != "") & (txtNombre.Text != ""))
            {
                objNegProveedores.IdProveedor = Convert.ToInt32(txtIdProveedor.Text);
                objNegProveedores.Nombre = txtNombre.Text;
                objNegProveedores.Telefono = txtTelefono.Text;
                objNegProveedores.Direccion = txtDireccion.Text;

                objDatProveedores.modificarPro(ref objNegProveedores);


                this.Close();
            }
            else
            {
                MessageBox.Show("Completa los campos");
            }
        }
        /// <summary>
        /// Boton que permite cerrar la ventana
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Funciones de validadciones en la caja de texto del campo de telefono
        /// para que no acepte letras ni caracteres
        /// </summary>
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

        private void frmMoProveedores_Load(object sender, EventArgs e)
        {
            
        }

        private void txtIdProveedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
