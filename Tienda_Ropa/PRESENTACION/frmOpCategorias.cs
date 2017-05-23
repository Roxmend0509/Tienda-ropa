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
{    /// <summary>
     /// Formulario en donde se ven las opciones de categorias
     /// </summary>
    public partial class frmOpCategorias : Form
    {
        //objetos que se usarán en la interfaz
        DATOS.clsDatCategorias categoria = new DATOS.clsDatCategorias();
        POJOS.clsNegCategorias objNP = new POJOS.clsNegCategorias();

        public frmOpCategorias()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boton encargado de cerrar la ventana actual y abrir el formulario frmCategorias
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PRESENTACION.frmCategorias categorias = new PRESENTACION.frmCategorias();
            categorias.ShowDialog();
        }
        /// <summary>
        /// Boton encargado de cerrar la ventana actual
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Funcion Load la cual carga los datos de la tabla categorias de la base de datos
       ///  en el dataGridView al cargarce
        /// </summary>
        private void frmOpCategorias_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = categoria.leerDatos("");
        }
        /// <summary>
        /// Boton encargado de cerrar la ventana actual y buscar el dato proporcionado en la caja de texto
        /// </summary>
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
        /// <summary>
        /// Boton encargado de eliminar una categoria al momento de mandar llamar el 
        /// objeto y darle los parametros necesarios
        /// </summary>
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
        /// <summary>
        /// Cada vex que se escriba algo en el textbox1 el datagridView se actualizara
        /// con los parametros que cumplan con el criterio de busqueda
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = categoria.leerDatos(textBox1.Text);
        }
    }
}
