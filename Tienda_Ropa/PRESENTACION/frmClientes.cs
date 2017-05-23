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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        POJOS.clsNegClientes objNegClientes = new POJOS.clsNegClientes();
        DATOS.clsDatClientes objDatClientes = new DATOS.clsDatClientes();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtIdCliente.Text != "") & (txtNombre.Text != "") & (txtTelefono.TextLength ==10))
            {
                objNegClientes.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                objNegClientes.Nombre = txtNombre.Text;
                objNegClientes.Telefono = txtTelefono.Text;
                objNegClientes.Direccion = txtDireccion.Text;

                objDatClientes.insertarCl(ref objNegClientes);


                this.Hide();
                new frmOpClientes().ShowDialog();
            }
            else
            {
                MessageBox.Show("Completa los campos");
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// boton que cierra la interfaz sin interactuar con la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
