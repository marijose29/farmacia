using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public BindingList<DetalleCompra> Detalle {get;set; }
        public static Compra Get(int IdCompra) {
            return Default.Db.USPCOMPRASELECCIONAR<Record,Compra>(IdCompra: IdCompra);
        }
        public static BindingList<Compra> Get() {
            return new BindingList<Compra>(Default.Db.USPCOMPRASELECCIONAR<RecordSet, Compra>());
        }

        public Compra() {
            Detalle = new BindingList<DetalleCompra>();
        }

        public void Insert() {
            IdCompra = Default.Db.dbo.USPCOMPRAINSERTAR<int>(Record.FromInstance(this));
            foreach (DetalleCompra dc in Detalle)
            {
                dc.IdCompra = IdCompra;
                dc.IdDetalleCompra = Default.Db.dbo.USPDETALLECOMPRAINSERTAR<int>(Record.FromInstance(dc));
            }
        }

        public void Annulate() {
            Default.Db.dbo.USPCOMPRAANULAR(IdCompra: IdCompra);
        }
    }
}
