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
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }
        //Abre el reporte
        private void frmReportes_Load(object sender, EventArgs e)
        {
            new clsDatVentas().reporte(this.dataGridView1);
        }
    }
}
