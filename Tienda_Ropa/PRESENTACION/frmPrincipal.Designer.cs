namespace Tienda_Ropa
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackgroundImage = global::Tienda_Ropa.Properties.Resources.Categortias;
            this.btnCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Location = new System.Drawing.Point(745, 10);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(10);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(225, 248);
            this.btnCategorias.TabIndex = 7;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::Tienda_Ropa.Properties.Resources.logout_icon_150x150;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(446, 546);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(96, 116);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = global::Tienda_Ropa.Properties.Resources.folder_customer_256;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(627, 278);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(10);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(225, 248);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackgroundImage = global::Tienda_Ropa.Properties.Resources.affiliates;
            this.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Location = new System.Drawing.Point(382, 278);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(10);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(225, 248);
            this.btnProveedores.TabIndex = 4;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackgroundImage = global::Tienda_Ropa.Properties.Resources.Compras;
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Location = new System.Drawing.Point(137, 278);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(10);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(225, 248);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackgroundImage = global::Tienda_Ropa.Properties.Resources.document;
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Location = new System.Drawing.Point(500, 10);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(10);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(225, 248);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackgroundImage = global::Tienda_Ropa.Properties.Resources.Ventas;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(10, 10);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(10);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(225, 248);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Tienda_Ropa.Properties.Resources.Reportes;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(255, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 248);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reporte";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnCategorias);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnProveedores);
            this.panel1.Controls.Add(this.btnInventario);
            this.panel1.Controls.Add(this.btnCompras);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 673);
            this.panel1.TabIndex = 9;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1718, 743);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "zzzz";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPrincipal_Paint);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

