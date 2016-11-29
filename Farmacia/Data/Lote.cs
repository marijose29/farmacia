using Epn.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Data
{
    public class Lote
    {
        public int IdLote { get; set; }
        public int IdProducto { get; set; }
        public int Numero { get; set; }
        public DateTime FechaLote { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Existencia { get; set; }

        public Producto Producto { get; set; }
       
        public static Lote Get(int IdLote) {
            return Data.Default.Db.USPLOTESELECCIONAR<Record, Lote>(IdLote: IdLote);
        }

        public static BindingList<Lote> Get() {
            return new BindingList<Lote>(Data.Default.Db.USPLOTESELECCIONAR<RecordSet, Lote>());
        }
        public void Insert() {
            IdLote = Data.Default.Db.USPLOTEINSERTAR<int>(Record.FromInstance(this));
        }

        public void Delete() {
            Data.Default.Db.USPLOTEELIMINAR(IdLote: IdLote);
        }

        public void Update() {
            Data.Default.Db.USPLOTEACTUALIZAR(Record.FromInstance(this));
        }

        public void Complete() {
            Producto = Producto.Get(IdProducto);
        }
    }
}
