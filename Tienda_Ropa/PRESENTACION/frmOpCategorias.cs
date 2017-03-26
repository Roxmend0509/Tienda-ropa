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
    public partial class frmOpCategorias : Form
    {
        DATOS.clsDatCategorias categoria = new DATOS.clsDatCategorias();
        POJOS.clsNegCategorias objNP = new POJOS.clsNegCategorias();

        public frmOpCategorias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PRESENTACION.frmCategorias categorias = new PRESENTACION.frmCategorias();
            categorias.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOpCategorias_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = categoria.leerDatos("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            objNP.IdCategoria = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            objNP = categoria.buscarCATE(ref objNP);

            PRESENTACION.frmMoCategorias objfrmDatosC = new PRESENTACION.frmMoCategorias();
            objfrmDatosC.txtIdCategoria.Text = Convert.ToString(objNP.IdCategoria);
            objfrmDatosC.txtNombre.Text = objNP.Nombre;
            objfrmDatosC.txtDescripcion.Text = objNP.Descripcion;
            objfrmDatosC.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            objNP.IdCategoria = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            categoria.eliminarC(ref objNP);
            MessageBox.Show("Categoria Eliminada");

            dataGridView1.DataSource = categoria.leerDatos("");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = categoria.leerDatos(textBox1.Text);
        }
    }
}
