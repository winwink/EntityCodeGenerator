using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class CommonExportFilesRepository : RepositoryBase<CommonExportFiles>
    {
		public CommonExportFilesRepository(string connectionString):base(connectionString)
        { }

        public CommonExportFilesRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
