using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int idCompra { get; set; }
        public Personal oUsuario { get; set; }  // ver esta parte - lo que quiero es registrar los datos del personal que realizo esa actividad
        public Proveedor oProveedor { get; set; } // registrar proveedor
                                                  // public List <DetalleCompra> oDetalleCompra { get; set; }    // aqui va lista por una compra puede involucrar varios productos
        public string numeroDocumento { get; set; }
        public decimal montoTotalCompra { get; set; }
        public DateTime fechaCompra { get; set; }

    }
}
