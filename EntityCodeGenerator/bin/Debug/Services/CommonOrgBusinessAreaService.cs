using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class CommonOrgBusinessAreaService
    {
		private CommonOrgBusinessAreaRepository _repo;
        private string _connectionString;

        public CommonOrgBusinessAreaService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new CommonOrgBusinessAreaRepository(_connectionString);
        }

        public CommonOrgBusinessArea Read(string BACode)
        {
            return _repo.Get(BACode);
        }

        public string Create(CommonOrgBusinessArea model)
        {
            _repo.Insert(model);
            return model.BACode;
        }

        public void Update(CommonOrgBusinessArea model)
        {
            _repo.Update(model);
        }

        public void Delete(string BACode)
        {
            _repo.Delete(m => m.BACode == BACode);
        }

        public string CreateOrUpdate(CommonOrgBusinessArea model)
        {
            var get = _repo.Get(model.BACode);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.BACode;
        }

        public List<CommonOrgBusinessArea> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<CommonOrgBusinessArea> List(Expression<Func<CommonOrgBusinessArea, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<CommonOrgBusinessArea> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
