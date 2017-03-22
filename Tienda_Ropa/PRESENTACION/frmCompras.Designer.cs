namespace Tienda_Ropa
{
    partial class frmCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pro = new System.Windows.Forms.Label();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(179, 435);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(137, 24);
            this.cbxCategoria.TabIndex = 8;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(179, 53);
            this.txtIdProducto.MaxLength = 5;
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(148, 22);
            this.txtIdProducto.TabIndex = 1;
            this.txtIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProducto_KeyPress);
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(179, 165);
            this.txtTalla.MaxLength = 15;
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(148, 22);
            this.txtTalla.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 107);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(179, 218);
            this.txtPrecioCompra.MaxLength = 10;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(148, 22);
            this.txtPrecioCompra.TabIndex = 4;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(179, 275);
            this.txtPrecioVenta.MaxLength = 10;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(148, 22);
            this.txtPrecioVenta.TabIndex = 5;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(179, 326);
            this.txtExistencia.MaxLength = 4;
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(148, 22);
            this.txtExistencia.TabIndex = 6;
            this.txtExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistencia_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(179, 376);
            this.txtDescripcion.MaxLength = 45;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(435, 41);
            this.txtDescripcion.TabIndex = 7;
            // 
            // pro
            // 
            this.pro.AutoSize = true;
            this.pro.Location = new System.Drawing.Point(40, 56);
            this.pro.Name = "pro";
            this.pro.Size = new System.Drawing.Size(76, 17);
            this.pro.TabIndex = 8;
            this.pro.Text = "IdProducto";
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(179, 484);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(137, 24);
            this.cbxProveedor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Talla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "PrecioCompra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "PrecioVenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Existencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Imagen";
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(440, 277);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(136, 43);
            this.btnImagen.TabIndex = 10;
            this.btnImagen.Text = "Selecciona Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Tienda_Ropa.Properties.Resources.Check_icon;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptar.Location = new System.Drawing.Point(331, 568);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(136, 43);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // picImagen
            // 
            this.picImagen.Image = global::Tienda_Ropa.Properties.Resources.no_image_slide;
            this.picImagen.Location = new System.Drawing.Point(369, 72);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(253, 186);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 22;
            this.picImagen.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Tienda_Ropa.Properties.Resources.logout_icon_150x1502;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Location = new System.Drawing.Point(487, 568);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 43);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCompras
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(625, 640);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxProveedor);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pro);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.cbxCategoria);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label pro;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.ComboBox cbxCategoria;
        public System.Windows.Forms.ComboBox cbxProveedor;
    }
}