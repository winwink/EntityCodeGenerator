using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class EventRequestScheduleRepository : RepositoryBase<EventRequestSchedule>
    {
		public EventRequestScheduleRepository(string connectionString):base(connectionString)
        { }

        public EventRequestScheduleRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
