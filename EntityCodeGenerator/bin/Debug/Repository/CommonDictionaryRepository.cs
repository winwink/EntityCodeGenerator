using Common.CSWF.RepositoryBase;
using Common.CSWF.Entity;
using System.Data.Entity;

namespace Common.CSWF.Repository
{
    public class CommonDictionaryRepository : RepositoryBase<CommonDictionary>
    {
		public CommonDictionaryRepository(string connectionString):base(connectionString)
        { }

        public CommonDictionaryRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
