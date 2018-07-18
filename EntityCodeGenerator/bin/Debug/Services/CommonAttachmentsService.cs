using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class CommonAttachmentsService
    {
		private CommonAttachmentsRepository _repo;
        private string _connectionString;

        public CommonAttachmentsService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new CommonAttachmentsRepository(_connectionString);
        }

        public CommonAttachments Read(int AttachmentID)
        {
            return _repo.Get(AttachmentID);
        }

        public int Create(CommonAttachments model)
        {
            _repo.Insert(model);
            return model.AttachmentID;
        }

        public void Update(CommonAttachments model)
        {
            _repo.Update(model);
        }

        public void Delete(int AttachmentID)
        {
            _repo.Delete(m => m.AttachmentID == AttachmentID);
        }

        public int CreateOrUpdate(CommonAttachments model)
        {
            var get = _repo.Get(model.AttachmentID);
            if (get == null)
            {
                _repo.Insert(model);
            }
            else
            {
                _repo.Update(model);
            }
            return model.AttachmentID;
        }

        public List<CommonAttachments> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<CommonAttachments> List(Expression<Func<CommonAttachments, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<CommonAttachments> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
