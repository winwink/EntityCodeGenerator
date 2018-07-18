using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class EventSelfCheckResultRepository : RepositoryBase<EventSelfCheckResult>
    {
		public EventSelfCheckResultRepository(string connectionString):base(connectionString)
        { }

        public EventSelfCheckResultRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
