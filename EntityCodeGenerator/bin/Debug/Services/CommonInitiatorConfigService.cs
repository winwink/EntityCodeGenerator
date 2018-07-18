using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class CommonInitiatorConfigService
    {
		private CommonInitiatorConfigRepository _repo;
        private string _connectionString;

        public CommonInitiatorConfigService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new CommonInitiatorConfigRepository(_connectionString);
        }

        public CommonInitiatorConfig Read(int ID)
        {
            return _repo.Get(ID);
        }

        public int Create(CommonInitiatorConfig model)
        {
            _repo.Insert(model);
            return model.ID;
        }

        public void Update(CommonInitiatorConfig model)
        {
            _repo.Update(model);
        }

        public void Delete(int ID)
        {
            _repo.Delete(m => m.ID == ID);
        }

        public int CreateOrUpdate(CommonInitiatorConfig model)
        {
            var get = _repo.Get(model.ID);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.ID;
        }

        public List<CommonInitiatorConfig> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<CommonInitiatorConfig> List(Expression<Func<CommonInitiatorConfig, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<CommonInitiatorConfig> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
