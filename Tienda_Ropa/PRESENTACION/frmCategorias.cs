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
    public partial class frmCategorias : Form
    {
        /// <summary>
        /// constructor vacio usado para inicializar componentes
        /// </summary>
        public frmCategorias()
        {
            InitializeComponent();
        }
        //objetos que se usarán en la interfaz
        POJOS.clsNegCategorias objNegCategorias = new POJOS.clsNegCategorias();
        DATOS.clsDatCategorias objDatCategorias = new DATOS.clsDatCategorias();
        
        /// <summary>
        /// boton que agrega una nueva categoria a la base de datos con los datos ingresados en la interfaz
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

                objDatCategorias.insertarC(ref objNegCategorias);


                this.Hide();
                new frmOpCategorias().ShowDialog();
            }
            else
            {
                MessageBox.Show("Completa los Campos");
            }
        }

        /// <summary>
        /// cierra la interfaz sin interactuar con la base de datos
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

        private void frmCategorias_Load(object sender, EventArgs e)
        {

        }
    }
}
