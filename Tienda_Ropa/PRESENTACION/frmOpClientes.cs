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

namespace Tienda_Ropa.PRESENTACION
{
    /// <summary>
    /// Formulario en el cual podemos ver las opciones que poseen los clientes
    /// </summary>
    public partial class frmOpClientes : Form
    {
        //objetos que se usarán en la interfaz
        DATOS.clsDatClientes clientes = new DATOS.clsDatClientes();
        POJOS.clsNegClientes objNCli = new POJOS.clsNegClientes();

        public frmOpClientes()
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
        /// Boton encargado de cerrar la ventana actual y abrir el formulario frmCategorias
        /// </summary>
        private void frmOpClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientes.leerDatos(textBox1.Text);
        }
        /// <summary>
        /// Boton encargado de abrir frmClientes
        /// </summary>
        private void btnNueva_Click(object sender, EventArgs e)
        {
            
            PRESENTACION.frmClientes clientes = new PRESENTACION.frmClientes();

            clientes.ShowDialog();
        }
        /// <summary>
        /// Boton encargado de mandar los datos al formulario frmMoClientes, pero antes manda llamar al metodo
        /// buscarCli para que se carguen en el formulario
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            objNCli.IdCliente = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            objNCli = clientes.buscarCLI(ref objNCli);

            PRESENTACION.frmMoClientes objfrmDatosCli = new PRESENTACION.frmMoClientes();
            objfrmDatosCli.txtIdCliente.Text = Convert.ToString(objNCli.IdCliente);
            objfrmDatosCli.txtNombre.Text = objNCli.Nombre;
            objfrmDatosCli.txtDireccion.Text = objNCli.Direccion;
            objfrmDatosCli.txtTelefono.Text = Convert.ToString(objNCli.Telefono);
            objfrmDatosCli.ShowDialog();
        }
        /// <summary>
        /// Boton encargado de eliminar el cliente que se este seleccionado en el datagridView
        /// </summary>
        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            objNCli.IdCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            clientes.eliminarCli(ref objNCli);
            dataGridView1.DataSource = clientes.leerDatos(textBox1.Text);
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Cada vez que se escriba en el textbox1 se realizara una busqueda de los clietes que 
        /// coincidad con los parametros y esto hace que se actualice el dataqridView para ver los resultados
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientes.leerDatos(textBox1.Text);
        }
    }
}
