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

		[Property("CreatedBy", SoType.Text, "CreatedBy", "CreatedBy")]
        public string CreatedBy { get; set; }

		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public Nullable<System.DateTime> CreateTime { get; set; }

		[Property("UpdateBy", SoType.Text, "UpdateBy", "UpdateBy")]
        public string UpdateBy { get; set; }

		[Property("UpdateTime", SoType.DateTime, "UpdateTime", "UpdateTime")]
        public Nullable<System.DateTime> UpdateTime { get; set; }

		[Property("IsActive", SoType.YesNo, "IsActive", "IsActive")]
        public Nullable<bool> IsActive { get; set; }

       
    }

    public partial class CommonConfigSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

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
			this.CreatedBy = entity.CreatedBy;
			this.CreateTime = entity.CreateTime;
			this.UpdateBy = entity.UpdateBy;
			this.UpdateTime = entity.UpdateTime;
			this.IsActive = entity.IsActive;
		}

        public CommonConfig ConvertToEntity()
        {
            var entity = new CommonConfig();
			entity.ConfigKey = this.ConfigKey;
			entity.ProcessCode = this.ProcessCode;
			entity.ConfigValue = this.ConfigValue;
			entity.Remark = this.Remark;
			entity.CreatedBy = this.CreatedBy;
			entity.CreateTime = this.CreateTime;
			entity.UpdateBy = this.UpdateBy;
			entity.UpdateTime = this.UpdateTime;
			entity.IsActive = this.IsActive;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "ConfigKey" },
            new string[] { "ConfigKey","ProcessCode","ConfigValue","Remark","CreatedBy","CreateTime","UpdateBy","UpdateTime","IsActive"})]
        public CommonConfigSvc Read()
        {
            CommonConfigService service = new CommonConfigService(ConnString);
            var model = service.Read(ConfigKey);
			if (model == null)
            {
                return null;
            }

            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "ConfigKey","ProcessCode","ConfigValue","Remark","CreatedBy","CreateTime","UpdateBy","UpdateTime","IsActive" },
            new string[] { "ConfigKey"})]
        public CommonConfigSvc Create()
        {
            CommonConfigService service = new CommonConfigService(ConnString);
            var entity = ConvertToEntity();
            ConfigKey = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "ConfigKey","ProcessCode","ConfigValue","Remark","CreatedBy","CreateTime","UpdateBy","UpdateTime","IsActive" },
            new string[] { })]
        public void Update()
        {
            CommonConfigService service = new CommonConfigService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "ConfigKey" },
            new string[] { })]
        public void Delete()
        {
            CommonConfigService service = new CommonConfigService(ConnString);
            service.Delete(ConfigKey);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "ConfigKey","ProcessCode","ConfigValue","Remark","CreatedBy","CreateTime","UpdateBy","UpdateTime","IsActive" },
            new string[] { "ConfigKey","ProcessCode","ConfigValue","Remark","CreatedBy","CreateTime","UpdateBy","UpdateTime","IsActive" })]
        public List<CommonConfigSvc> List()
        {
			var conditions = BuildConditions();
            List<CommonConfig> entityList = new List<CommonConfig>();
			QueryDescriptor descriptor = new QueryDescriptor() { Conditions = conditions };
            using (RDCN_CSWF_DataContext db = new RDCN_CSWF_DataContext(ConnString))
            {
                entityList = db.CommonConfig.Query(descriptor).ToList() ;
            }

            var result = entityList.Select(m => GetFromEntity(m)).ToList();
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
			if (CreatedBy != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "CreatedBy";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = CreatedBy;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (CreateTime != default(Nullable<System.DateTime>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "CreateTime";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = CreateTime;
				condition.ValueType = typeof(Nullable<System.DateTime>).GetTypeName();
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
			if (UpdateTime != default(Nullable<System.DateTime>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "UpdateTime";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = UpdateTime;
				condition.ValueType = typeof(Nullable<System.DateTime>).GetTypeName();
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
