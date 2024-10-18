using EmpresaBenja.CDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaBenja.Clogica
{
    internal class ComprobanteL
    {
        ComprobanteD datos = new ComprobanteD();

        public string tipo { get; set; }
        public string numero { get; set; }
        public DateTime fecha { get; set; }
        public string empleado{ get; set; }
        public int id_empleado { get; set; }
        public int cliente{ get; set; }
        public decimal monto { get; set; }

        public void crearComprobanteL(ComprobanteL comprobante)
        {
            comprobante.id_empleado = datos.busacarID(comprobante);

            datos.crearComprobanteD(comprobante);
        }
    }
}
