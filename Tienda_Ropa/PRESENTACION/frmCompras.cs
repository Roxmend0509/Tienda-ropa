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
        public frmCompras()
        {
            InitializeComponent();
        }

        POJOS.clsNegProductos objNegProductos = new POJOS.clsNegProductos();
        DATOS.clsDatProductos objDatProductos = new DATOS.clsDatProductos();
        DATOS.clsDatProveedores objDatProveedores = new DATOS.clsDatProveedores();
        DATOS.clsDatCategorias objDatCategoria = new DATOS.clsDatCategorias();
        PRESENTACION.frmOpProductos opProductos = new PRESENTACION.frmOpProductos();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
