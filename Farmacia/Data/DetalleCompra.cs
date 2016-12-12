using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Data
{
    public class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Importe { get; set; }
        public bool AplicaIVA { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
    }
}
