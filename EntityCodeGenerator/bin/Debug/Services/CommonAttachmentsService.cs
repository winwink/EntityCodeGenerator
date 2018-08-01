using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using CSWF.CommonService.Repository;
using CSWF.CommonService.Entity;
using CSWF.Common;


namespace CSWF.CommonService.Services
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

        public CommonAttachments Read(int ID)
        {
            return _repo.Get(ID);
        }

        public int Create(CommonAttachments model)
        {
            _repo.Insert(model);
            return model.ID;
        }

        public void Update(CommonAttachments model)
        {
            _repo.Update(model);
        }

        public void Delete(int ID)
        {
            _repo.Delete(m => m.ID == ID);
        }

        public int CreateOrUpdate(CommonAttachments model)
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
