using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class VReportsRequestDetailsWithStepRepository : RepositoryBase<VReportsRequestDetailsWithStep>
    {
		public VReportsRequestDetailsWithStepRepository(string connectionString):base(connectionString)
        { }

        public VReportsRequestDetailsWithStepRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
