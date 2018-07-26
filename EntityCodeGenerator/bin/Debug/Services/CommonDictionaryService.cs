using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using Common.CSWF.Repository;
using Common.CSWF.Entity;
using Common.CSWF.Core;


namespace Common.CSWF.Services
{

    public class CommonDictionaryService
    {
		private CommonDictionaryRepository _repo;
        private string _connectionString;

        public CommonDictionaryService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new CommonDictionaryRepository(_connectionString);
        }

        public CommonDictionary Read(int ID)
        {
            return _repo.Get(ID);
        }

        public int Create(CommonDictionary model)
        {
            _repo.Insert(model);
            return model.ID;
        }

        public void Update(CommonDictionary model)
        {
            _repo.Update(model);
        }

        public void Delete(int ID)
        {
            _repo.Delete(m => m.ID == ID);
        }

        public int CreateOrUpdate(CommonDictionary model)
        {
            var get = _repo.Get(model.ID);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.ID;
        }

        public List<CommonDictionary> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<CommonDictionary> List(Expression<Func<CommonDictionary, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<CommonDictionary> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
