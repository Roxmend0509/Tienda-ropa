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
    /// <summary>
    /// Formulario en el cual podemos ver las opciones de los productos
    /// </summary>
    public partial class frmOpProductos : Form
    {
        //objetos que se usarán en la interfaz
        DATOS.clsDatProductos PRODUCTOS = new DATOS.clsDatProductos();
        POJOS.clsNegProductos objNP = new POJOS.clsNegProductos();

        public frmOpProductos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Carga el contenido en el datagridView al iniciar con los datos de regreso del metodo leerDatos
        /// </summary>
        private void frmOpProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PRODUCTOS.leerDatos("");
        }
        /// <summary>
        /// Boton encargado de cerrar la ventana actual 
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Boton encargado de abrir frmCompras y carga los datos en el datagridView
        /// </summary>
        private void btnNueva_Click(object sender, EventArgs e)
        {            
            frmCompras compras = new frmCompras();
            compras.ShowDialog();
            dataGridView1.DataSource = PRODUCTOS.leerDatos("");

        }
        /// <summary>
        /// Carga los datos a frmMoProductos de acuerdo a los datos seleccionados en el dataqridView 
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            new frmMoProductos(dataGridView1.CurrentRow.Cells[0].Value.ToString()).ShowDialog();
            dataGridView1.DataSource = PRODUCTOS.leerDatos("");
        }
        /// <summary>
        /// Boton encargado de eliminar el Producto al seleccionarlo en el dataqridView para
        /// que despues recargue el dataqridView con los datos adecuados
        /// </summary>
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
        /// <summary>
        /// Cada vez que se escriba en el textbox1 se realizara una busqueda de los clietes que 
        /// coincidad con los parametros y esto hace que se actualice el dataqridView para ver los resultados
        /// </summary>
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
        /// <summary>
        /// Proppiedades del datagridview 
        /// </summary>
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
