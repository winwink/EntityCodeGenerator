using CSWF.CommonService.RepositoryBase;
using CSWF.CommonService.Entity;
using System.Data.Entity;

namespace CSWF.CommonService.Repository
{
    public class CommonDictionaryRepository : RepositoryBase<CommonDictionary>
    {
		public CommonDictionaryRepository(string connectionString):base(connectionString)
        { }

        public CommonDictionaryRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
