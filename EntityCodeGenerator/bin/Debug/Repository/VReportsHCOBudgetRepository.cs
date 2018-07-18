using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class VReportsHCOBudgetRepository : RepositoryBase<VReportsHCOBudget>
    {
		public VReportsHCOBudgetRepository(string connectionString):base(connectionString)
        { }

        public VReportsHCOBudgetRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
