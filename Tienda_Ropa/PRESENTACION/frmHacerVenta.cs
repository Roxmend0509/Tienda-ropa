using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Tienda_Ropa.PRESENTACION
{
    public partial class frmHacerVenta : Form
    {


        DATOS.clsDatProductos productos = new DATOS.clsDatProductos();
        POJOS.clsNegVentas venta = new POJOS.clsNegVentas();
        DATOS.clsDatVentas objVenta = new DATOS.clsDatVentas();
        DATOS.clsDatClientes objDatClientes = new DATOS.clsDatClientes();
        DateTime Fecha = DateTime.Now;
        Double iva;
        POJOS.clsNegProductos objPJ = new POJOS.clsNegProductos();
        int MP = 0;

        public frmHacerVenta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHacerVenta_Click(object sender, EventArgs e)
        {
            ArrayList col1Items = new ArrayList();
            ArrayList col2Items = new ArrayList();
            double sub_total = 0;
            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                col1Items.Add(dr.Cells[4].Value);
                col2Items.Add(dr.Cells[0].Value);
            }
            for (int i = 0; i < col1Items.Count; i++)
            {
                sub_total += Convert.ToDouble(col1Items[i]);
            }
            if (col1Items.Count > 1)
            {
                venta.Fecha = Fecha;
                venta.IdCliente = Convert.ToInt32(cbxCliente.SelectedValue);
                venta.Total = sub_total;                
                objVenta.insertarV(ref venta);
                venta.IdVenta = Convert.ToInt32(objVenta.NVenta());
                for (int i = 0; i < (col2Items.Count) - 1; i++)
                {
                    venta.SubTotal = Convert.ToDouble(dataGridView2[4,i].Value.ToString());
                    venta.IdProducto = Convert.ToInt32(col2Items[i]);
                    objVenta.insertarVD(ref venta);
                }
                this.Close();
            }            
            else
            {
                MessageBox.Show("Ingresa algun producto");
            }
            
        }

        public void total()
        {
            double sub_total = 0;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                sub_total += double.Parse(dataGridView2[4, i].Value.ToString());
            }
            txtTotal.Text = Convert.ToString(sub_total);
        }

        private void frmHacerVenta_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productos.leerDatos();

            cbxCliente.DataSource = objDatClientes.Cargar();
            cbxCliente.DisplayMember = "NOMBRE";
            cbxCliente.ValueMember = "IDCLIENTE";


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {

            ArrayList col1Items = new ArrayList();
            ArrayList col2Items = new ArrayList();
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString().Equals("0"))
            {
                MessageBox.Show("El producto seleccionado se ha agotado");

            }
            else
            {
                dataGridView2.Rows.Add(new string[] {
                Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[2, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[3, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[5, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[7, dataGridView1.CurrentRow.Index].Value)
            });

                foreach (DataGridViewRow dr in dataGridView2.Rows)
                {
                    col2Items.Add(dr.Cells[0].Value);
                    col1Items.Add(dr.Cells[3].Value);
                }
                objPJ.Existencia = Convert.ToInt32(col1Items[MP]);
                objPJ.IdProducto = Convert.ToInt32(col2Items[MP]);
                objVenta.modificarV(ref objPJ);
                dataGridView1.DataSource = productos.leerDatos();
                MP++;
            }

        }

        private void dataGridView2_Paint(object sender, PaintEventArgs e)
        {
            total();
        }
    }
}
