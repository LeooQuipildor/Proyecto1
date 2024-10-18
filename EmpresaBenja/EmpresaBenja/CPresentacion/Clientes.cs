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
    public partial class Clientes : Form
    {
        ClientesL clienteL = new ClientesL();

        public Clientes()
        {
            InitializeComponent();
        }

        private void RecargarGrid()
        {
            DataTable dtClientes= clienteL.ObtenerClientesL();
            dgvClientes.DataSource = dtClientes;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            RecargarGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = Calendario.Value.ToString("dd/MM/yyyy");
            clienteL.nombre = txtNombre.Text;
            clienteL.apellido = txtApellido.Text;
            clienteL.telefono = txtTelefono.Text;
            clienteL.fechaNac = DateTime.Parse(fecha);
            clienteL.descuento = Convert.ToInt32(txtDescuento.Text);

            clienteL.agregarClienteL(clienteL);
            RecargarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvClientes.CurrentRow;

            string fecha = Calendario.Value.ToString("dd/MM/yyyy");
            clienteL.id = Convert.ToInt32(filaSeleccionada.Cells["id_cliente"].Value.ToString());
            clienteL.nombre = txtNombre.Text;
            clienteL.apellido = txtApellido.Text;
            clienteL.telefono = txtTelefono.Text;
            clienteL.fechaNac = DateTime.Parse(fecha);
            clienteL.descuento = Convert.ToInt32(txtDescuento.Text);

            clienteL.modificarClienteL(clienteL);
            RecargarGrid();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dgvClientes.CurrentRow != null)
            {
                // Obtén la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvClientes.CurrentRow;

                // Asigna los valores de las celdas a los TextBox
                txtApellido.Text = filaSeleccionada.Cells["apellido"].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                txtTelefono.Text = filaSeleccionada.Cells["telefono"].Value.ToString();
                Calendario.Text = filaSeleccionada.Cells["fechaNac"].Value.ToString();
                txtDescuento.Text = filaSeleccionada.Cells["descuento"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvClientes.CurrentRow;
            clienteL.id = Convert.ToInt32(filaSeleccionada.Cells["id_cliente"].Value.ToString());

            clienteL.eliminarClienteL(clienteL);
            RecargarGrid();
        }
    }
}
