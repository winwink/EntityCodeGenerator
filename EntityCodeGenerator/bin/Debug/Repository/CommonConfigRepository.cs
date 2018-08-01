using CSWF.CommonService.RepositoryBase;
using CSWF.CommonService.Entity;
using System.Data.Entity;

namespace CSWF.CommonService.Repository
{
    public class CommonConfigRepository : RepositoryBase<CommonConfig>
    {
		public CommonConfigRepository(string connectionString):base(connectionString)
        { }

        public CommonConfigRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
