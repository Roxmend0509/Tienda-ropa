namespace Tienda_Ropa.PRESENTACION
{
    partial class frmMoProductos
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
            this.btnImagen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.pro = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(638, 421);
            this.btnImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(204, 67);
            this.btnImagen.TabIndex = 33;
            this.btnImagen.Text = "Selecciona Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(686, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Imagen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 752);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "Proveedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 667);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Categoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 590);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 504);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Existencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 423);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "PrecioVenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "PrecioCompra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Talla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre";
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(246, 744);
            this.cbxProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(120, 33);
            this.cbxProveedor.TabIndex = 32;
            // 
            // pro
            // 
            this.pro.AutoSize = true;
            this.pro.Location = new System.Drawing.Point(38, 77);
            this.pro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pro.Name = "pro";
            this.pro.Size = new System.Drawing.Size(115, 25);
            this.pro.TabIndex = 31;
            this.pro.Text = "IdProducto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(246, 577);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.MaxLength = 45;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(650, 62);
            this.txtDescripcion.TabIndex = 29;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(246, 498);
            this.txtExistencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtExistencia.MaxLength = 4;
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(220, 31);
            this.txtExistencia.TabIndex = 28;
            this.txtExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistencia_KeyPress);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(246, 417);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVenta.MaxLength = 10;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(220, 31);
            this.txtPrecioVenta.TabIndex = 27;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(246, 329);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioCompra.MaxLength = 10;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(220, 31);
            this.txtPrecioCompra.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(246, 156);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 31);
            this.txtNombre.TabIndex = 24;
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(246, 246);
            this.txtTalla.Margin = new System.Windows.Forms.Padding(4);
            this.txtTalla.MaxLength = 15;
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(220, 31);
            this.txtTalla.TabIndex = 25;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(246, 71);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProducto.MaxLength = 5;
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(220, 31);
            this.txtIdProducto.TabIndex = 23;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(246, 667);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(120, 33);
            this.cbxCategoria.TabIndex = 30;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Tienda_Ropa.Properties.Resources.Check_icon;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptar.Location = new System.Drawing.Point(474, 877);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(204, 67);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(532, 102);
            this.picImagen.Margin = new System.Windows.Forms.Padding(4);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(380, 290);
            this.picImagen.TabIndex = 45;
            this.picImagen.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Tienda_Ropa.Properties.Resources.logout_icon_150x150;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Location = new System.Drawing.Point(708, 877);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(204, 67);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmMoProductos
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(990, 952);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMoProductos";
            this.Text = "frmMoProductos";
            this.Load += new System.EventHandler(this.frmMoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label pro;
        public System.Windows.Forms.PictureBox picImagen;
        public System.Windows.Forms.ComboBox cbxProveedor;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtExistencia;
        public System.Windows.Forms.TextBox txtPrecioVenta;
        public System.Windows.Forms.TextBox txtPrecioCompra;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtTalla;
        public System.Windows.Forms.TextBox txtIdProducto;
        public System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}