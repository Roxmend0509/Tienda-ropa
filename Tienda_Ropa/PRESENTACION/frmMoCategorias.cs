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
    public partial class frmMoCategorias : Form
    {
        /// <summary>
        /// metodo vacio para inicializar componentes
        /// </summary>
        public frmMoCategorias()
        {
            InitializeComponent();
        }

        /// <summary>
        /// objetos que se ocuparán
        /// </summary>
        POJOS.clsNegCategorias objNegCategorias = new POJOS.clsNegCategorias();
        DATOS.clsDatCategorias objDatCategorias = new DATOS.clsDatCategorias();

        /// <summary>
        /// boton usado para modificar la categoria seleccionada con los datos ingresados en la interfaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
          if ((txtIdCategoria.Text != "") & (txtNombre.Text != ""))
            {
                objNegCategorias.IdCategoria = Convert.ToInt32(txtIdCategoria.Text);
                objNegCategorias.Nombre = txtNombre.Text;
                objNegCategorias.Descripcion = txtDescripcion.Text;

                objDatCategorias.modificarC(ref objNegCategorias);// falta llamar al metodo modificar


                this.Hide();
                new frmOpCategorias().ShowDialog();
            }
            else
            {
                MessageBox.Show("Completa los Campos");
            }
        }

        /// <summary>
        /// boton que cierra el formulario sin interactuar con la base de datos
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
        private void txtIdCategoria_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmMoCategorias_Load(object sender, EventArgs e)
        {

        }
    }
}
