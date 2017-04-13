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
            dataGridView1.DataSource = PRODUCTOS.leerDatos("");

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            new frmMoProductos(dataGridView1.CurrentRow.Cells[0].Value.ToString()).ShowDialog();
            dataGridView1.DataSource = PRODUCTOS.leerDatos("");
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(dataGridView1[0,dataGridView1.CurrentRow.Index].Value.ToString());
            PRODUCTOS.eliminarP(id);
            dataGridView1.DataSource = PRODUCTOS.leerDatos("");
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

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int i = dataGridView1.CurrentRow.Index;
                textBox2.Text = PRODUCTOS.descripcion(int.Parse(dataGridView1[0, i].Value.ToString()));
            }
        }
    }
}
