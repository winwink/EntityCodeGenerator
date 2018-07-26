using Common.CSWF.RepositoryBase;
using Common.CSWF.Entity;
using System.Data.Entity;

namespace Common.CSWF.Repository
{
    public class CommonLogRepository : RepositoryBase<CommonLog>
    {
		public CommonLogRepository(string connectionString):base(connectionString)
        { }

        public CommonLogRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
