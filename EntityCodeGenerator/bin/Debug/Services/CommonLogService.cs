using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using Common.CSWF.Repository;
using Common.CSWF.Entity;
using Common.CSWF.Core;


namespace Common.CSWF.Services
{

    public class CommonLogService
    {
		private CommonLogRepository _repo;
        private string _connectionString;

        public CommonLogService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new CommonLogRepository(_connectionString);
        }

        public CommonLog Read(int ID)
        {
            return _repo.Get(ID);
        }

        public int Create(CommonLog model)
        {
            _repo.Insert(model);
            return model.ID;
        }

        public void Update(CommonLog model)
        {
            _repo.Update(model);
        }

        public void Delete(int ID)
        {
            _repo.Delete(m => m.ID == ID);
        }

        public int CreateOrUpdate(CommonLog model)
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

        public List<CommonLog> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<CommonLog> List(Expression<Func<CommonLog, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<CommonLog> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
