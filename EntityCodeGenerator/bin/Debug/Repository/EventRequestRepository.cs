using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class EventRequestRepository : RepositoryBase<EventRequest>
    {
		public EventRequestRepository(string connectionString):base(connectionString)
        { }

        public EventRequestRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
