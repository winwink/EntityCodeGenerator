using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class CommonConfigSendMailRepository : RepositoryBase<CommonConfigSendMail>
    {
		public CommonConfigSendMailRepository(string connectionString):base(connectionString)
        { }

        public CommonConfigSendMailRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
