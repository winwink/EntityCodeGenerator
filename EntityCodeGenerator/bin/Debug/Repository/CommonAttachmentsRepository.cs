using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class CommonAttachmentsRepository : RepositoryBase<CommonAttachments>
    {
		public CommonAttachmentsRepository(string connectionString):base(connectionString)
        { }

        public CommonAttachmentsRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
