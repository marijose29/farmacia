using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Open.Data;

namespace Farmacia.Data
{
    public static class Default
    {
        private static IDb db = DbManager.Get<MSSQLDb>("defaultConnection");
        public static dynamic Db { get { return db; } }
    }
}
