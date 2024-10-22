using EmpresaBenja.CDatos;
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
    public partial class Principal : Form
    {
        LoginL loginL = new LoginL();

        Inicio subInicio = new Inicio();
        ActuEmpleados subActuEmpleados = new ActuEmpleados();
        Clientes subClientes = new Clientes();
        ventaProductos subVenta = new ventaProductos();
        dgvMovi subMovieCrud = new dgvMovi();

        public string usuarioActivo { get; set; }
        public Principal(string usActivo)
        {
            InitializeComponent();
            this.usuarioActivo = usActivo;
        }

         private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            // Limpiar el panel si ya tiene algún control
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            // Configurar el formulario hijo
            formularioHijo.TopLevel = false;  // Indica que no es un formulario de nivel superior
            formularioHijo.Dock = DockStyle.Fill;  // Ajustar al tamaño del panel
            this.panelContenedor.Controls.Add(formularioHijo);  // Añadir al panel
            this.panelContenedor.Tag = formularioHijo;  // Asignar referencia para futuros usos

            formularioHijo.Show();  // Mostrar el formulario hijo
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(subInicio);
        }

        private void btnActuEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(subActuEmpleados);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(subClientes);
        }

        private void btnCompraProd_Click(object sender, EventArgs e)
        {
            Compra subCompra = new Compra(usuarioActivo);
            AbrirFormularioEnPanel(subCompra);
        }

        private void btnVentaProd_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(subVenta);
        }

        private void btnMoviYCrud_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(subMovieCrud);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(subInicio);

            if ("admin" != usuarioActivo)
            {
                loginL.usuario = usuarioActivo;
                loginL.seleccionarRolL(loginL);

                if (loginL.rol == "Auditor")
                {
                    btnActuEmpleados.Enabled = false;
                }
                else
                {
                    btnActuEmpleados.Enabled = false;
                    btnClientes.Enabled = false;
                    btnMoviYCrud.Enabled = false;
                }
            }
        }
    }
}
