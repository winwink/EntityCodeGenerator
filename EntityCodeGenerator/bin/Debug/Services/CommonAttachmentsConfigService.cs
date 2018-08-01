using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using CSWF.CommonService.Repository;
using CSWF.CommonService.Entity;
using CSWF.Common;


namespace CSWF.CommonService.Services
{

    public class CommonAttachmentsConfigService
    {
		private CommonAttachmentsConfigRepository _repo;
        private string _connectionString;

        public CommonAttachmentsConfigService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new CommonAttachmentsConfigRepository(_connectionString);
        }

        public CommonAttachmentsConfig Read(int ID)
        {
            return _repo.Get(ID);
        }

        public int Create(CommonAttachmentsConfig model)
        {
            _repo.Insert(model);
            return model.ID;
        }

        public void Update(CommonAttachmentsConfig model)
        {
            _repo.Update(model);
        }

        public void Delete(int ID)
        {
            _repo.Delete(m => m.ID == ID);
        }

        public int CreateOrUpdate(CommonAttachmentsConfig model)
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

        public List<CommonAttachmentsConfig> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<CommonAttachmentsConfig> List(Expression<Func<CommonAttachmentsConfig, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<CommonAttachmentsConfig> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
