using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Tienda_Ropa
{
    public partial class frmCompras : Form
    {
        /// <summary>
        /// constructos usado para inicializar el formulario
        /// </summary>
        public frmCompras()
        {
            InitializeComponent();
        }
        //objetos usados en la interfaz
        POJOS.clsNegProductos objNegProductos = new POJOS.clsNegProductos();
        DATOS.clsDatProductos objDatProductos = new DATOS.clsDatProductos();
        DATOS.clsDatProveedores objDatProveedores = new DATOS.clsDatProveedores();
        DATOS.clsDatCategorias objDatCategoria = new DATOS.clsDatCategorias();
        PRESENTACION.frmOpProductos opProductos = new PRESENTACION.frmOpProductos();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// boton aceptar usado para insertar un nuevo producto en la base de datos con los datos ingresados en la interfaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if ((txtIdProducto.Text != "") & (txtNombre.Text != "") & (comboBox1.Text != "") & (txtPrecioCompra.Text != "") &
                (txtPrecioVenta.Text != "") & (numericUpDown1.Text != "") & (cbxCategoria.Text != "") & (cbxProveedor.Text != ""))
            {
                objNegProductos.IdProducto = Convert.ToInt32(txtIdProducto.Text);
                objNegProductos.Nombre = txtNombre.Text;
                objNegProductos.Talla = comboBox1.Text;
                objNegProductos.PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text);
                objNegProductos.PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text);
                objNegProductos.descrip = txtDescripcion.Text;
                objNegProductos.Existencia = Convert.ToInt32(numericUpDown1.Text);
                objNegProductos.Imagen = picImagen.Image;
                objNegProductos.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                objNegProductos.IdProveedor = Convert.ToInt32(cbxProveedor.SelectedValue);

                objDatProductos.insertarP(ref objNegProductos, picImagen);


                this.Close();

            }
            else
            {
                MessageBox.Show("Completa los campos");
            }
        }

        /// <summary>
        /// evento que al dar clic en la imagen abre un dialogo para cargar imagen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    picImagen.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
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
        /// evento que al cargar la interfaz por completo inicializa algunos valores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCompras_Load(object sender, EventArgs e)
        {
            cbxProveedor.DataSource = objDatProveedores.Cargar();
            cbxProveedor.DisplayMember = "NOMBRE";
            cbxProveedor.ValueMember = "IDPROVEEDOR";


            cbxCategoria.DataSource = objDatCategoria.Cargar();
            cbxCategoria.DisplayMember = "NOMBRE";
            cbxCategoria.ValueMember = "IDCATEGORIA";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        /// <summary>
        /// metodo para filtrar teclas y realizar validacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }else if(char.IsControl(e.KeyChar))
                {
                e.Handled = false;
            }else if (char.IsSeparator(e.KeyChar))
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
        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
  
        }
    }
}
