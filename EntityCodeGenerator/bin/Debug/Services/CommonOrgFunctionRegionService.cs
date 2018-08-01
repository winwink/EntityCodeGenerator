using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using CSWF.CommonService.Repository;
using CSWF.CommonService.Entity;
using CSWF.Common;


namespace CSWF.CommonService.Services
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

        public CommonOrgFunctionRegion Read(int ID)
        {
            return _repo.Get(ID);
        }

        public int Create(CommonOrgFunctionRegion model)
        {
            _repo.Insert(model);
            return model.ID;
        }

        public void Update(CommonOrgFunctionRegion model)
        {
            _repo.Update(model);
        }

        public void Delete(int ID)
        {
            _repo.Delete(m => m.ID == ID);
        }

        public int CreateOrUpdate(CommonOrgFunctionRegion model)
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
