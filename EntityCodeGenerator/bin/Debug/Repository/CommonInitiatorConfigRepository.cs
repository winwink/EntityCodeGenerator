using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class CommonInitiatorConfigRepository : RepositoryBase<CommonInitiatorConfig>
    {
		public CommonInitiatorConfigRepository(string connectionString):base(connectionString)
        { }

        public CommonInitiatorConfigRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
