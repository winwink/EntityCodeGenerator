using CSWF.CommonService.RepositoryBase;
using CSWF.CommonService.Entity;
using System.Data.Entity;

namespace CSWF.CommonService.Repository
{
    public class RequestCarFleetRepository : RepositoryBase<RequestCarFleet>
    {
		public RequestCarFleetRepository(string connectionString):base(connectionString)
        { }

        public RequestCarFleetRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
