using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class EventSelfCheckResultService
    {
		private EventSelfCheckResultRepository _repo;
        private string _connectionString;

        public EventSelfCheckResultService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new EventSelfCheckResultRepository(_connectionString);
        }

        public EventSelfCheckResult Read(int SelfCheckID)
        {
            return _repo.Get(SelfCheckID);
        }

        public int Create(EventSelfCheckResult model)
        {
            _repo.Insert(model);
            return model.SelfCheckID;
        }

        public void Update(EventSelfCheckResult model)
        {
            _repo.Update(model);
        }

        public void Delete(int SelfCheckID)
        {
            _repo.Delete(m => m.SelfCheckID == SelfCheckID);
        }

        public int CreateOrUpdate(EventSelfCheckResult model)
        {
            var get = _repo.Get(model.SelfCheckID);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.SelfCheckID;
        }

        public List<EventSelfCheckResult> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<EventSelfCheckResult> List(Expression<Func<EventSelfCheckResult, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<EventSelfCheckResult> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
