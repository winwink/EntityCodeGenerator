using CSWF.CommonService.RepositoryBase;
using CSWF.CommonService.Entity;
using System.Data.Entity;

namespace CSWF.CommonService.Repository
{
    public class CommonAttachmentsRepository : RepositoryBase<CommonAttachments>
    {
		public CommonAttachmentsRepository(string connectionString):base(connectionString)
        { }

        public CommonAttachmentsRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
