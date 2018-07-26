using Common.CSWF.RepositoryBase;
using Common.CSWF.Entity;
using System.Data.Entity;

namespace Common.CSWF.Repository
{
    public class CommonAttachmentsConfigRepository : RepositoryBase<CommonAttachmentsConfig>
    {
		public CommonAttachmentsConfigRepository(string connectionString):base(connectionString)
        { }

        public CommonAttachmentsConfigRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
