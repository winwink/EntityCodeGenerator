using Common.CSWF.RepositoryBase;
using Common.CSWF.Entity;
using System.Data.Entity;

namespace Common.CSWF.Repository
{
    public class CommonOrgBusinessLineRepository : RepositoryBase<CommonOrgBusinessLine>
    {
		public CommonOrgBusinessLineRepository(string connectionString):base(connectionString)
        { }

        public CommonOrgBusinessLineRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
