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
    [ServiceObject("CommonConfigSendMailSvc", "CommonConfigSendMailSvc", "CommonConfigSendMailSvc")]
    public partial class CommonConfigSendMailSvc
    {
		[Property("ConfigID", SoType.Number, "ConfigID", "ConfigID")]
        public int ConfigID { get; set; }
		[Property("Module", SoType.Text, "Module", "Module")]
        public string Module { get; set; }
		[Property("RequestType", SoType.Text, "RequestType", "RequestType")]
        public string RequestType { get; set; }
		[Property("ActivityName", SoType.Text, "ActivityName", "ActivityName")]
        public string ActivityName { get; set; }
		[Property("IsSendMail", SoType.YesNo, "IsSendMail", "IsSendMail")]
        public Nullable<bool> IsSendMail { get; set; }
       
    }

    public partial class CommonConfigSendMailSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public CommonConfigSendMailSvc()
        { }

        public static CommonConfigSendMailSvc GetFromEntity(CommonConfigSendMail entity)
        {
            CommonConfigSendMailSvc svc = new CommonConfigSendMailSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonConfigSendMail entity)
        {
            			this.ConfigID = entity.ConfigID;
			this.Module = entity.Module;
			this.RequestType = entity.RequestType;
			this.ActivityName = entity.ActivityName;
			this.IsSendMail = entity.IsSendMail;
		}

        private CommonConfigSendMail ConvertToEntity()
        {
            var entity = new CommonConfigSendMail();
            			entity.ConfigID = this.ConfigID;
			entity.Module = this.Module;
			entity.RequestType = this.RequestType;
			entity.ActivityName = this.ActivityName;
			entity.IsSendMail = this.IsSendMail;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "ConfigID" },
            new string[] { "ConfigID","Module","RequestType","ActivityName","IsSendMail"})]
        public CommonConfigSendMailSvc Read()
        {
            CommonConfigSendMailService service = new CommonConfigSendMailService(ConnString);
            var model = service.Read(ConfigID);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "ConfigID","Module","RequestType","ActivityName","IsSendMail" },
            new string[] { "ConfigID"})]
        public CommonConfigSendMailSvc Create()
        {
            CommonConfigSendMailService service = new CommonConfigSendMailService(ConnString);
            var entity = ConvertToEntity();
            ConfigID = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "ConfigID","Module","RequestType","ActivityName","IsSendMail" },
            new string[] { })]
        public void Update()
        {
            CommonConfigSendMailService service = new CommonConfigSendMailService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "ConfigID" },
            new string[] { })]
        public void Delete()
        {
            CommonConfigSendMailService service = new CommonConfigSendMailService(ConnString);
            service.Delete(ConfigID);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "ConfigID","Module","RequestType","ActivityName","IsSendMail" },
            new string[] { "ConfigID","Module","RequestType","ActivityName","IsSendMail" })]
        public List<CommonConfigSendMailSvc> List()
        {
            CommonConfigSendMailService service = new CommonConfigSendMailService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}