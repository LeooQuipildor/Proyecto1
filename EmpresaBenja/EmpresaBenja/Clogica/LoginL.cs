using EmpresaBenja.CDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaBenja.Clogica
{
    internal class LoginL
    {
        LoginD datos = new LoginD();

        public string rol { get; set; }
        public string dni { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public DateTime fechaNac { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }


        public void agregarEmpleadoL(LoginL login)
        {
            datos.agregarEmpleadoD(login);
        }

        public bool ingresarLoginL(LoginL login)
        {
            return datos.ingresarLoginD(login);
        }

        public void seleccionarRolL(LoginL login)
        {
            datos.selccionarRolD(login);
        }
    }
}
