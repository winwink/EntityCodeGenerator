using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class CommonOrgBusinessLineRepository : RepositoryBase<CommonOrgBusinessLine>
    {
		public CommonOrgBusinessLineRepository(string connectionString):base(connectionString)
        { }

        public CommonOrgBusinessLineRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
