using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class VReportsProcessingTimeRepository : RepositoryBase<VReportsProcessingTime>
    {
		public VReportsProcessingTimeRepository(string connectionString):base(connectionString)
        { }

        public VReportsProcessingTimeRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
