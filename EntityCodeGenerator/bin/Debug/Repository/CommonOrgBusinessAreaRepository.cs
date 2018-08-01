using CSWF.CommonService.RepositoryBase;
using CSWF.CommonService.Entity;
using System.Data.Entity;

namespace CSWF.CommonService.Repository
{
    public class CommonOrgBusinessAreaRepository : RepositoryBase<CommonOrgBusinessArea>
    {
		public CommonOrgBusinessAreaRepository(string connectionString):base(connectionString)
        { }

        public CommonOrgBusinessAreaRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
