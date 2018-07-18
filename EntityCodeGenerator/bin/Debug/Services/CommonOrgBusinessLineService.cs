using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
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

        public CommonOrgBusinessLine Read(string BLCode)
        {
            return _repo.Get(BLCode);
        }

        public string Create(CommonOrgBusinessLine model)
        {
            _repo.Insert(model);
            return model.BLCode;
        }

        public void Update(CommonOrgBusinessLine model)
        {
            _repo.Update(model);
        }

        public void Delete(string BLCode)
        {
            _repo.Delete(m => m.BLCode == BLCode);
        }

        public string CreateOrUpdate(CommonOrgBusinessLine model)
        {
            var get = _repo.Get(model.BLCode);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.BLCode;
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
