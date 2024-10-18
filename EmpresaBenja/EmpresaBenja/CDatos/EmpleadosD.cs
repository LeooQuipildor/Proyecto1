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
    internal class EmpleadosD
    {
        SqlConnection conexion = new SqlConnection("server=.;database=EMPRESA_BENJA;integrated security= true");
        SqlCommand comando;
        SqlDataReader leer;


        // MOSTRAR EMPLEADOS
        public DataTable ObtenerEmpleadosD()
        {
            string query = "SELECT id_empleado, dni, apellido, nombre, telefono, fechaNac, usuario, clave,rol FROM Empleados WHERE id_empleado > 1";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            DataTable dtEmpleados = new DataTable();

            adapter.Fill(dtEmpleados);
            return dtEmpleados;
        }


        // AGREAGR EMPLEADO
        public void agregarEmpleadoD(EmpleadosL empleados)
        {
            string query = "SELECT COUNT(*) FROM Empleados WHERE usuario = @usuario";
            string añadirEmpleado = "INSERT INTO Empleados (dni, apellido, nombre, telefono, fechaNac, usuario, clave, rol)" +
                "VALUES (@dni, @apellido, @nombre, @telefono, @fechaNac, @usuario, @clave, @rol)";

            conexion.Open();

            comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@usuario", empleados.usuario);

            int count = (int)comando.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Nombre de usuario existente, por favor coloque otro");
            }
            else
            {
                comando = new SqlCommand(añadirEmpleado, conexion);

                comando.Parameters.AddWithValue("@rol", empleados.rol);
                comando.Parameters.AddWithValue("@dni", empleados.dni);
                comando.Parameters.AddWithValue("@apellido", empleados.apellido);
                comando.Parameters.AddWithValue("@nombre", empleados.nombre);
                comando.Parameters.AddWithValue("@telefono", empleados.telefono);
                comando.Parameters.AddWithValue("@fechaNac", empleados.fechaNac);
                comando.Parameters.AddWithValue("@usuario", empleados.usuario);
                comando.Parameters.AddWithValue("@clave", empleados.clave);
                comando.ExecuteNonQuery();
                MessageBox.Show("Empelado añadido");
            }

            conexion.Close();
        }

        // MODIFICAR EMPLEADO
        public void modificarEmpleadoD(EmpleadosL empleados)
        {
            string query = "UPDATE Empleados SET dni = @dni, apellido = @apellido, nombre = @nombre, telefono = @telefono, fechaNac = @fechaNac, usuario = @usuario, clave = @clave WHERE id_empleado = @id";

            conexion.Open();

            comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", empleados.id);
            comando.Parameters.AddWithValue("@dni", empleados.dni);
            comando.Parameters.AddWithValue("@apellido", empleados.apellido);
            comando.Parameters.AddWithValue("@nombre", empleados.nombre);
            comando.Parameters.AddWithValue("@telefono", empleados.telefono);
            comando.Parameters.AddWithValue("@fechaNac", empleados.fechaNac);
            comando.Parameters.AddWithValue("@usuario", empleados.usuario);
            comando.Parameters.AddWithValue("@clave", empleados.clave);
            comando.ExecuteNonQuery();

            MessageBox.Show("Empleado modificado");
            conexion.Close();
        }

        // ELIMINAR EMPLEADO
        public void eliminarEmpleadoD(EmpleadosL empleados)
        {
            string query = "DELETE Empleados WHERE id_empleado = @id";

            conexion.Open();
            comando = new SqlCommand (query, conexion);
            comando.Parameters.AddWithValue("@id", empleados.id);
            comando.ExecuteNonQuery ();
            MessageBox.Show("Empleado eliminado");
            conexion.Close();
        }
    }
}
