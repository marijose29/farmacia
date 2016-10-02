using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Epn.Data;
using System.Data;

namespace Farmacia.Data
{
    public static class Default
    {
        private static IDb db = DbManager.Get<SqlDb>("defaultConnection");
        public static dynamic Db { get { return db; } }
    }
}
