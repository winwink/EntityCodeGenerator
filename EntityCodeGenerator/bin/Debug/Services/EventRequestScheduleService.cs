using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class EventRequestScheduleService
    {
		private EventRequestScheduleRepository _repo;
        private string _connectionString;

        public EventRequestScheduleService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new EventRequestScheduleRepository(_connectionString);
        }

        public EventRequestSchedule Read(string Guid)
        {
            return _repo.Get(Guid);
        }

        public string Create(EventRequestSchedule model)
        {
            _repo.Insert(model);
            return model.Guid;
        }

        public void Update(EventRequestSchedule model)
        {
            _repo.Update(model);
        }

        public void Delete(string Guid)
        {
            _repo.Delete(m => m.Guid == Guid);
        }

        public string CreateOrUpdate(EventRequestSchedule model)
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

        public List<EventRequestSchedule> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<EventRequestSchedule> List(Expression<Func<EventRequestSchedule, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<EventRequestSchedule> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
