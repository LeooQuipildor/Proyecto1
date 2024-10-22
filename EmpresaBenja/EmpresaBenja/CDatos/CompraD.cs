using EmpresaBenja.Clogica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaBenja.CDatos
{
    internal class CompraD
    {
        SqlConnection conexion = new SqlConnection("server= DESKTOP-6RV4JMD\\SQLEXPRESS;database= PROYECTO;integrated security= true");
        SqlCommand comando;
        SqlDataReader leer;

        //AGREGAR PRODUCTO
        public void agregarProductoD(CompraL compras)
        {
            string query = "SELECT COUNT(*) FROM Productos WHERE nombreProducto = @nombreProducto";
            string añadirProducto = "INSERT INTO Productos (nombreProducto, nombreCorto, precioCosto, stock, stockMinimo, procentajeGanancia)" +
                "VALUES (@nombreProducto, @nombreCorto, @precioCosto, @cantidad,@stockMinimo, @porcentajeGanancia)";

            conexion.Open();

            comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombreProducto", compras.nombreProducto);

            int count = (int)comando.ExecuteScalar();
            if (count == 0)
            {
                // agregamos el producto
                comando = new SqlCommand(añadirProducto, conexion);
                comando.Parameters.AddWithValue("@nombreProducto", compras.nombreProducto);
                comando.Parameters.AddWithValue("@nombreCorto", compras.nombreCorto);
                comando.Parameters.AddWithValue("@precioCosto", compras.precioCosto);
                comando.Parameters.AddWithValue("@cantidad", compras.cantidad);
                comando.Parameters.AddWithValue("@stockMinimo", compras.stockMinimo);
                comando.Parameters.AddWithValue("@porcentajeGanancia", compras.porcentajeGanancia);
                comando.ExecuteNonQuery();
            }
            else
            {
                // Solo actualizamos el stock al producto ya almacenado
                conexion.Close();
                compras.actualizarStockL(compras);
            }

            conexion.Close();
        }

        // TRAER STOCK ACTUAL
        public decimal traerStockActualD(CompraL compras)
        {
            decimal stockActual;
            string query = "SELECT stock FROM Productos WHERE nombreProducto = @nombreProducto";

            conexion.Open();
            comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombreProducto", compras.nombreProducto);

            leer = comando.ExecuteReader();

            if (leer.Read())
            {
                stockActual = Convert.ToDecimal(leer["stock"]);
                conexion.Close();
                return stockActual;
            }

            conexion.Close();
            return 0;
        }

        // ACTUALIZAR STOCK
        public void actualizarStockD(CompraL compras)
        {
            string query = "UPDATE Productos SET stock = @stock, precioCosto = @precioCosto, stockMinimo = @stockMinimo, procentajeGanancia = @porcentajeGanancia" +
                " WHERE nombreProducto = @nombreProducto";
            conexion.Open();

            comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@stock", compras.stock);
            comando.Parameters.AddWithValue("@stockMinimo", compras.stockMinimo);
            comando.Parameters.AddWithValue("@porcentajeGanancia", compras.porcentajeGanancia);
            comando.Parameters.AddWithValue("@nombreProducto", compras.nombreProducto);
            comando.Parameters.AddWithValue("@precioCosto", compras.precioCosto);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
