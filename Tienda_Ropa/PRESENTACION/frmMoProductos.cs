﻿using System;
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
    public partial class frmMoProductos : Form
    {
        public frmMoProductos()
        {
            InitializeComponent();
        }
        POJOS.clsNegProductos objNegProductos = new POJOS.clsNegProductos();
        DATOS.clsDatProductos objDatProductos = new DATOS.clsDatProductos();
        DATOS.clsDatProveedores objDatProveedores = new DATOS.clsDatProveedores();
        DATOS.clsDatCategorias objDatCategoria = new DATOS.clsDatCategorias();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtIdProducto.Text != "") & (txtNombre.Text != "") & (txtTalla.Text != "") & (txtPrecioCompra.Text != "") &
               (txtPrecioVenta.Text != "") & (txtExistencia.Text != "") & (cbxCategoria.Text != "") & (cbxProveedor.Text != ""))
            {
                objNegProductos.IdProducto = Convert.ToInt32(txtIdProducto.Text);
                objNegProductos.Nombre = txtNombre.Text;
                objNegProductos.Talla = txtTalla.Text;
                objNegProductos.PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text);
                objNegProductos.PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text);
                objNegProductos.descrip = txtDescripcion.Text;
                objNegProductos.Existencia = Convert.ToInt32(txtExistencia.Text);
                objNegProductos.Imagen = picImagen.Image;
                objNegProductos.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                objNegProductos.IdProveedor = Convert.ToInt32(cbxProveedor.SelectedValue);

                objDatProductos.modificarP(ref objNegProductos, picImagen);


                this.Hide();
                new frmOpProductos().ShowDialog();

            }
            else
            {
                MessageBox.Show("Completa los campos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    picImagen.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void frmMoProductos_Load(object sender, EventArgs e)
        {
            cbxProveedor.DataSource = objDatProveedores.Cargar();
            cbxProveedor.DisplayMember = "NOMBRE";
            cbxProveedor.ValueMember = "IDPROVEEDOR";


            cbxCategoria.DataSource = objDatCategoria.Cargar();
            cbxCategoria.DisplayMember = "NOMBRE";
            cbxCategoria.ValueMember = "IDCATEGORIA";
        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
