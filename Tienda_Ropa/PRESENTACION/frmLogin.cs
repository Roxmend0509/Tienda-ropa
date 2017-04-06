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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try {
                DATOS.clsDatUsuarios entrar = new DATOS.clsDatUsuarios();

                bool flag = entrar.Login(txtUsuario.Text, txtContraseña.Text);
                if (flag)
                {
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                    this.Hide();
                    new frmPrincipal().ShowDialog();
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                }
            }
            catch(Exception r)
            {
                MessageBox.Show(r + "");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
                    }
    }
}
