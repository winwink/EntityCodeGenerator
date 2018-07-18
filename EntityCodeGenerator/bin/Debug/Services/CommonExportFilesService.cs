using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using RDCN.CPT.Data.Repository;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Core;


namespace RDCN.CPT.Data.Services
{

    public class CommonExportFilesService
    {
		private CommonExportFilesRepository _repo;
        private string _connectionString;

        public CommonExportFilesService(string connectionString)
        {
            _connectionString = connectionString;
            _repo = new CommonExportFilesRepository(_connectionString);
        }

        public CommonExportFiles Read(int ID)
        {
            return _repo.Get(ID);
        }

        public int Create(CommonExportFiles model)
        {
            _repo.Insert(model);
            return model.ID;
        }

        public void Update(CommonExportFiles model)
        {
            _repo.Update(model);
        }

        public void Delete(int ID)
        {
            _repo.Delete(m => m.ID == ID);
        }

        public int CreateOrUpdate(CommonExportFiles model)
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

        public List<CommonExportFiles> List()
        {
            return _repo.GetAll().ToList();
        }

        public List<CommonExportFiles> List(Expression<Func<CommonExportFiles, bool>> predicate)
        {
            return _repo.Get(predicate).ToList();
        }
        
        public List<CommonExportFiles> List(PagingSet paging)
        {
            return _repo.GetPagedList(paging);
        }
    }
}
