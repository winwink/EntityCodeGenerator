using RDCN.CPT.Data.RepositoryBase;
using RDCN.CPT.Data.Entity;
using System.Data.Entity;

namespace RDCN.CPT.Data.Repository
{
    public class CommonDictionaryRepository : RepositoryBase<CommonDictionary>
    {
		public CommonDictionaryRepository(string connectionString):base(connectionString)
        { }

        public CommonDictionaryRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
