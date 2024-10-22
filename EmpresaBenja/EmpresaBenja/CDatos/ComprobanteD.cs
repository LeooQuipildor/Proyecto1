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
    internal class ComprobanteD
    {
        SqlConnection conexion = new SqlConnection("server= DESKTOP-6RV4JMD\\SQLEXPRESS; database= PROYECTO ; integrated security= true");
        SqlCommand comando;
        SqlDataReader leer;


        // CREAR COMPROBANTE
        public void crearComprobanteD(ComprobanteL comprobante)
        {
            string query = "SELECT COUNT(*) FROM ComprobantesEmitidos WHERE numero = @numero";
            string añadirComprobante = "INSERT INTO ComprobantesEmitidos (tipo, numero, fecha, empleado, cliente, monto)" +
                "VALUES (@tipo, @numero, @fecha, @id_empleado, @id_cliente, @monto)";

            conexion.Open();

            comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@numero", comprobante.numero);

            int count = (int)comando.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("El número de comprobante ya existe, coloque otro");
            }
            else
            {
                comando = new SqlCommand(añadirComprobante, conexion);
                comando.Parameters.AddWithValue("@tipo", comprobante.tipo);
                comando.Parameters.AddWithValue("@numero", comprobante.numero);
                comando.Parameters.AddWithValue("@fecha", comprobante.fecha);
                comando.Parameters.AddWithValue("@id_empleado", comprobante.id_empleado);
                comando.Parameters.AddWithValue("@id_cliente", comprobante.cliente);
                comando.Parameters.AddWithValue("@monto", comprobante.monto);

                comando.ExecuteNonQuery();
            }

            conexion.Close();
        }

        // BUSACAR ID DE EMPLEADO POR EL NOMBRE
        public int busacarID(ComprobanteL comprobante)
        {
            int id;
            string query = "SELECT id_empleado FROM Empleados WHERE usuario = @usuario";

            conexion.Open();

            comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@usuario", comprobante.empleado);

            leer = comando.ExecuteReader();

            if (leer.Read())
            {
                id = Convert.ToInt32(leer["id_empleado"]);
                conexion.Close();
                return id;
            }

            conexion.Close();
            return 0;
        }
    }
}












