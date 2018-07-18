using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class EventRequestBudgetService
    {
		private EventRequestBudgetRepository _repo;
        private string _connectionString;

        public EventRequestBudgetService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new EventRequestBudgetRepository(_connectionString);
        }

        public EventRequestBudget Read(string Guid)
        {
            return _repo.Get(Guid);
        }

        public string Create(EventRequestBudget model)
        {
            _repo.Insert(model);
            return model.Guid;
        }

        public void Update(EventRequestBudget model)
        {
            _repo.Update(model);
        }

        public void Delete(string Guid)
        {
            _repo.Delete(m => m.Guid == Guid);
        }

        public string CreateOrUpdate(EventRequestBudget model)
        {
            var get = _repo.Get(model.Guid);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.Guid;
        }

        public List<EventRequestBudget> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<EventRequestBudget> List(Expression<Func<EventRequestBudget, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<EventRequestBudget> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
