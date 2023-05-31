using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork:IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();

        public void Dispose()
        {
           db.Dispose();
        }
    }
}
