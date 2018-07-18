using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class CommonOrgFunctionRegionRepository : RepositoryBase<CommonOrgFunctionRegion>
    {
		public CommonOrgFunctionRegionRepository(string connectionString):base(connectionString)
        { }

        public CommonOrgFunctionRegionRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
