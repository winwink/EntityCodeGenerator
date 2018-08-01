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
    [ServiceObject("CommonConfigSvc", "CommonConfigSvc", "CommonConfigSvc")]
    public partial class CommonConfigSvc
    {
		[Property("ConfigKey", SoType.Text, "ConfigKey", "ConfigKey")]
        public string ConfigKey { get; set; }

		[Property("ProcessCode", SoType.Text, "ProcessCode", "ProcessCode")]
        public string ProcessCode { get; set; }

		[Property("ConfigValue", SoType.Text, "ConfigValue", "ConfigValue")]
        public string ConfigValue { get; set; }

		[Property("Remark", SoType.Text, "Remark", "Remark")]
        public string Remark { get; set; }

		[Property("CreateBy", SoType.Text, "CreateBy", "CreateBy")]
        public string CreateBy { get; set; }

		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public System.DateTime CreateTime { get; set; }

		[Property("UpdateBy", SoType.Text, "UpdateBy", "UpdateBy")]
        public string UpdateBy { get; set; }

		[Property("UpdateTime", SoType.DateTime, "UpdateTime", "UpdateTime")]
        public System.DateTime UpdateTime { get; set; }

		[Property("IsActive", SoType.YesNo, "IsActive", "IsActive")]
        public Nullable<bool> IsActive { get; set; }

    }

    public partial class CommonConfigSvc : SvcBase
    {
        public CommonConfigSvc()
        { }

        public static CommonConfigSvc GetFromEntity(CommonConfig entity)
        {
            CommonConfigSvc svc = new CommonConfigSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonConfig entity)
        {
			if (entity == null) return;

			this.ConfigKey = entity.ConfigKey;
			this.ProcessCode = entity.ProcessCode;
			this.ConfigValue = entity.ConfigValue;
			this.Remark = entity.Remark;
			this.CreateBy = entity.CreateBy;
			this.CreateTime = entity.CreateTime;
			this.UpdateBy = entity.UpdateBy;
			this.UpdateTime = entity.UpdateTime;
			this.IsActive = entity.IsActive;
		}

        public CommonConfig ToEntity()
        {
            var entity = new CommonConfig();
			entity.ConfigKey = this.ConfigKey;
			entity.ProcessCode = this.ProcessCode;
			entity.ConfigValue = this.ConfigValue;
			entity.Remark = this.Remark;
			entity.CreateBy = this.CreateBy;
			entity.CreateTime = this.CreateTime;
			entity.UpdateBy = this.UpdateBy;
			entity.UpdateTime = this.UpdateTime;
			entity.IsActive = this.IsActive;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "System", "ConfigKey" },
            new string[] { "ConfigKey","ProcessCode","ConfigValue","Remark","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive"})]
        public CommonConfigSvc Read()
        {
			try
			{
				CommonConfigService service = new CommonConfigService(ConnString);
				var model = service.Read(ConfigKey);
				if (model == null)
				{
					return null;
				}

				ParseFromEntity(model);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ConfigKey", ConfigKey);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(System, RequestID, CurrentUser, "CommonConfigSvc.Read", SvcLogLevel, variables);
                throw ex;
			}
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "System", "ConfigKey","ProcessCode","ConfigValue","Remark","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive" },
            new string[] { "ConfigKey"})]
        public CommonConfigSvc Create()
        {
			try
			{
				CommonConfigService service = new CommonConfigService(ConnString);
				var entity = ToEntity();
                entity.CreateBy = CurrentUser;
                entity.CreateTime = DateTime.Now;
                entity.UpdateBy = CurrentUser;
                entity.UpdateTime = DateTime.Now;
				
                entity.CreateBy = CurrentUser;
                entity.CreateTime = DateTime.Now;
				ConfigKey = service.Create(entity);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ConfigKey", ConfigKey);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(System, RequestID, CurrentUser, "CommonConfigSvc.Create", SvcLogLevel, variables);
                throw ex;
			}
            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "System", "ConfigKey","ProcessCode","ConfigValue","Remark","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive" },
            new string[] { })]
        public void Update()
        {
			try
			{
				CommonConfigService service = new CommonConfigService(ConnString);
				var entity = ToEntity();
                entity.UpdateBy = CurrentUser;
                entity.UpdateTime = DateTime.Now;
				service.Update(entity);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ConfigKey", ConfigKey);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(System, RequestID, CurrentUser, "CommonConfigSvc.Update", SvcLogLevel, variables);
                throw ex;
			}
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "System", "ConfigKey" },
            new string[] { })]
        public void Delete()
        {
			try
			{
				CommonConfigService service = new CommonConfigService(ConnString);
				service.Delete(ConfigKey);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ConfigKey", ConfigKey);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(System, RequestID, CurrentUser, "CommonConfigSvc.Delete", SvcLogLevel, variables);
                throw ex;
			}
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "System", "ConfigKey","ProcessCode","ConfigValue","Remark","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive" },
            new string[] { "ConfigKey","ProcessCode","ConfigValue","Remark","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive" })]
        public List<CommonConfigSvc> List()
        {
			List<CommonConfig> entityList = new List<CommonConfig>();
			List<CommonConfigSvc> result = new List<CommonConfigSvc>();
			try
			{
				var conditions = BuildConditions();
				QueryDescriptor descriptor = new QueryDescriptor() { Conditions = conditions };
				using (RDCN_CSWF_DataContext db = new RDCN_CSWF_DataContext(ConnString))
				{
					entityList = db.CommonConfig.Query(descriptor).ToList() ;
				}

				result = entityList.Select(m => GetFromEntity(m)).ToList();
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ConfigKey", ConfigKey);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(System, RequestID, CurrentUser, "CommonConfigSvc.List", SvcLogLevel, variables);
                throw ex;
			}
            return result;
        }

		private List<QueryCondition> BuildConditions()
        {
            List<QueryCondition> list = new List<QueryCondition>();
			if (ConfigKey != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "ConfigKey";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = ConfigKey;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (ProcessCode != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "ProcessCode";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = ProcessCode;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (ConfigValue != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "ConfigValue";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = ConfigValue;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (Remark != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "Remark";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = Remark;
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
			if (UpdateBy != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "UpdateBy";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = UpdateBy;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (UpdateTime != default(System.DateTime))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "UpdateTime";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = UpdateTime;
				condition.ValueType = typeof(System.DateTime).GetTypeName();
				list.Add(condition);
			}
			if (IsActive != default(Nullable<bool>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "IsActive";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = IsActive;
				condition.ValueType = typeof(Nullable<bool>).GetTypeName();
				list.Add(condition);
			}
            return list;
        }
    }
}
