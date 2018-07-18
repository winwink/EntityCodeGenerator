using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
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

        public CommonAttachmentsConfig Read(string AttachmentConfigGuid)
        {
            return _repo.Get(AttachmentConfigGuid);
        }

        public string Create(CommonAttachmentsConfig model)
        {
            _repo.Insert(model);
            return model.AttachmentConfigGuid;
        }

        public void Update(CommonAttachmentsConfig model)
        {
            _repo.Update(model);
        }

        public void Delete(string AttachmentConfigGuid)
        {
            _repo.Delete(m => m.AttachmentConfigGuid == AttachmentConfigGuid);
        }

        public string CreateOrUpdate(CommonAttachmentsConfig model)
        {
            var get = _repo.Get(model.AttachmentConfigGuid);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.AttachmentConfigGuid;
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
