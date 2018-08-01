using CSWF.CommonService.RepositoryBase;
using CSWF.CommonService.Entity;
using System.Data.Entity;

namespace CSWF.CommonService.Repository
{
    public class CommonOrgBusinessLineRepository : RepositoryBase<CommonOrgBusinessLine>
    {
		public CommonOrgBusinessLineRepository(string connectionString):base(connectionString)
        { }

        public CommonOrgBusinessLineRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
