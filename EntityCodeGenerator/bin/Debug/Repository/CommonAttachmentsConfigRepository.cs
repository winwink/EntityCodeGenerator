using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class CommonAttachmentsConfigRepository : RepositoryBase<CommonAttachmentsConfig>
    {
		public CommonAttachmentsConfigRepository(string connectionString):base(connectionString)
        { }

        public CommonAttachmentsConfigRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
