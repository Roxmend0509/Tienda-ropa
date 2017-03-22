using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Ropa
{
    public partial class frmVentas : Form
    {
        DATOS.clsDatVentas venta = new DATOS.clsDatVentas();
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = venta.leerDatos();
        }

        private void btnNueva_Click_1(object sender, EventArgs e)
        {
            PRESENTACION.frmHacerVenta HacerVenta = new PRESENTACION.frmHacerVenta();
            HacerVenta.ShowDialog();
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {

        }
    }
}
