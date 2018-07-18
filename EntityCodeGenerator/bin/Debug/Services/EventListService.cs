using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class EventListService
    {
		private EventListRepository _repo;
        private string _connectionString;

        public EventListService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new EventListRepository(_connectionString);
        }

        public EventList Read(string EventID)
        {
            return _repo.Get(EventID);
        }

        public string Create(EventList model)
        {
            _repo.Insert(model);
            return model.EventID;
        }

        public void Update(EventList model)
        {
            _repo.Update(model);
        }

        public void Delete(string EventID)
        {
            _repo.Delete(m => m.EventID == EventID);
        }

        public string CreateOrUpdate(EventList model)
        {
            var get = _repo.Get(model.EventID);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.EventID;
        }

        public List<EventList> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<EventList> List(Expression<Func<EventList, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<EventList> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
