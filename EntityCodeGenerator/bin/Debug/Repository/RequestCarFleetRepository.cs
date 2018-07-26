using Common.CSWF.RepositoryBase;
using Common.CSWF.Entity;
using System.Data.Entity;

namespace Common.CSWF.Repository
{
    public class RequestCarFleetRepository : RepositoryBase<RequestCarFleet>
    {
		public RequestCarFleetRepository(string connectionString):base(connectionString)
        { }

        public RequestCarFleetRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
