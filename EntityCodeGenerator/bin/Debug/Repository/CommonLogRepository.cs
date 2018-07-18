using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class CommonLogRepository : RepositoryBase<CommonLog>
    {
		public CommonLogRepository(string connectionString):base(connectionString)
        { }

        public CommonLogRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
