using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegocioFormsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtContraseña.Text;

            /**UsuarioNegocio negocio = new UsuarioNegocio();
            Usuario u = negocio.Login(user, pass); // devuelve null si falla

            if (u == null)
            {
                lblError.Text = "Usuario o contraseña incorrectos.";
                return;
            }

            // Abrir menú principal pasando el usuario logueado
            frmMenuPrincipal menu = new frmMenuPrincipal(u);
            this.Hide();
            menu.ShowDialog();
            this.Show();*/

            lblError.Text = "Se dio Click en Ingresar";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
