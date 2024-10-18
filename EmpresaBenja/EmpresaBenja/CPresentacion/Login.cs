using EmpresaBenja.Clogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaBenja.CPresentacion
{
    public partial class Login : Form
    {
        LoginL loginL = new LoginL();

        public Login()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registrarse registrarse = new Registrarse();

            registrarse.ShowDialog();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            loginL.usuario =  txtUsuario.Text;
            loginL.clave = txtClave.Text;

            if (loginL.ingresarLoginL(loginL))
            {
                Principal principal = new Principal(txtUsuario.Text);
                principal.FormClosed += (s, args) => this.Show();  // Volver a mostrar Form1 cuando Principal se cierre
                this.Hide();  // Ocultar Form1 temporalmente
                principal.Show();  // Mostrar el segundo formulario
            }
            else
            {
                MessageBox.Show("Error en contraseña o clave");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
