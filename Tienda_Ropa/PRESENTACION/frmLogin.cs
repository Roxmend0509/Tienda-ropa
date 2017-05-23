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
        /// <summary>
        /// constructor vacio que inicializa componentes y centra la ventana
        /// </summary>
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

        /// <summary>
        /// boton usado para validar el inicio de sesion y entrar al sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// boton cancelar que cierra la interfaz y termina el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// label que al dar clic abre el fb oficial de sport rhayno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/SportRhayno/?fref=ts");
        }

        /// <summary>
        /// foto que al dar clic abre el fb de sport rahyno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/SportRhayno/?fref=ts");
        }
    }
}
