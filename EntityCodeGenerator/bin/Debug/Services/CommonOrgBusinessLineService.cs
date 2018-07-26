using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using Common.CSWF.Repository;
using Common.CSWF.Entity;
using Common.CSWF.Core;


namespace Common.CSWF.Services
{

    public class CommonOrgBusinessLineService
    {
		private CommonOrgBusinessLineRepository _repo;
        private string _connectionString;

        public CommonOrgBusinessLineService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new CommonOrgBusinessLineRepository(_connectionString);
        }

        public CommonOrgBusinessLine Read(int ID)
        {
            return _repo.Get(ID);
        }

        public int Create(CommonOrgBusinessLine model)
        {
            _repo.Insert(model);
            return model.ID;
        }

        public void Update(CommonOrgBusinessLine model)
        {
            _repo.Update(model);
        }

        public void Delete(int ID)
        {
            _repo.Delete(m => m.ID == ID);
        }

        public int CreateOrUpdate(CommonOrgBusinessLine model)
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

        public List<CommonOrgBusinessLine> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<CommonOrgBusinessLine> List(Expression<Func<CommonOrgBusinessLine, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<CommonOrgBusinessLine> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
