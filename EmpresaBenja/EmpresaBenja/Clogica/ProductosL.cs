using EmpresaBenja.CDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaBenja.Clogica
{
    internal class ProductosL
    {
        ProductosD datos = new ProductosD();

        
        public int id_producto { get; set; }
        public string Codigo { get; set; }
        public string nombreProducto { get; set; }
        public string nombreCorto { get; set; }
        public string precioCosto { get; set; }
        public String stock { get; set; }
        public string stockMinimo { get; set; }
        public int procentajeGanancia { get; set; }


        public DataTable ObtenerProductosL()
        {
            return datos.ObtenerProductosD();
        }

        public void agregarProductosL(ProductosL productos)
        {
            datos.agregarProductosD(productos);
        }

        public void modificarProductoL(ProductosL productos)
        {
            datos.modificarProductosD(productos);
        }

        public void eliminarProductoL(ProductosL productos)
        {
            datos.eliminarProductosD(productos);
        }
    }
}

