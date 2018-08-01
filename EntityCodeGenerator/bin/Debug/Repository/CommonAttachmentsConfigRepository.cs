using CSWF.CommonService.RepositoryBase;
using CSWF.CommonService.Entity;
using System.Data.Entity;

namespace CSWF.CommonService.Repository
{
    public class CommonAttachmentsConfigRepository : RepositoryBase<CommonAttachmentsConfig>
    {
		public CommonAttachmentsConfigRepository(string connectionString):base(connectionString)
        { }

        public CommonAttachmentsConfigRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
