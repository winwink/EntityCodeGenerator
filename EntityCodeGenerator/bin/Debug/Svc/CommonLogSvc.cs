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
    [ServiceObject("CommonLogSvc", "CommonLogSvc", "CommonLogSvc")]
    public partial class CommonLogSvc
    {
		[Property("ID", SoType.Number, "ID", "ID")]
        public int ID { get; set; }

		[Property("ReqeustID", SoType.Number, "ReqeustID", "ReqeustID")]
        public long ReqeustID { get; set; }

		[Property("Source", SoType.Text, "Source", "Source")]
        public string Source { get; set; }

		[Property("LogLevel", SoType.Text, "LogLevel", "LogLevel")]
        public string LogLevel { get; set; }

		[Property("Message", SoType.Text, "Message", "Message")]
        public string Message { get; set; }

		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public System.DateTime CreateTime { get; set; }

       
    }

    public partial class CommonLogSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

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
			this.ReqeustID = entity.ReqeustID;
			this.Source = entity.Source;
			this.LogLevel = entity.LogLevel;
			this.Message = entity.Message;
			this.CreateTime = entity.CreateTime;
		}

        public CommonLog ConvertToEntity()
        {
            var entity = new CommonLog();
			entity.ID = this.ID;
			entity.ReqeustID = this.ReqeustID;
			entity.Source = this.Source;
			entity.LogLevel = this.LogLevel;
			entity.Message = this.Message;
			entity.CreateTime = this.CreateTime;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "ID" },
            new string[] { "ID","ReqeustID","Source","LogLevel","Message","CreateTime"})]
        public CommonLogSvc Read()
        {
            CommonLogService service = new CommonLogService(ConnString);
            var model = service.Read(ID);
			if (model == null)
            {
                return null;
            }

            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "ID","ReqeustID","Source","LogLevel","Message","CreateTime" },
            new string[] { "ID"})]
        public CommonLogSvc Create()
        {
            CommonLogService service = new CommonLogService(ConnString);
            var entity = ConvertToEntity();
            ID = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "ID","ReqeustID","Source","LogLevel","Message","CreateTime" },
            new string[] { })]
        public void Update()
        {
            CommonLogService service = new CommonLogService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "ID" },
            new string[] { })]
        public void Delete()
        {
            CommonLogService service = new CommonLogService(ConnString);
            service.Delete(ID);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "ID","ReqeustID","Source","LogLevel","Message","CreateTime" },
            new string[] { "ID","ReqeustID","Source","LogLevel","Message","CreateTime" })]
        public List<CommonLogSvc> List()
        {
			var conditions = BuildConditions();
            List<CommonLog> entityList = new List<CommonLog>();
			QueryDescriptor descriptor = new QueryDescriptor() { Conditions = conditions };
            using (RDCN_CSWF_DataContext db = new RDCN_CSWF_DataContext(ConnString))
            {
                entityList = db.CommonLog.Query(descriptor).ToList() ;
            }

            var result = entityList.Select(m => GetFromEntity(m)).ToList();
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
			if (ReqeustID != default(long))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "ReqeustID";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = ReqeustID;
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
