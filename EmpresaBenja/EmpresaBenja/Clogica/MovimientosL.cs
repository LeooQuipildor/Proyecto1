using EmpresaBenja.CDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaBenja.Clogica
{
    internal class MovimientosL
    {
        MovimientosD datos = new MovimientosD();



            public string tipo { get; set; }
            public int numero { get; set; }
            public DateTime fecha { get; set; }
            public int empleado { get; set; }
            public int cliente { get; set; }
            public decimal monto { get; set; }
        public int id_producto { get; internal set; }

        public DataTable ObtenerMovimientos()
        {
            // Validaciones adicionales o filtros antes de devolver los movimientos
            return  datos.ObtenerMovimientosD();
        }

        public void RegistrarMovimiento(MovimientosL Movimiento)
        {
            // Validaciones adicionales antes de registrar un movimiento
            datos.RegistrarMovimientoD(Movimiento);
        }

        public void RegistrarCompra(MovimientosL Movimiento)
        {
            Movimiento.tipo = "Compra";
            RegistrarMovimiento(Movimiento);
        }

        public void RegistrarVenta(MovimientosL movimiento)
        {
            movimiento.tipo = "Venta";
            RegistrarMovimiento(movimiento);
        }

        internal void eliminarProductoL(MovimientosL movimientoL)
        {
            throw new NotImplementedException();
        }
    }
}
