using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class EventMatchResultRepository : RepositoryBase<EventMatchResult>
    {
		public EventMatchResultRepository(string connectionString):base(connectionString)
        { }

        public EventMatchResultRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
