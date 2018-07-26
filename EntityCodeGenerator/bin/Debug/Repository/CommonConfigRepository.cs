using Common.CSWF.RepositoryBase;
using Common.CSWF.Entity;
using System.Data.Entity;

namespace Common.CSWF.Repository
{
    public class CommonConfigRepository : RepositoryBase<CommonConfig>
    {
		public CommonConfigRepository(string connectionString):base(connectionString)
        { }

        public CommonConfigRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
