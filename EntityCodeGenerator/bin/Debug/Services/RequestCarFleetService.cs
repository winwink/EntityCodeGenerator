using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using CSWF.CommonService.Repository;
using CSWF.CommonService.Entity;
using CSWF.Common;


namespace CSWF.CommonService.Services
{

    public class RequestCarFleetService
    {
		private RequestCarFleetRepository _repo;
        private string _connectionString;

        public RequestCarFleetService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new RequestCarFleetRepository(_connectionString);
        }

        public RequestCarFleet Read(long RequestID)
        {
            return _repo.Get(RequestID);
        }

        public long Create(RequestCarFleet model)
        {
            _repo.Insert(model);
            return model.RequestID;
        }

        public void Update(RequestCarFleet model)
        {
            _repo.Update(model);
        }

        public void Delete(long RequestID)
        {
            _repo.Delete(m => m.RequestID == RequestID);
        }

        public long CreateOrUpdate(RequestCarFleet model)
        {
            var get = _repo.Get(model.RequestID);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.RequestID;
        }

        public List<RequestCarFleet> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<RequestCarFleet> List(Expression<Func<RequestCarFleet, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<RequestCarFleet> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
