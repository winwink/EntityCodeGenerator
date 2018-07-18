using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class CommonOrgBusinessAreaRepository : RepositoryBase<CommonOrgBusinessArea>
    {
		public CommonOrgBusinessAreaRepository(string connectionString):base(connectionString)
        { }

        public CommonOrgBusinessAreaRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
