using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SourceCode.SmartObjects.Services.ServiceSDK.Attributes;
using SourceCode.SmartObjects.Services.ServiceSDK.Objects;
using SourceCode.SmartObjects.Services.ServiceSDK.Types;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Services;


namespace RDCN.CPT.Data.Svc
{
    [ServiceObject("CommonConfigSvc", "CommonConfigSvc", "CommonConfigSvc")]
    public partial class CommonConfigSvc
    {
		[Property("ConfigKey", SoType.Text, "ConfigKey", "ConfigKey")]
        public string ConfigKey { get; set; }
		[Property("ConfigValue", SoType.Text, "ConfigValue", "ConfigValue")]
        public string ConfigValue { get; set; }
		[Property("IsActive", SoType.YesNo, "IsActive", "IsActive")]
        public Nullable<bool> IsActive { get; set; }
		[Property("Remark", SoType.Text, "Remark", "Remark")]
        public string Remark { get; set; }
		[Property("CreatedBy", SoType.Text, "CreatedBy", "CreatedBy")]
        public string CreatedBy { get; set; }
		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public Nullable<System.DateTime> CreateTime { get; set; }
		[Property("LastUpdateBy", SoType.Text, "LastUpdateBy", "LastUpdateBy")]
        public string LastUpdateBy { get; set; }
		[Property("LastUpdateTime", SoType.DateTime, "LastUpdateTime", "LastUpdateTime")]
        public Nullable<System.DateTime> LastUpdateTime { get; set; }
       
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
            			this.ConfigKey = entity.ConfigKey;
			this.ConfigValue = entity.ConfigValue;
			this.IsActive = entity.IsActive;
			this.Remark = entity.Remark;
			this.CreatedBy = entity.CreatedBy;
			this.CreateTime = entity.CreateTime;
			this.LastUpdateBy = entity.LastUpdateBy;
			this.LastUpdateTime = entity.LastUpdateTime;
		}

        private CommonConfig ConvertToEntity()
        {
            var entity = new CommonConfig();
            			entity.ConfigKey = this.ConfigKey;
			entity.ConfigValue = this.ConfigValue;
			entity.IsActive = this.IsActive;
			entity.Remark = this.Remark;
			entity.CreatedBy = this.CreatedBy;
			entity.CreateTime = this.CreateTime;
			entity.LastUpdateBy = this.LastUpdateBy;
			entity.LastUpdateTime = this.LastUpdateTime;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "ConfigKey" },
            new string[] { "ConfigKey","ConfigValue","IsActive","Remark","CreatedBy","CreateTime","LastUpdateBy","LastUpdateTime"})]
        public CommonConfigSvc Read()
        {
            CommonConfigService service = new CommonConfigService(ConnString);
            var model = service.Read(ConfigKey);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "ConfigKey","ConfigValue","IsActive","Remark","CreatedBy","CreateTime","LastUpdateBy","LastUpdateTime" },
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
            new string[] { "ConfigKey","ConfigValue","IsActive","Remark","CreatedBy","CreateTime","LastUpdateBy","LastUpdateTime" },
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
            new string[] { "ConfigKey","ConfigValue","IsActive","Remark","CreatedBy","CreateTime","LastUpdateBy","LastUpdateTime" },
            new string[] { "ConfigKey","ConfigValue","IsActive","Remark","CreatedBy","CreateTime","LastUpdateBy","LastUpdateTime" })]
        public List<CommonConfigSvc> List()
        {
            CommonConfigService service = new CommonConfigService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}