using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class CommonConfigSendMailService
    {
		private CommonConfigSendMailRepository _repo;
        private string _connectionString;

        public CommonConfigSendMailService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new CommonConfigSendMailRepository(_connectionString);
        }

        public CommonConfigSendMail Read(int ConfigID)
        {
            return _repo.Get(ConfigID);
        }

        public int Create(CommonConfigSendMail model)
        {
            _repo.Insert(model);
            return model.ConfigID;
        }

        public void Update(CommonConfigSendMail model)
        {
            _repo.Update(model);
        }

        public void Delete(int ConfigID)
        {
            _repo.Delete(m => m.ConfigID == ConfigID);
        }

        public int CreateOrUpdate(CommonConfigSendMail model)
        {
            var get = _repo.Get(model.ConfigID);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.ConfigID;
        }

        public List<CommonConfigSendMail> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<CommonConfigSendMail> List(Expression<Func<CommonConfigSendMail, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<CommonConfigSendMail> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
