using CSWF.CommonService.RepositoryBase;
using CSWF.CommonService.Entity;
using System.Data.Entity;

namespace CSWF.CommonService.Repository
{
    public class CommonLogRepository : RepositoryBase<CommonLog>
    {
		public CommonLogRepository(string connectionString):base(connectionString)
        { }

        public CommonLogRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
