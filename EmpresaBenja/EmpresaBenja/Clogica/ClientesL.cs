using EmpresaBenja.CDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaBenja.Clogica
{
    internal class ClientesL
    {
        ClientesD datos = new ClientesD();

        public int  id { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public DateTime fechaNac { get; set; }
        public int descuento { get; set; }

        public DataTable ObtenerClientesL()
        {
            return datos.ObtenerClientesD();
        }

        public void agregarClienteL(ClientesL cliente)
        {
            datos.agregarClienteD(cliente);
        }

        public void modificarClienteL(ClientesL cliente)
        {
            datos.modificarClienteD(cliente);
        }

        public void eliminarClienteL(ClientesL cliente)
        {
            datos.eliminarClienteD(cliente);
        }
    }
}
