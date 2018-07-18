using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class VReportsHCOBudgetService
    {
		private VReportsHCOBudgetRepository _repo;
        private string _connectionString;

        public VReportsHCOBudgetService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new VReportsHCOBudgetRepository(_connectionString);
        }

        public VReportsHCOBudget Read(string RequestGuid)
        {
            return _repo.Get(RequestGuid);
        }

        public string Create(VReportsHCOBudget model)
        {
            _repo.Insert(model);
            return model.RequestGuid;
        }

        public void Update(VReportsHCOBudget model)
        {
            _repo.Update(model);
        }

        public void Delete(string RequestGuid)
        {
            _repo.Delete(m => m.RequestGuid == RequestGuid);
        }

        public string CreateOrUpdate(VReportsHCOBudget model)
        {
            var get = _repo.Get(model.RequestGuid);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.RequestGuid;
        }

        public List<VReportsHCOBudget> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<VReportsHCOBudget> List(Expression<Func<VReportsHCOBudget, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<VReportsHCOBudget> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
