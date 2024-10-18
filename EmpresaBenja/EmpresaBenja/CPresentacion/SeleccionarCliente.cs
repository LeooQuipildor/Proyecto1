using EmpresaBenja.Clogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaBenja.CPresentacion
{
    public partial class SeleccionarCliente : Form
    {
        ClientesL clienteL = new ClientesL();

        public SeleccionarCliente()
        {
            InitializeComponent();
        }

        public string nombreSeleccionado { get; set; }
        public string apellidoSeleccionado { get; set; }
        public string id_clienteSeleccionado { get; set; }

        private void RecargarGrid()
        {
            DataTable dtClientes = clienteL.ObtenerClientesL();
            dgvClientes.DataSource = dtClientes;
        }

        private void SeleccionarCliente_Load(object sender, EventArgs e)
        {
            RecargarGrid();
        }

        private string nombre, apellido, descuento, id_cliente;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dgvClientes.CurrentRow != null)
            {
                // Obtén la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvClientes.CurrentRow;

                // Asigna los valores de las celdas a los TextBox
                apellido = filaSeleccionada.Cells["apellido"].Value.ToString();
                nombre = filaSeleccionada.Cells["nombre"].Value.ToString();
                id_cliente = filaSeleccionada.Cells["id_cliente"].Value.ToString();

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            nombreSeleccionado = nombre;
            apellidoSeleccionado = apellido;
            id_clienteSeleccionado = id_cliente;
            this.Close();
        }
    }
}

