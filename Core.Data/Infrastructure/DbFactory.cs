using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        CoreDbContext dbContext;

        public CoreDbContext Init()
        {
            return dbContext ?? (dbContext = new CoreDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
