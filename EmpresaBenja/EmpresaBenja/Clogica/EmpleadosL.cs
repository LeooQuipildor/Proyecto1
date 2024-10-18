using EmpresaBenja.CDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaBenja.Clogica
{
    internal class EmpleadosL
    {
        EmpleadosD datos = new EmpleadosD();

        public string rol { get; set; }
        public int id { get; set; }
        public string dni { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public DateTime fechaNac { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }


        public DataTable ObtenerEmpleadosL()
        {
            return datos.ObtenerEmpleadosD();
        }

        public void agregarEmpleadoL(EmpleadosL empleados)
        {
            datos.agregarEmpleadoD(empleados);
        }

        public void modificarEmpleadoD(EmpleadosL empleados)
        {
            datos.modificarEmpleadoD(empleados);
        }

        public void eliminarEmpleadoL(EmpleadosL empleados)
        {
            datos.eliminarEmpleadoD(empleados);
        }
    }
}
