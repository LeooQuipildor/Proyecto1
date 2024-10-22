using EmpresaBenja.Clogica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaBenja.CDatos
{
    internal class ProductosD
    {
        SqlConnection conexion = new SqlConnection("server= DESKTOP-6RV4JMD\\SQLEXPRESS;database= PROYECTO ;integrated security= true");
        SqlCommand comando;
        SqlDataReader leer;


        // MOSTRAR PRODUCTOS
        public DataTable ObtenerProductosD()
        {
            string query = "SELECT id_producto, Codigo , nombreProducto, nombreCorto,precioCosto,stock,stockMinimo, procentajeGanancia FROM Productos WHERE id_Productos > 1";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            DataTable dtProductos = new DataTable();

            return dtProductos;
        }


        // AGREGAR PRODUCTOS
        public void agregarProductosD(ProductosL productos)
        {
            string query = "SELECT COUNT(*) FROM Productos WHERE codigo = @codigo";
            string añadirProducto = "INSERT INTO Productos (Codigo , nombreProducto, nombreCorto,precioCosto,stock,stockMinimo, procentajeGanancia)" +
                "VALUES (@Codigo , @nombreProducto, @nombreCorto,@precioCosto,@stock,@stockMinimo, @procentajeGanancia)";

            conexion.Open();

            comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Codigo", productos.Codigo);

            int count = (int)comando.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Nombre de Producto existente, por favor busque otro");
            }
            else
            {
                comando = new SqlCommand(añadirProducto, conexion);

                
                comando.Parameters.AddWithValue("@codigo", productos.Codigo);
                comando.Parameters.AddWithValue("@nombreProducto", productos.nombreProducto);
                comando.Parameters.AddWithValue("@nombreCorto", productos.nombreCorto);
                comando.Parameters.AddWithValue("@precioCosto", productos.precioCosto);
                comando.Parameters.AddWithValue("@stock", productos.stock);
                comando.Parameters.AddWithValue("@stockMinimo", productos.stockMinimo);
                comando.Parameters.AddWithValue("@procentajeGanancia", productos.procentajeGanancia);
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto añadido");
            }

            conexion.Close();
        }

        // MODIFICAR PRODUCTOS
        public void modificarProductosD(ProductosL productos)
        {
            string query = "UPDATE Empleados SET Codigo = @Codigo, nombreProducto = @nombreProducto, nombreCorto = @nombreCorto, precioCosto = @precioCosto, stock = @stock, stockMinimo = @stockMinimo, procentajeGanancia = @procentajeGanancia WHERE id_producto = @id_producto";

            conexion.Open();

            comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@id_producto", productos.id_producto);
            comando.Parameters.AddWithValue("@codigo", productos.Codigo);
            comando.Parameters.AddWithValue("@nombreProducto", productos.nombreProducto);
            comando.Parameters.AddWithValue("@nombreCorto", productos.nombreCorto);
            comando.Parameters.AddWithValue("@precioCosto", productos.precioCosto);
            comando.Parameters.AddWithValue("@stock", productos.stock);
            comando.Parameters.AddWithValue("@stockMinimo", productos.stockMinimo);
            comando.Parameters.AddWithValue("@procentajeGanancia", productos.procentajeGanancia);
            comando.ExecuteNonQuery();

            MessageBox.Show("Producto modificado");
            conexion.Close();
        }

        // ELIMINAR PRODUCTOS
        public void eliminarProductosD(ProductosL productos)
        {
            string query = "DELETE Productos WHERE id_Productos = @id_producto";

            conexion.Open();
            comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id:producto", productos.id_producto);
            comando.ExecuteNonQuery();
            MessageBox.Show("Producto eliminado");
            conexion.Close();
        }
    }
}

