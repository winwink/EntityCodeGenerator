using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class VReportsWorkLogService
    {
		private VReportsWorkLogRepository _repo;
        private string _connectionString;

        public VReportsWorkLogService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new VReportsWorkLogRepository(_connectionString);
        }

        public VReportsWorkLog Read(string IsHCO)
        {
            return _repo.Get(IsHCO);
        }

        public string Create(VReportsWorkLog model)
        {
            _repo.Insert(model);
            return model.IsHCO;
        }

        public void Update(VReportsWorkLog model)
        {
            _repo.Update(model);
        }

        public void Delete(string IsHCO)
        {
            _repo.Delete(m => m.IsHCO == IsHCO);
        }

        public string CreateOrUpdate(VReportsWorkLog model)
        {
            var get = _repo.Get(model.IsHCO);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.IsHCO;
        }

        public List<VReportsWorkLog> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<VReportsWorkLog> List(Expression<Func<VReportsWorkLog, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<VReportsWorkLog> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
