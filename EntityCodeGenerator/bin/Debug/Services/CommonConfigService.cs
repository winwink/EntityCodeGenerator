using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class CommonConfigService
    {
		private CommonConfigRepository _repo;
        private string _connectionString;

        public CommonConfigService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new CommonConfigRepository(_connectionString);
        }

        public CommonConfig Read(string ConfigKey)
        {
            return _repo.Get(ConfigKey);
        }

        public string Create(CommonConfig model)
        {
            _repo.Insert(model);
            return model.ConfigKey;
        }

        public void Update(CommonConfig model)
        {
            _repo.Update(model);
        }

        public void Delete(string ConfigKey)
        {
            _repo.Delete(m => m.ConfigKey == ConfigKey);
        }

        public string CreateOrUpdate(CommonConfig model)
        {
            var get = _repo.Get(model.ConfigKey);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.ConfigKey;
        }

        public List<CommonConfig> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<CommonConfig> List(Expression<Func<CommonConfig, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<CommonConfig> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
