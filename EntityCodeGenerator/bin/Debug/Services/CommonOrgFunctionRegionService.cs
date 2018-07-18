using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class CommonOrgFunctionRegionService
    {
		private CommonOrgFunctionRegionRepository _repo;
        private string _connectionString;

        public CommonOrgFunctionRegionService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new CommonOrgFunctionRegionRepository(_connectionString);
        }

        public CommonOrgFunctionRegion Read(string FunctionRegionCode)
        {
            return _repo.Get(FunctionRegionCode);
        }

        public string Create(CommonOrgFunctionRegion model)
        {
            _repo.Insert(model);
            return model.FunctionRegionCode;
        }

        public void Update(CommonOrgFunctionRegion model)
        {
            _repo.Update(model);
        }

        public void Delete(string FunctionRegionCode)
        {
            _repo.Delete(m => m.FunctionRegionCode == FunctionRegionCode);
        }

        public string CreateOrUpdate(CommonOrgFunctionRegion model)
        {
            var get = _repo.Get(model.FunctionRegionCode);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.FunctionRegionCode;
        }

        public List<CommonOrgFunctionRegion> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<CommonOrgFunctionRegion> List(Expression<Func<CommonOrgFunctionRegion, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<CommonOrgFunctionRegion> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
