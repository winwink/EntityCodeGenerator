using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class ContractRequestRepository : RepositoryBase<ContractRequest>
    {
		public ContractRequestRepository(string connectionString):base(connectionString)
        { }

        public ContractRequestRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
