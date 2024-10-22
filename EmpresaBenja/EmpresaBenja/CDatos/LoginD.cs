using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpresaBenja.Clogica;
using EmpresaBenja.CPresentacion;

namespace EmpresaBenja.CDatos
{
    internal class LoginD
    {
        SqlConnection conexion = new SqlConnection("server= DESKTOP-6RV4JMD\\SQLEXPRESS;database= PROYECTO ;integrated security= true");
        SqlCommand comando;
        SqlDataReader leer;

        // INGRESAR LOGIN
        public bool ingresarLoginD(LoginL login)
        {
            string query = "SELECT usuario, clave FROM Empleados WHERE usuario = @usuario AND clave = @clave";

            conexion.Open();

            comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@usuario", login.usuario);
            comando.Parameters.AddWithValue("@clave", login.clave);

            leer = comando.ExecuteReader();

            if (leer.Read())
            {
                conexion.Close();
                return true;
            }
            else
            {
                conexion.Close();
                return false;
            }

        }

        // AGREAGR EMPLEADO
        public void agregarEmpleadoD(LoginL login)
        {
            string query = "SELECT COUNT(*) FROM Empleados WHERE usuario = @usuario";
            string añadirEmpleado = "INSERT INTO Empleados (dni, apellido, nombre, telefono, fechaNac, usuario, clave, rol)" +
                "VALUES (@dni, @apellido, @nombre, @telefono, @fechaNac, @usuario, @clave, @rol)";

            conexion.Open();

            comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@usuario", login.usuario);

            int count = (int)comando.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Nombre de usuario existente, por favor coloque otro");
            }
            else
            {
                comando = new SqlCommand(añadirEmpleado, conexion);
                comando.Parameters.AddWithValue("@dni", login.dni);
                comando.Parameters.AddWithValue("@apellido", login.apellido);
                comando.Parameters.AddWithValue("@nombre", login.nombre);
                comando.Parameters.AddWithValue("@telefono", login.telefono);
                comando.Parameters.AddWithValue("@fechaNac", login.fechaNac);
                comando.Parameters.AddWithValue("@usuario", login.usuario);
                comando.Parameters.AddWithValue("@clave", login.clave);
                comando.Parameters.AddWithValue("@rol", login.rol);
                comando.ExecuteNonQuery();
                MessageBox.Show("Empelado añadido");
            }

            conexion.Close();
        }

        // SELECCIONAR ROL
        public void selccionarRolD(LoginL login)
        {
            string query = "SELECT rol FROM Empleados WHERE usuario = @usuario";

            conexion.Open();

            comando = new SqlCommand (query, conexion);
            comando.Parameters.AddWithValue("@usuario", login.usuario);

            leer = comando.ExecuteReader();

            if (leer.Read())
            {
                login.rol = leer["rol"].ToString();
            }

            conexion.Close ();
        }
    }
}