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

namespace Tienda_Ropa
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            PRESENTACION.frmOpClientes clientes = new PRESENTACION.frmOpClientes();

            clientes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PRESENTACION.frmHacerVenta venta = new PRESENTACION.frmHacerVenta();
            venta.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            PRESENTACION.frmOpCategorias categorias = new PRESENTACION.frmOpCategorias();
            categorias.ShowDialog();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            PRESENTACION.frmOpProductos productos = new PRESENTACION.frmOpProductos();
            productos.ShowDialog();

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            PRESENTACION.frmOpProveedores proveedores = new PRESENTACION.frmOpProveedores();
            proveedores.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new PRESENTACION.frmReporte().ShowDialog();

        }

        private void frmPrincipal_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = new Point((this.Width / 2) - (panel1.Width / 2), (this.Height / 2) - (panel1.Height / 2));
        }
    }
}
