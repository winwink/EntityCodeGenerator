using Common.CSWF.RepositoryBase;
using Common.CSWF.Entity;
using System.Data.Entity;

namespace Common.CSWF.Repository
{
    public class CommonOrgFunctionRegionRepository : RepositoryBase<CommonOrgFunctionRegion>
    {
		public CommonOrgFunctionRegionRepository(string connectionString):base(connectionString)
        { }

        public CommonOrgFunctionRegionRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
