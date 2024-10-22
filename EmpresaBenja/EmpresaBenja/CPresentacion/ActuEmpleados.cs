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
    public partial class ActuEmpleados : Form
    {
        EmpleadosL empleadoL = new EmpleadosL();

        public ActuEmpleados()
        {
            InitializeComponent();
        }

        private void RecargarGrid()
        {
            DataTable dtEmpleados = empleadoL.ObtenerEmpleadosL();
            dgvEmpleados.DataSource = dtEmpleados;
            dgvEmpleados.Columns["id_empleado"].Visible = false;
        }

        private void ActuEmpleados_Load(object sender, EventArgs e)
        {
            RecargarGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = Calendario.Value.ToString("dd/MM/yyyy");
            empleadoL.rol = cmbRol.SelectedItem.ToString();
            empleadoL.dni = txtDni.Text;
            empleadoL.apellido = txtApellido.Text;
            empleadoL.nombre = txtNombre.Text;
            empleadoL.telefono = txtTelefono.Text;
            empleadoL.fechaNac = DateTime.Parse(fecha);
            empleadoL.usuario = txtUsuario.Text;
            empleadoL.clave = txtClave.Text;

            empleadoL.agregarEmpleadoL(empleadoL);
            RecargarGrid();
        }

    
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dgvEmpleados.CurrentRow != null)
            {
                // Obtén la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvEmpleados.CurrentRow;

                // Asigna los valores de las celdas a los TextBox
                txtDni.Text = filaSeleccionada.Cells["dni"].Value.ToString();
                txtApellido.Text = filaSeleccionada.Cells["apellido"].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                txtTelefono.Text = filaSeleccionada.Cells["telefono"].Value.ToString();
                Calendario.Text = filaSeleccionada.Cells["fechaNac"].Value.ToString();
                txtUsuario.Text = filaSeleccionada.Cells["usuario"].Value.ToString();
                txtClave.Text = filaSeleccionada.Cells["clave"].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           DataGridViewRow filaSeleccionada = dgvEmpleados.CurrentRow;

            empleadoL.id = Convert.ToInt32(filaSeleccionada.Cells["id_empleado"].Value.ToString());

           string fecha = Calendario.Value.ToString("dd/MM/yyyy");
           empleadoL.dni = txtDni.Text;
           empleadoL.apellido = txtApellido.Text;
           empleadoL.nombre = txtNombre.Text;
           empleadoL.telefono = txtTelefono.Text;
           empleadoL.fechaNac = DateTime.Parse(fecha);
           empleadoL.usuario = txtUsuario.Text;
           empleadoL.clave = txtClave.Text;

            //empleadoL.modificarEmpleadoD(empleadoL);
            //RecargarGrid();

            MessageBox.Show(empleadoL.id.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvEmpleados.CurrentRow;
            empleadoL.id = Convert.ToInt32(filaSeleccionada.Cells["id_empleado"].Value.ToString());

            empleadoL.eliminarEmpleadoL(empleadoL);
            RecargarGrid();
        }
    }
}
