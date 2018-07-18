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
    [ServiceObject("CommonInitiatorConfigSvc", "CommonInitiatorConfigSvc", "CommonInitiatorConfigSvc")]
    public partial class CommonInitiatorConfigSvc
    {
		[Property("ID", SoType.Number, "ID", "ID")]
        public int ID { get; set; }
		[Property("RequestType", SoType.Text, "RequestType", "RequestType")]
        public string RequestType { get; set; }
		[Property("RequestSubType", SoType.Text, "RequestSubType", "RequestSubType")]
        public string RequestSubType { get; set; }
		[Property("UserAccount", SoType.Text, "UserAccount", "UserAccount")]
        public string UserAccount { get; set; }
		[Property("IsActive", SoType.YesNo, "IsActive", "IsActive")]
        public Nullable<bool> IsActive { get; set; }
		[Property("CreateDate", SoType.DateTime, "CreateDate", "CreateDate")]
        public Nullable<System.DateTime> CreateDate { get; set; }
		[Property("CreateBy", SoType.Text, "CreateBy", "CreateBy")]
        public string CreateBy { get; set; }
		[Property("UpdateDate", SoType.DateTime, "UpdateDate", "UpdateDate")]
        public Nullable<System.DateTime> UpdateDate { get; set; }
		[Property("UpdateBy", SoType.Text, "UpdateBy", "UpdateBy")]
        public string UpdateBy { get; set; }
       
    }

    public partial class CommonInitiatorConfigSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public CommonInitiatorConfigSvc()
        { }

        public static CommonInitiatorConfigSvc GetFromEntity(CommonInitiatorConfig entity)
        {
            CommonInitiatorConfigSvc svc = new CommonInitiatorConfigSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonInitiatorConfig entity)
        {
            			this.ID = entity.ID;
			this.RequestType = entity.RequestType;
			this.RequestSubType = entity.RequestSubType;
			this.UserAccount = entity.UserAccount;
			this.IsActive = entity.IsActive;
			this.CreateDate = entity.CreateDate;
			this.CreateBy = entity.CreateBy;
			this.UpdateDate = entity.UpdateDate;
			this.UpdateBy = entity.UpdateBy;
		}

        private CommonInitiatorConfig ConvertToEntity()
        {
            var entity = new CommonInitiatorConfig();
            			entity.ID = this.ID;
			entity.RequestType = this.RequestType;
			entity.RequestSubType = this.RequestSubType;
			entity.UserAccount = this.UserAccount;
			entity.IsActive = this.IsActive;
			entity.CreateDate = this.CreateDate;
			entity.CreateBy = this.CreateBy;
			entity.UpdateDate = this.UpdateDate;
			entity.UpdateBy = this.UpdateBy;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "ID" },
            new string[] { "ID","RequestType","RequestSubType","UserAccount","IsActive","CreateDate","CreateBy","UpdateDate","UpdateBy"})]
        public CommonInitiatorConfigSvc Read()
        {
            CommonInitiatorConfigService service = new CommonInitiatorConfigService(ConnString);
            var model = service.Read(ID);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "ID","RequestType","RequestSubType","UserAccount","IsActive","CreateDate","CreateBy","UpdateDate","UpdateBy" },
            new string[] { "ID"})]
        public CommonInitiatorConfigSvc Create()
        {
            CommonInitiatorConfigService service = new CommonInitiatorConfigService(ConnString);
            var entity = ConvertToEntity();
            ID = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "ID","RequestType","RequestSubType","UserAccount","IsActive","CreateDate","CreateBy","UpdateDate","UpdateBy" },
            new string[] { })]
        public void Update()
        {
            CommonInitiatorConfigService service = new CommonInitiatorConfigService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "ID" },
            new string[] { })]
        public void Delete()
        {
            CommonInitiatorConfigService service = new CommonInitiatorConfigService(ConnString);
            service.Delete(ID);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "ID","RequestType","RequestSubType","UserAccount","IsActive","CreateDate","CreateBy","UpdateDate","UpdateBy" },
            new string[] { "ID","RequestType","RequestSubType","UserAccount","IsActive","CreateDate","CreateBy","UpdateDate","UpdateBy" })]
        public List<CommonInitiatorConfigSvc> List()
        {
            CommonInitiatorConfigService service = new CommonInitiatorConfigService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}