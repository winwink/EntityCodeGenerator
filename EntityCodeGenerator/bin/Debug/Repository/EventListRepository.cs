using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class EventListRepository : RepositoryBase<EventList>
    {
		public EventListRepository(string connectionString):base(connectionString)
        { }

        public EventListRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
