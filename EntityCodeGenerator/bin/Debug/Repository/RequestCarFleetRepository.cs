using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class RequestCarFleetRepository : RepositoryBase<RequestCarFleet>
    {
		public RequestCarFleetRepository(string connectionString):base(connectionString)
        { }

        public RequestCarFleetRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
