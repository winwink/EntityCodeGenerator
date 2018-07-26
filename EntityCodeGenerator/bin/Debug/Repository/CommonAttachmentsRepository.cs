using Common.CSWF.RepositoryBase;
using Common.CSWF.Entity;
using System.Data.Entity;

namespace Common.CSWF.Repository
{
    public class CommonAttachmentsRepository : RepositoryBase<CommonAttachments>
    {
		public CommonAttachmentsRepository(string connectionString):base(connectionString)
        { }

        public CommonAttachmentsRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
