using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class EventMatchResultService
    {
		private EventMatchResultRepository _repo;
        private string _connectionString;

        public EventMatchResultService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new EventMatchResultRepository(_connectionString);
        }

        public EventMatchResult Read(string MatchResultID)
        {
            return _repo.Get(MatchResultID);
        }

        public string Create(EventMatchResult model)
        {
            _repo.Insert(model);
            return model.MatchResultID;
        }

        public void Update(EventMatchResult model)
        {
            _repo.Update(model);
        }

        public void Delete(string MatchResultID)
        {
            _repo.Delete(m => m.MatchResultID == MatchResultID);
        }

        public string CreateOrUpdate(EventMatchResult model)
        {
            var get = _repo.Get(model.MatchResultID);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.MatchResultID;
        }

        public List<EventMatchResult> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<EventMatchResult> List(Expression<Func<EventMatchResult, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<EventMatchResult> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
