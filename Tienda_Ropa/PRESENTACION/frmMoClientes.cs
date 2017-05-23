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
        /// <summary>
        /// constructor vacio para inicializar
        /// </summary>
        public frmMoClientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// objetos que se usan en el formulario
        /// </summary>
        POJOS.clsNegClientes objNegClientes = new POJOS.clsNegClientes();
        DATOS.clsDatClientes objDatClientes = new DATOS.clsDatClientes();

        /// <summary>
        /// el boton cancelar cierra el formulario actual sin interactuar con la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// boton usado para modificar el cliente usando los datos que se ingresaron en la interfaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtIdCliente.Text != "") & (txtNombre.Text != ""))
            {
                objNegClientes.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                objNegClientes.Nombre = txtNombre.Text;
                objNegClientes.Telefono = txtTelefono.Text;
                objNegClientes.Direccion = txtDireccion.Text;

                objDatClientes.modificarCl(ref objNegClientes);
                this.Close();
            }
            else
            {
                MessageBox.Show("Completa los campos");
            }
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// metodo para filtrar teclas y realizar validacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// metodo para filtrar teclas y realizar validacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void frmMoClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
