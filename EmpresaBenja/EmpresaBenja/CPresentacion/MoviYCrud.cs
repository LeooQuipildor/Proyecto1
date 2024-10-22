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
    public partial class dgvMovi : Form
        
    {
        MovimientosL movimientoL = new MovimientosL();
        ProductosL productoL = new ProductosL();
        public dgvMovi()
    {
            InitializeComponent();
            CargarProductos();

    }

        // Cargar los productos en el DataGridView
        private void CargarProductos()
        {
            ProductosL productosL= new ProductosL();
            dgvmoviYcrud.DataSource = productosL.ObtenerProductosL();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            productoL.Codigo = txtCodigo.Text;
            productoL.nombreProducto = txtNombreProducto.Text;
            productoL.nombreCorto = txtNombreCorto.Text;
            productoL.precioCosto = txtPrecioCosto.Text;
            productoL.stock = txtStock.Text;
            productoL.stockMinimo = txtStockMin.Text;
            productoL.procentajeGanancia = Convert.ToInt32(txtPorcentajeGanancia.Text);

            productoL.agregarProductosL(productoL);
            CargarProductos();

        }


        private void dgvMovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MovimientosL movimiento = new MovimientosL();
            dgvMovimientos.DataSource = movimiento.ObtenerMovimientos();
        }

        private void dgvmoviYcrud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvmoviYcrud.CurrentRow != null)
            {
                // Obtén la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvmoviYcrud.CurrentRow;

                // Asigna los valores de las celdas a los TextBox
                txtCodigo.Text = filaSeleccionada.Cells["Codigo"].Value.ToString();
                txtNombreProducto.Text = filaSeleccionada.Cells["NombreProducto"].Value.ToString();
                txtNombreCorto.Text = filaSeleccionada.Cells["NombreCorto"].Value.ToString();
                txtPrecioCosto.Text = filaSeleccionada.Cells["PrecioCosto"].Value.ToString();
                txtStock.Text = filaSeleccionada.Cells["Stock"].Value.ToString();
                txtStockMin.Text = filaSeleccionada.Cells["StockMinimo"].Value.ToString();
                txtPorcentajeGanancia.Text = filaSeleccionada.Cells["PorcentajeGanancia"].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            DataGridViewRow filaSeleccionada = dgvmoviYcrud.CurrentRow;

            productoL.id_producto = Convert.ToInt32(filaSeleccionada.Cells["id_producto"].Value.ToString());
            productoL.Codigo = txtCodigo.Text;
            productoL.nombreProducto = txtNombreProducto.Text;
            productoL.nombreCorto = txtNombreCorto.Text;
            productoL.precioCosto = txtPrecioCosto.Text;
            productoL.stock = txtStock.Text;
            productoL.stockMinimo = txtStockMin.Text;
            productoL.procentajeGanancia = Convert.ToInt32(txtPorcentajeGanancia.Text);

            productoL.modificarProductoL(productoL);
            CargarProductos();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvmoviYcrud.CurrentRow;
            productoL.id_producto = Convert.ToInt32(filaSeleccionada.Cells["id_producto"].Value.ToString());

            productoL.eliminarProductoL(productoL);
            CargarProductos();
        }
    }
}

