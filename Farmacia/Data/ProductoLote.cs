using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Epn.Data;

namespace Farmacia.Data
{
    public class ProductoLote
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public BindingList<Lote> Detalle = new BindingList<Lote>();

        public static BindingList<ProductoLote> Get()
        {
            return new BindingList<ProductoLote>(Default.Db.dbo.USPPRODUCTOSELECCIONAR<RecordSet, ProductoLote>());
        }
    }
}
