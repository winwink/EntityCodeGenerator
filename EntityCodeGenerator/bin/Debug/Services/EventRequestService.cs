using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class EventRequestService
    {
		private EventRequestRepository _repo;
        private string _connectionString;

        public EventRequestService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new EventRequestRepository(_connectionString);
        }

        public EventRequest Read(string RequestGuid)
        {
            return _repo.Get(RequestGuid);
        }

        public string Create(EventRequest model)
        {
            _repo.Insert(model);
            return model.RequestGuid;
        }

        public void Update(EventRequest model)
        {
            _repo.Update(model);
        }

        public void Delete(string RequestGuid)
        {
            _repo.Delete(m => m.RequestGuid == RequestGuid);
        }

        public string CreateOrUpdate(EventRequest model)
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

        public List<EventRequest> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<EventRequest> List(Expression<Func<EventRequest, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<EventRequest> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
