using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class ContractRequestService
    {
		private ContractRequestRepository _repo;
        private string _connectionString;

        public ContractRequestService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new ContractRequestRepository(_connectionString);
        }

        public ContractRequest Read(string ContractGuid)
        {
            return _repo.Get(ContractGuid);
        }

        public string Create(ContractRequest model)
        {
            _repo.Insert(model);
            return model.ContractGuid;
        }

        public void Update(ContractRequest model)
        {
            _repo.Update(model);
        }

        public void Delete(string ContractGuid)
        {
            _repo.Delete(m => m.ContractGuid == ContractGuid);
        }

        public string CreateOrUpdate(ContractRequest model)
        {
            var get = _repo.Get(model.ContractGuid);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.ContractGuid;
        }

        public List<ContractRequest> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<ContractRequest> List(Expression<Func<ContractRequest, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<ContractRequest> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
