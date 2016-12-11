using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Farmacia.Data
{
    public class ProductoLote
    {
        public BindingList<DetalleLote> Detalle = new BindingList<DetalleLote>();
    }
}
