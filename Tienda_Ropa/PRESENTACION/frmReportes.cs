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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }
        POJOS.clsNegVentas venta = new POJOS.clsNegVentas();
        private void frmReportes_Load(object sender, EventArgs e)
        {
            DATOS.clsDatVentas objV= new DATOS.clsDatVentas();
            List<POJOS.clsNegVentas> list = objV.ObtenerDetallesV(2);
            reportViewer1.LocalReport.DataSources.Clear(); //clear report
            // reportViewer1.LocalReport.ReportEmbeddedResource = "Report3.rdlc"; // bind reportviewer with .rdlc
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DatosDetalle", list); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = list;
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void clsNegVentasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
