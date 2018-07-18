using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class EventRequestBudgetRepository : RepositoryBase<EventRequestBudget>
    {
		public EventRequestBudgetRepository(string connectionString):base(connectionString)
        { }

        public EventRequestBudgetRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
