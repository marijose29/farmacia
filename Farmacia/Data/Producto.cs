using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Data
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Especificaciones { get; set; }
        public string Descripcion { get; set; }

        public static Producto Get(int IdProducto)
        {
            return Data.Default.Db.USPPRODUCTOSELECCIONAR<Producto>(IdProducto: IdProducto);
        }
    }
}
