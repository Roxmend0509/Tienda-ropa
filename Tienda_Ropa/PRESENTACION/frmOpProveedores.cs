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
        //objetos que se usarán en la interfaz
        DATOS.clsDatProveedores proveedores = new DATOS.clsDatProveedores();
        POJOS.clsNegProveedores objNPro = new POJOS.clsNegProveedores();
        public frmOpProveedores()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boton encargado de cerrar la ventana actual 
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// evento que al cargar la interfaz por completo inicializa algunos valores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOpProveedores_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = proveedores.leerDatos(textBox1.Text);
        }
        /// <summary>
        /// Abre frmProveedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNueva_Click(object sender, EventArgs e)
        {
            
            PRESENTACION.frmProveedores proveedoress = new PRESENTACION.frmProveedores();
            proveedoress.ShowDialog();
            dataGridView1.DataSource = proveedores.leerDatos(textBox1.Text);

        }
        /// <summary>
        /// Boton que carga los datos selecionados en el dataqridView para que los cargue en 
        /// el fromulario frmMoProveedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// evento que elimina el proveedor que se encuentre seleccionado en el dataqridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            objNPro.IdProveedor = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            proveedores.eliminarPRO(ref objNPro);
            dataGridView1.DataSource = proveedores.leerDatos(textBox1.Text);
        }
        /// <summary>
        /// Cada vez que se escriba en el textbox1 se realizara una busqueda de los clietes que 
        /// coincidad con los parametros y esto hace que se actualice el dataqridView para ver los resultados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
