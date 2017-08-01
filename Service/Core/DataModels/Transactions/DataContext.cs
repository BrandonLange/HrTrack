using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Transactions
{
    public class DataContext : IDisposable
    {
        private HrTrackEntities _context = null;
        public HrTrackEntities Context
        {
            get
            {
                _context = new HrTrackEntities();
                _context.Configuration.AutoDetectChangesEnabled = false;
                _context.Configuration.ProxyCreationEnabled = false;
                _context.Configuration.LazyLoadingEnabled = false;

                return _context;
            }
            set
            {
                _context = value;
            }
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
