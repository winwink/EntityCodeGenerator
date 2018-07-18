using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class VReportsProcessingTimeService
    {
		private VReportsProcessingTimeRepository _repo;
        private string _connectionString;

        public VReportsProcessingTimeService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new VReportsProcessingTimeRepository(_connectionString);
        }

        public VReportsProcessingTime Read(string RequestTypeName)
        {
            return _repo.Get(RequestTypeName);
        }

        public string Create(VReportsProcessingTime model)
        {
            _repo.Insert(model);
            return model.RequestTypeName;
        }

        public void Update(VReportsProcessingTime model)
        {
            _repo.Update(model);
        }

        public void Delete(string RequestTypeName)
        {
            _repo.Delete(m => m.RequestTypeName == RequestTypeName);
        }

        public string CreateOrUpdate(VReportsProcessingTime model)
        {
            var get = _repo.Get(model.RequestTypeName);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.RequestTypeName;
        }

        public List<VReportsProcessingTime> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<VReportsProcessingTime> List(Expression<Func<VReportsProcessingTime, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<VReportsProcessingTime> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
