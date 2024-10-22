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
    internal class MovimientosD
    {
        SqlConnection conexion = new SqlConnection("server= DESKTOP-6RV4JMD\\SQLEXPRESS;database= PROYECTO ;integrated security= true");
        SqlCommand comando;
        SqlDataReader leer;


        // MOSTRAR PRODUCTOS
        public DataTable ObtenerMovimientosD()
        {
            string query = "SELECT * FROM ComprobantesEmitidos ";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            DataTable dtMovimientos = new DataTable();

            adapter.Fill(dtMovimientos);
            return dtMovimientos;
        }


        // AGREGAR PRODUCTOS
        public void RegistrarMovimientoD(MovimientosL Movimiento)
        {
            string query = "SELECT COUNT(*) FROM ComprobantesEmitidos";
            string añadirMovimiento = "INSERT INTO ComprobantesEmitidos (tipo, numero, fecha, empleado, cliente, monto)" +
                       "VALUES (@tipo, @numero, @fecha, @id_empleado, @id_cliente, @monto)";

            conexion.Open();

            comando = new SqlCommand(query, conexion);
            

            int count = (int)comando.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Movimento Registrado");
            }
            else
            {
                comando = new SqlCommand(añadirMovimiento, conexion);

                comando.Parameters.AddWithValue("@tipo", Movimiento.tipo);
                comando.Parameters.AddWithValue("@numero", Movimiento.numero);
                comando.Parameters.AddWithValue("@fecha", Movimiento.fecha);
                comando.Parameters.AddWithValue("@empleado", Movimiento.empleado);
                comando.Parameters.AddWithValue("@cliente", Movimiento.cliente);
                comando.Parameters.AddWithValue("@monto", Movimiento.monto);
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto añadido");
            }

            conexion.Close();
        }
    }
}

