using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_Ropa.DATOS;
using Tienda_Ropa.POJOS;

namespace Tienda_Ropa.PRESENTACION
{
    public partial class frmMoProductos : Form
    {
        /// <summary>
        /// constructor usado para cargar la información actual del producto
        /// para posteriormente ser modificada
        /// </summary>
        /// <param name="id">id del producto que se modificara</param>
        public frmMoProductos(string id)
        {
            InitializeComponent();
            txtIdProducto.Text = id;
            clsNegProductos pr = new clsNegProductos();
            pr.IdProducto = int.Parse(id);
            pr = new clsDatProductos().buscarPporID(ref pr);
            txtDescripcion.Text = pr.descrip;
            txtNombre.Text = pr.Nombre;
            txtPrecioCompra.Text = pr.PrecioCompra+"";
            txtPrecioVenta.Text = pr.PrecioVenta + "";
            comboBox1.SelectedItem = pr.Talla;
            new clsDatProductos().cargarImagen(picImagen, id);


        }

        /// <summary>
        /// constructor vacio
        /// </summary>
        public frmMoProductos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// objetos utilizados
        /// </summary>
        POJOS.clsNegProductos objNegProductos = new POJOS.clsNegProductos();
        DATOS.clsDatProductos objDatProductos = new DATOS.clsDatProductos();
        DATOS.clsDatProveedores objDatProveedores = new DATOS.clsDatProveedores();
        DATOS.clsDatCategorias objDatCategoria = new DATOS.clsDatCategorias();

        /// <summary>
        /// boton que al ser accionado modificará el producto con los valores que hayan sido ingresados en el formulario
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

                objDatProductos.modificarP(ref objNegProductos, picImagen);


                this.Close();

            }
            else
            {
                MessageBox.Show("Completa los campos");
            }
        }

        /// <summary>
        /// metodo usado para cancelar la edicion el cual cierra el formulario y no hace cambios en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// boton usado para abrir la interfaz para cargar una imagen
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
        /// Metodo que se ejecuta al ser cargado el formulario en el cual se inicializn algunos valores como los nombres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMoProductos_Load(object sender, EventArgs e)
        {
            cbxProveedor.DataSource = objDatProveedores.Cargar();
            cbxProveedor.DisplayMember = "NOMBRE";
            cbxProveedor.ValueMember = "IDPROVEEDOR";


            cbxCategoria.DataSource = objDatCategoria.Cargar();
            cbxCategoria.DisplayMember = "NOMBRE";
            cbxCategoria.ValueMember = "IDCATEGORIA";
        }

        /// <summary>
        /// metodo usado para hacer filtrado de teclas y hacer validacion
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void picImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
