using Common.CSWF.RepositoryBase;
using Common.CSWF.Entity;
using System.Data.Entity;

namespace Common.CSWF.Repository
{
    public class CommonExportFilesRepository : RepositoryBase<CommonExportFiles>
    {
		public CommonExportFilesRepository(string connectionString):base(connectionString)
        { }

        public CommonExportFilesRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
