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
    public partial class Registrarse : Form
    {
        LoginL loginL = new LoginL();

        public Registrarse()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {

            string fecha = Calendario.Value.ToString("dd/MM/yyyy");
            loginL.rol = cmbRol.SelectedItem.ToString();
            loginL.dni = txtDni.Text;
            loginL.apellido = txtApellido.Text;
            loginL.nombre = txtNombre.Text;
            loginL.telefono = txtTelefono.Text;
            loginL.fechaNac = DateTime.Parse(fecha);
            loginL.usuario = txtUsuario.Text;
            loginL.clave = txtClave.Text;

            loginL.agregarEmpleadoL(loginL);
        }
    }
}
