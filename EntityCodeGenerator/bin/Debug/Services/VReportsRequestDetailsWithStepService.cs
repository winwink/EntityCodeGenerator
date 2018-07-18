using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class VReportsRequestDetailsWithStepService
    {
		private VReportsRequestDetailsWithStepRepository _repo;
        private string _connectionString;

        public VReportsRequestDetailsWithStepService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new VReportsRequestDetailsWithStepRepository(_connectionString);
        }

        public VReportsRequestDetailsWithStep Read(string RequestType)
        {
            return _repo.Get(RequestType);
        }

        public string Create(VReportsRequestDetailsWithStep model)
        {
            _repo.Insert(model);
            return model.RequestType;
        }

        public void Update(VReportsRequestDetailsWithStep model)
        {
            _repo.Update(model);
        }

        public void Delete(string RequestType)
        {
            _repo.Delete(m => m.RequestType == RequestType);
        }

        public string CreateOrUpdate(VReportsRequestDetailsWithStep model)
        {
            var get = _repo.Get(model.RequestType);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.RequestType;
        }

        public List<VReportsRequestDetailsWithStep> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<VReportsRequestDetailsWithStep> List(Expression<Func<VReportsRequestDetailsWithStep, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<VReportsRequestDetailsWithStep> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
