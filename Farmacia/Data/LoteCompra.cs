﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Data
{
    public class LoteCompra
    {
        public int IdLoteCompra { get; set; }
        public int IdLote { get; set; }
        public int IdCompra { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
