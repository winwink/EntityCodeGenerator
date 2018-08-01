using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SourceCode.SmartObjects.Services.ServiceSDK.Attributes;
using SourceCode.SmartObjects.Services.ServiceSDK.Objects;
using SourceCode.SmartObjects.Services.ServiceSDK.Types;
using CSWF.CommonService.Entity;
using CSWF.CommonService.Services;
using CSWF.Common;

namespace CSWF.CommonService.CommonSvc
{
    [ServiceObject("CommonLogSvc", "CommonLogSvc", "CommonLogSvc")]
    public partial class CommonLogSvc
    {
		[Property("ID", SoType.Number, "ID", "ID")]
        public int ID { get; set; }

		[Property("RequestID", SoType.Number, "RequestID", "RequestID")]
        public long RequestID { get; set; }

		[Property("Source", SoType.Text, "Source", "Source")]
        public string Source { get; set; }

		[Property("LogLevel", SoType.Text, "LogLevel", "LogLevel")]
        public string LogLevel { get; set; }

		[Property("Message", SoType.Text, "Message", "Message")]
        public string Message { get; set; }

		[Property("CreateBy", SoType.Text, "CreateBy", "CreateBy")]
        public string CreateBy { get; set; }

		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public System.DateTime CreateTime { get; set; }

    }

    public partial class CommonLogSvc : SvcBase
    {
        public CommonLogSvc()
        { }

        public static CommonLogSvc GetFromEntity(CommonLog entity)
        {
            CommonLogSvc svc = new CommonLogSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonLog entity)
        {
			if (entity == null) return;

			this.ID = entity.ID;
			this.RequestID = entity.RequestID;
			this.Source = entity.Source;
			this.LogLevel = entity.LogLevel;
			this.Message = entity.Message;
			this.CreateBy = entity.CreateBy;
			this.CreateTime = entity.CreateTime;
		}

        public CommonLog ToEntity()
        {
            var entity = new CommonLog();
			entity.ID = this.ID;
			entity.RequestID = this.RequestID;
			entity.Source = this.Source;
			entity.LogLevel = this.LogLevel;
			entity.Message = this.Message;
			entity.CreateBy = this.CreateBy;
			entity.CreateTime = this.CreateTime;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "System", "ID" },
            new string[] { "ID","RequestID","Source","LogLevel","Message","CreateBy","CreateTime"})]
        public CommonLogSvc Read()
        {
			try
			{
				CommonLogService service = new CommonLogService(ConnString);
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
                Logger.Write(System, RequestID, CurrentUser, "CommonLogSvc.Read", SvcLogLevel, variables);
                throw ex;
			}
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "System", "ID","RequestID","Source","LogLevel","Message","CreateBy","CreateTime" },
            new string[] { "ID"})]
        public CommonLogSvc Create()
        {
			try
			{
				CommonLogService service = new CommonLogService(ConnString);
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
                Logger.Write(System, RequestID, CurrentUser, "CommonLogSvc.Create", SvcLogLevel, variables);
                throw ex;
			}
            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "System", "ID","RequestID","Source","LogLevel","Message","CreateBy","CreateTime" },
            new string[] { })]
        public void Update()
        {
			try
			{
				CommonLogService service = new CommonLogService(ConnString);
				var entity = ToEntity();
				service.Update(entity);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(System, RequestID, CurrentUser, "CommonLogSvc.Update", SvcLogLevel, variables);
                throw ex;
			}
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "System", "ID" },
            new string[] { })]
        public void Delete()
        {
			try
			{
				CommonLogService service = new CommonLogService(ConnString);
				service.Delete(ID);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(System, RequestID, CurrentUser, "CommonLogSvc.Delete", SvcLogLevel, variables);
                throw ex;
			}
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "System", "ID","RequestID","Source","LogLevel","Message","CreateBy","CreateTime" },
            new string[] { "ID","RequestID","Source","LogLevel","Message","CreateBy","CreateTime" })]
        public List<CommonLogSvc> List()
        {
			List<CommonLog> entityList = new List<CommonLog>();
			List<CommonLogSvc> result = new List<CommonLogSvc>();
			try
			{
				var conditions = BuildConditions();
				QueryDescriptor descriptor = new QueryDescriptor() { Conditions = conditions };
				using (RDCN_CSWF_DataContext db = new RDCN_CSWF_DataContext(ConnString))
				{
					entityList = db.CommonLog.Query(descriptor).ToList() ;
				}

				result = entityList.Select(m => GetFromEntity(m)).ToList();
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(System, RequestID, CurrentUser, "CommonLogSvc.List", SvcLogLevel, variables);
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
			if (RequestID != default(long))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "RequestID";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = RequestID;
				condition.ValueType = typeof(long).GetTypeName();
				list.Add(condition);
			}
			if (Source != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "Source";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = Source;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (LogLevel != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "LogLevel";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = LogLevel;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (Message != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "Message";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = Message;
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
