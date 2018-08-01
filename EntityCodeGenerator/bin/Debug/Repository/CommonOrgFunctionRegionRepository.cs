using CSWF.CommonService.RepositoryBase;
using CSWF.CommonService.Entity;
using System.Data.Entity;

namespace CSWF.CommonService.Repository
{
    public class CommonOrgFunctionRegionRepository : RepositoryBase<CommonOrgFunctionRegion>
    {
		public CommonOrgFunctionRegionRepository(string connectionString):base(connectionString)
        { }

        public CommonOrgFunctionRegionRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
