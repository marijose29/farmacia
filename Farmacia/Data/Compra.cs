using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Epn.Data;
using System.ComponentModel;

namespace Farmacia.Data
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public int IdProveedor { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Retencion { get; set; }
        public decimal Descuento { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
        public Proveedor Proveedor { get; set; }
        public static Compra Get(int IdCompra) {
            return Default.Db.USPCOMPRASELECCIONAR<Record,Compra>(IdCompra: IdCompra);
        }
        public static BindingList<Compra> Get() {
            return new BindingList<Compra>(Default.Db.USPCOMPRASELECCIONAR<RecordSet, Compra>());
        }

        public void Insert() { 
        
        }

        public void Update() { 
        }

        public void Delete() { 
        
        }

        public void Complete() { 
        
        }
    }
}
