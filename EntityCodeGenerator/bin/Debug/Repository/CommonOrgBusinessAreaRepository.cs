using Common.CSWF.RepositoryBase;
using Common.CSWF.Entity;
using System.Data.Entity;

namespace Common.CSWF.Repository
{
    public class CommonOrgBusinessAreaRepository : RepositoryBase<CommonOrgBusinessArea>
    {
		public CommonOrgBusinessAreaRepository(string connectionString):base(connectionString)
        { }

        public CommonOrgBusinessAreaRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
