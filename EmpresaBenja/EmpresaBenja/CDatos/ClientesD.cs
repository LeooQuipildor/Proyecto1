using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaBenja.Clogica;
using System.Windows.Forms;

namespace EmpresaBenja.CDatos
{
    internal class ClientesD
    {
        SqlConnection conexion = new SqlConnection("server=.;database=EMPRESA_BENJA;integrated security= true");
        SqlCommand comando;
        SqlDataReader leer;


        // MOSTRAR CLIENTES
        public DataTable ObtenerClientesD()
        {
            string query = "SELECT id_cliente, apellido, nombre, telefono, fechaNac, descuento FROM Clientes";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            DataTable dtClientes = new DataTable();

            adapter.Fill(dtClientes);
            return dtClientes;
        }

        // AGREAGR CLIENTE
        public void agregarClienteD(ClientesL cliente)
        {
            string añadirCliente = "INSERT INTO Clientes (apellido, nombre, telefono, fechaNac, descuento)" +
                "VALUES (@apellido, @nombre, @telefono, @fechaNac, @descuento)";

            conexion.Open();

            comando = new SqlCommand(añadirCliente, conexion);

            comando.Parameters.AddWithValue("@apellido", cliente.apellido);
            comando.Parameters.AddWithValue("@nombre", cliente.nombre);
            comando.Parameters.AddWithValue("@telefono", cliente.telefono);
            comando.Parameters.AddWithValue("@fechaNac", cliente.fechaNac);
            comando.Parameters.AddWithValue("@descuento", cliente.descuento);
            comando.ExecuteNonQuery();

            MessageBox.Show("Cliente añadido");

            conexion.Close();
        }


        // MODIFICAR CLIENTE
        public void modificarClienteD(ClientesL cliente)
        {
            string query = "UPDATE Clientes SET apellido = @apellido, nombre = @nombre, telefono = @telefono, fechaNac = @fechaNac, descuento = @descuento" +
                " WHERE id_cliente = @id";

            conexion.Open();

            comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", cliente.id);
            comando.Parameters.AddWithValue("@apellido", cliente.apellido);
            comando.Parameters.AddWithValue("@nombre", cliente.nombre);
            comando.Parameters.AddWithValue("@telefono", cliente.telefono);
            comando.Parameters.AddWithValue("@fechaNac", cliente.fechaNac);
            comando.Parameters.AddWithValue("@descuento", cliente.descuento);

            comando.ExecuteNonQuery();

            MessageBox.Show("Cliente modificado");
            conexion.Close();
        }


        // ELIMINAR CLIENTE
        public void eliminarClienteD(ClientesL cliente)
        {
            string query = "DELETE Clientes WHERE id_cliente= @id";

            conexion.Open();
            comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", cliente.id);
            comando.ExecuteNonQuery();
            MessageBox.Show("Cliente eliminado");
            conexion.Close();
        }
    }
}
