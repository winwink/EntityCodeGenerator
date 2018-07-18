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
    [ServiceObject("CommonAttachmentsConfigSvc", "CommonAttachmentsConfigSvc", "CommonAttachmentsConfigSvc")]
    public partial class CommonAttachmentsConfigSvc
    {
		[Property("AttachmentConfigGuid", SoType.Text, "AttachmentConfigGuid", "AttachmentConfigGuid")]
        public string AttachmentConfigGuid { get; set; }
		[Property("RequestType", SoType.Text, "RequestType", "RequestType")]
        public string RequestType { get; set; }
		[Property("RequestSubType", SoType.Text, "RequestSubType", "RequestSubType")]
        public string RequestSubType { get; set; }
		[Property("AttachmentType", SoType.Text, "AttachmentType", "AttachmentType")]
        public string AttachmentType { get; set; }
		[Property("AttachmentTypeName", SoType.Text, "AttachmentTypeName", "AttachmentTypeName")]
        public string AttachmentTypeName { get; set; }
		[Property("IsMandatory", SoType.YesNo, "IsMandatory", "IsMandatory")]
        public Nullable<bool> IsMandatory { get; set; }
		[Property("IsAddWatermark", SoType.YesNo, "IsAddWatermark", "IsAddWatermark")]
        public Nullable<bool> IsAddWatermark { get; set; }
		[Property("Condition", SoType.Text, "Condition", "Condition")]
        public string Condition { get; set; }
		[Property("OrderId", SoType.Number, "OrderId", "OrderId")]
        public Nullable<int> OrderId { get; set; }
		[Property("IsActive", SoType.YesNo, "IsActive", "IsActive")]
        public Nullable<bool> IsActive { get; set; }
       
    }

    public partial class CommonAttachmentsConfigSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public CommonAttachmentsConfigSvc()
        { }

        public static CommonAttachmentsConfigSvc GetFromEntity(CommonAttachmentsConfig entity)
        {
            CommonAttachmentsConfigSvc svc = new CommonAttachmentsConfigSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonAttachmentsConfig entity)
        {
            			this.AttachmentConfigGuid = entity.AttachmentConfigGuid;
			this.RequestType = entity.RequestType;
			this.RequestSubType = entity.RequestSubType;
			this.AttachmentType = entity.AttachmentType;
			this.AttachmentTypeName = entity.AttachmentTypeName;
			this.IsMandatory = entity.IsMandatory;
			this.IsAddWatermark = entity.IsAddWatermark;
			this.Condition = entity.Condition;
			this.OrderId = entity.OrderId;
			this.IsActive = entity.IsActive;
		}

        private CommonAttachmentsConfig ConvertToEntity()
        {
            var entity = new CommonAttachmentsConfig();
            			entity.AttachmentConfigGuid = this.AttachmentConfigGuid;
			entity.RequestType = this.RequestType;
			entity.RequestSubType = this.RequestSubType;
			entity.AttachmentType = this.AttachmentType;
			entity.AttachmentTypeName = this.AttachmentTypeName;
			entity.IsMandatory = this.IsMandatory;
			entity.IsAddWatermark = this.IsAddWatermark;
			entity.Condition = this.Condition;
			entity.OrderId = this.OrderId;
			entity.IsActive = this.IsActive;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "AttachmentConfigGuid" },
            new string[] { "AttachmentConfigGuid","RequestType","RequestSubType","AttachmentType","AttachmentTypeName","IsMandatory","IsAddWatermark","Condition","OrderId","IsActive"})]
        public CommonAttachmentsConfigSvc Read()
        {
            CommonAttachmentsConfigService service = new CommonAttachmentsConfigService(ConnString);
            var model = service.Read(AttachmentConfigGuid);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "AttachmentConfigGuid","RequestType","RequestSubType","AttachmentType","AttachmentTypeName","IsMandatory","IsAddWatermark","Condition","OrderId","IsActive" },
            new string[] { "AttachmentConfigGuid"})]
        public CommonAttachmentsConfigSvc Create()
        {
            CommonAttachmentsConfigService service = new CommonAttachmentsConfigService(ConnString);
            var entity = ConvertToEntity();
            AttachmentConfigGuid = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "AttachmentConfigGuid","RequestType","RequestSubType","AttachmentType","AttachmentTypeName","IsMandatory","IsAddWatermark","Condition","OrderId","IsActive" },
            new string[] { })]
        public void Update()
        {
            CommonAttachmentsConfigService service = new CommonAttachmentsConfigService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "AttachmentConfigGuid" },
            new string[] { })]
        public void Delete()
        {
            CommonAttachmentsConfigService service = new CommonAttachmentsConfigService(ConnString);
            service.Delete(AttachmentConfigGuid);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "AttachmentConfigGuid","RequestType","RequestSubType","AttachmentType","AttachmentTypeName","IsMandatory","IsAddWatermark","Condition","OrderId","IsActive" },
            new string[] { "AttachmentConfigGuid","RequestType","RequestSubType","AttachmentType","AttachmentTypeName","IsMandatory","IsAddWatermark","Condition","OrderId","IsActive" })]
        public List<CommonAttachmentsConfigSvc> List()
        {
            CommonAttachmentsConfigService service = new CommonAttachmentsConfigService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}