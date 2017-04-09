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
    public partial class frmOpProveedores : Form
    {
        DATOS.clsDatProveedores proveedores = new DATOS.clsDatProveedores();
        POJOS.clsNegProveedores objNPro = new POJOS.clsNegProveedores();
        public frmOpProveedores()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOpProveedores_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = proveedores.leerDatos(textBox1.Text);
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            
            PRESENTACION.frmProveedores proveedoress = new PRESENTACION.frmProveedores();
            proveedoress.ShowDialog();
            dataGridView1.DataSource = proveedores.leerDatos(textBox1.Text);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            
            objNPro.IdProveedor = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            objNPro = proveedores.buscarPRO(ref objNPro);

            PRESENTACION.frmMoProveedores objfrmDatosPro = new PRESENTACION.frmMoProveedores();
            objfrmDatosPro.txtIdProveedor.Text = Convert.ToString(objNPro.IdProveedor);
            objfrmDatosPro.txtNombre.Text = objNPro.Nombre;
            objfrmDatosPro.txtDireccion.Text = objNPro.Direccion;
            objfrmDatosPro.txtTelefono.Text = Convert.ToString(objNPro.Telefono);
            objfrmDatosPro.ShowDialog();
            dataGridView1.DataSource = proveedores.leerDatos(textBox1.Text);
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            

        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            objNPro.IdProveedor = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            proveedores.eliminarPRO(ref objNPro);
            dataGridView1.DataSource = proveedores.leerDatos(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = proveedores.leerDatos(textBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
