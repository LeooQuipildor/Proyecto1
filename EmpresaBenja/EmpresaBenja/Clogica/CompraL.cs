using EmpresaBenja.CDatos;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace EmpresaBenja.Clogica
{
    internal class CompraL
    {
        CompraD datos = new CompraD();

        public int codigo { get; set; }
        public string nombreProducto { get; set; }
        public string nombreCorto { get; set; }
        public decimal precioCosto { get; set; }
        public decimal stock { get; set; }
        public decimal stockMinimo { get; set; }
        public decimal cantidad { get; set; }
        public int porcentajeGanancia { get; set; }


        public void agregarProductoL(CompraL compras)
        {
            datos.agregarProductoD(compras);
        }

        public void actualizarStockL(CompraL compras)
        {
            decimal stockActual = datos.traerStockActualD(compras);

            compras.stock = stockActual + compras.cantidad;

            datos.actualizarStockD(compras);
        }
    }
}
