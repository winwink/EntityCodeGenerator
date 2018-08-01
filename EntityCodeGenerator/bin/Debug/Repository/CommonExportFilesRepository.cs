using CSWF.CommonService.RepositoryBase;
using CSWF.CommonService.Entity;
using System.Data.Entity;

namespace CSWF.CommonService.Repository
{
    public class CommonExportFilesRepository : RepositoryBase<CommonExportFiles>
    {
		public CommonExportFilesRepository(string connectionString):base(connectionString)
        { }

        public CommonExportFilesRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
