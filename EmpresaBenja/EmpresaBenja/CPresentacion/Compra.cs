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
    public partial class Compra : Form
    {
        CompraL compraL = new CompraL();
        ComprobanteL comprobanteL = new ComprobanteL();

        public Compra()
        {
            InitializeComponent();
        }

        public string empleadoActivo { get; set; }
        public Compra(string empleado)
        {
            InitializeComponent();
            this.empleadoActivo = empleado;
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;
            lblFecha.Text = fechaHoy.ToString("dd/MM/yyyy");

            //// Si quieres añadir columnas manualmente
            dgvProductos.Columns.Add("columnaNombreproducto", "Nombre producto");
            dgvProductos.Columns.Add("columnaNombreCorto", "Nombre corto");
            dgvProductos.Columns.Add("columnaPrecioCosto", "Precio Costo");
            dgvProductos.Columns.Add("columnaCantidad", "Cantidad");
            dgvProductos.Columns.Add("columnaStockMinimo", "Cantidad Minima");
            dgvProductos.Columns.Add("columnaPorcentajeGanancia", "Porcentaje gcia.");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //// Agregar una nueva fila al DataGridView
            int filaIndex = dgvProductos.Rows.Add(); // Añade una fila y obtiene el índice de la nueva fila

            if (txtPrecioCosto.Text != "")
            {
                lblMontoTotal.Text = "$" + (Convert.ToDecimal(txtPrecioCosto.Text) +
                    Convert.ToDecimal(lblMontoTotal.Text.Substring(1))).ToString();
            }

            dgvProductos.Rows[filaIndex].Cells["columnaNombreProducto"].Value = txtNombreProd.Text;
            dgvProductos.Rows[filaIndex].Cells["columnaNombreCorto"].Value = txtNombreCorto.Text;
            dgvProductos.Rows[filaIndex].Cells["columnaPrecioCosto"].Value = txtPrecioCosto.Text;
            dgvProductos.Rows[filaIndex].Cells["columnaCantidad"].Value = txtCantidad.Text;
            dgvProductos.Rows[filaIndex].Cells["columnaStockMinimo"].Value = txtStockMinimo.Text;
            dgvProductos.Rows[filaIndex].Cells["columnaPorcentajeGanancia"].Value = txtPorcentajeGan.Text;


            compraL.nombreProducto = txtNombreProd.Text;
            compraL.nombreCorto = txtNombreCorto.Text;
            compraL.precioCosto = Convert.ToDecimal(txtPrecioCosto.Text);
            compraL.cantidad = Convert.ToDecimal(txtCantidad.Text);
            compraL.stockMinimo = Convert.ToDecimal(txtStockMinimo.Text);
            compraL.porcentajeGanancia = Convert.ToInt32(txtPorcentajeGan.Text);

            compraL.agregarProductoL(compraL);
        }

        private string ID_Cliente;
        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            SeleccionarCliente seleccionarCliente = new SeleccionarCliente();
            seleccionarCliente.ShowDialog();

            lblNombreClie.Text = seleccionarCliente.nombreSeleccionado;
            lblApellidoClie.Text = seleccionarCliente.apellidoSeleccionado;
            ID_Cliente = seleccionarCliente.id_clienteSeleccionado;

            if (lblNombreClie.Text == "")
            {
                lblNombreClie.Text = "Nombre proveedor";
                lblApellidoClie.Text = "Apellido proveedor";
            }
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            comprobanteL.tipo = "Compra";
            comprobanteL.numero = txtNumFac.Text;
            comprobanteL.fecha = DateTime.Parse(lblFecha.Text);
            comprobanteL.empleado = empleadoActivo;
            comprobanteL.cliente = Convert.ToInt32(ID_Cliente);
            comprobanteL.monto = Convert.ToDecimal(lblMontoTotal.Text.Substring(1));

            comprobanteL.crearComprobanteL(comprobanteL);

            lblNombreClie.Text = "Nombre proveedor";
            lblApellidoClie.Text = "Apellido proveedor";
            lblMontoTotal.Text = "$0";
            dgvProductos.Rows.Clear();
            MessageBox.Show("Compra finalizada");
        }
    }
}
