﻿namespace Tienda_Ropa.PRESENTACION
{
    partial class frmMoClientes
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(156, 334);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(262, 31);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(156, 233);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 30;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(384, 31);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 137);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(384, 31);
            this.txtNombre.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 333);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(156, 48);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCliente.MaxLength = 5;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(262, 31);
            this.txtIdCliente.TabIndex = 8;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCliente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "IdCliente";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Tienda_Ropa.Properties.Resources.Check_icon;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptar.Location = new System.Drawing.Point(34, 452);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(170, 71);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Tienda_Ropa.Properties.Resources.logout_icon_150x150;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Location = new System.Drawing.Point(248, 452);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(170, 71);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmMoClientes
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(576, 598);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMoClientes";
            this.Text = "frmMoClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtIdCliente;
    }
}