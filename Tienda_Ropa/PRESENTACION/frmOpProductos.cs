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
    public partial class frmOpProductos : Form
    {
        DATOS.clsDatProductos PRODUCTOS = new DATOS.clsDatProductos();
        POJOS.clsNegProductos objNP = new POJOS.clsNegProductos();

        public frmOpProductos()
        {
            InitializeComponent();
        }

        private void frmOpProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PRODUCTOS.leerDatos("");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {            
            frmCompras compras = new frmCompras();
            compras.ShowDialog();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            objNP.IdProducto = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            objNP = PRODUCTOS.buscarPRO(ref objNP);
 
            PRESENTACION.frmMoProductos objfrmDatosP = new PRESENTACION.frmMoProductos();
            objfrmDatosP.txtIdProducto.Text = Convert.ToString(objNP.IdProducto);
            objfrmDatosP.txtNombre.Text = objNP.Nombre;
            objfrmDatosP.comboBox1.Text = objNP.Talla;
            objfrmDatosP.txtPrecioCompra.Text = Convert.ToString(objNP.PrecioCompra);
            objfrmDatosP.txtPrecioVenta.Text = Convert.ToString(objNP.PrecioVenta);
            objfrmDatosP.numericUpDown1.Text = Convert.ToString(objNP.Existencia);
            objfrmDatosP.txtDescripcion.Text = objNP.descrip;
            objfrmDatosP.cbxCategoria.Text = Convert.ToString(objNP.IdCategoria);
            objfrmDatosP.cbxProveedor.Text = Convert.ToString(objNP.IdProveedor);
            objfrmDatosP.picImagen.Image = objNP.Imagen;
            objfrmDatosP.ShowDialog();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PRODUCTOS.leerDatos(textBox1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
