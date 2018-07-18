using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class VReportsWorkLogRepository : RepositoryBase<VReportsWorkLog>
    {
		public VReportsWorkLogRepository(string connectionString):base(connectionString)
        { }

        public VReportsWorkLogRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
