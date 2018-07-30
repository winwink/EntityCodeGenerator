using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SourceCode.SmartObjects.Services.ServiceSDK.Attributes;
using SourceCode.SmartObjects.Services.ServiceSDK.Objects;
using SourceCode.SmartObjects.Services.ServiceSDK.Types;
using Common.CSWF.Entity;
using Common.CSWF.Services;
using Common.CSWF.Core;

namespace Common.CSWF.CommonSvc
{
    [ServiceObject("CommonExportFilesSvc", "CommonExportFilesSvc", "CommonExportFilesSvc")]
    public partial class CommonExportFilesSvc
    {
		[Property("ID", SoType.Number, "ID", "ID")]
        public int ID { get; set; }

		[Property("File", SoType.Text, "File", "File")]
        public string File { get; set; }

		[Property("CreateBy", SoType.Text, "CreateBy", "CreateBy")]
        public string CreateBy { get; set; }

		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public System.DateTime CreateTime { get; set; }

    }

    public partial class CommonExportFilesSvc : SvcBase
    {
        public CommonExportFilesSvc()
        { }

        public static CommonExportFilesSvc GetFromEntity(CommonExportFiles entity)
        {
            CommonExportFilesSvc svc = new CommonExportFilesSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonExportFiles entity)
        {
			if (entity == null) return;

			this.ID = entity.ID;
			this.File = entity.File;
			this.CreateBy = entity.CreateBy;
			this.CreateTime = entity.CreateTime;
		}

        public CommonExportFiles ToEntity()
        {
            var entity = new CommonExportFiles();
			entity.ID = this.ID;
			entity.File = this.File;
			entity.CreateBy = this.CreateBy;
			entity.CreateTime = this.CreateTime;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "ID" },
            new string[] { "ID","File","CreateBy","CreateTime"})]
        public CommonExportFilesSvc Read()
        {
			try
			{
				CommonExportFilesService service = new CommonExportFilesService(ConnString);
				var model = service.Read(ID);
				if (model == null)
				{
					return null;
				}

				ParseFromEntity(model);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonExportFilesSvc.Read", SvcLogLevel, variables);
                throw ex;
			}
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "ID","File","CreateBy","CreateTime" },
            new string[] { "ID"})]
        public CommonExportFilesSvc Create()
        {
			try
			{
				CommonExportFilesService service = new CommonExportFilesService(ConnString);
				var entity = ToEntity();
				
                entity.CreateBy = CurrentUser;
                entity.CreateTime = DateTime.Now;
				ID = service.Create(entity);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonExportFilesSvc.Create", SvcLogLevel, variables);
                throw ex;
			}
            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "ID","File","CreateBy","CreateTime" },
            new string[] { })]
        public void Update()
        {
			try
			{
				CommonExportFilesService service = new CommonExportFilesService(ConnString);
				var entity = ToEntity();
				service.Update(entity);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonExportFilesSvc.Update", SvcLogLevel, variables);
                throw ex;
			}
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "ID" },
            new string[] { })]
        public void Delete()
        {
			try
			{
				CommonExportFilesService service = new CommonExportFilesService(ConnString);
				service.Delete(ID);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonExportFilesSvc.Delete", SvcLogLevel, variables);
                throw ex;
			}
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "ID","File","CreateBy","CreateTime" },
            new string[] { "ID","File","CreateBy","CreateTime" })]
        public List<CommonExportFilesSvc> List()
        {
			List<CommonExportFiles> entityList = new List<CommonExportFiles>();
			List<CommonExportFilesSvc> result = new List<CommonExportFilesSvc>();
			try
			{
				var conditions = BuildConditions();
				QueryDescriptor descriptor = new QueryDescriptor() { Conditions = conditions };
				using (RDCN_CSWF_DataContext db = new RDCN_CSWF_DataContext(ConnString))
				{
					entityList = db.CommonExportFiles.Query(descriptor).ToList() ;
				}

				result = entityList.Select(m => GetFromEntity(m)).ToList();
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonExportFilesSvc.List", SvcLogLevel, variables);
                throw ex;
			}
            return result;
        }

		private List<QueryCondition> BuildConditions()
        {
            List<QueryCondition> list = new List<QueryCondition>();
			if (ID != default(int))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "ID";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = ID;
				condition.ValueType = typeof(int).GetTypeName();
				list.Add(condition);
			}
			if (File != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "File";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = File;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (CreateBy != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "CreateBy";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = CreateBy;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (CreateTime != default(System.DateTime))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "CreateTime";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = CreateTime;
				condition.ValueType = typeof(System.DateTime).GetTypeName();
				list.Add(condition);
			}
            return list;
        }
    }
}
