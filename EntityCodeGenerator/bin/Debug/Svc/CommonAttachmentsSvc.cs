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
    [ServiceObject("CommonAttachmentsSvc", "CommonAttachmentsSvc", "CommonAttachmentsSvc")]
    public partial class CommonAttachmentsSvc
    {
		[Property("AttachmentID", SoType.Number, "AttachmentID", "AttachmentID")]
        public int AttachmentID { get; set; }
		[Property("RequestGuid", SoType.Text, "RequestGuid", "RequestGuid")]
        public string RequestGuid { get; set; }
		[Property("AttachmentType", SoType.Text, "AttachmentType", "AttachmentType")]
        public string AttachmentType { get; set; }
		[Property("AttachmentTypeName", SoType.Text, "AttachmentTypeName", "AttachmentTypeName")]
        public string AttachmentTypeName { get; set; }
		[Property("Title", SoType.Text, "Title", "Title")]
        public string Title { get; set; }
		[Property("FileName", SoType.Text, "FileName", "FileName")]
        public string FileName { get; set; }
		[Property("FileUrl", SoType.Text, "FileUrl", "FileUrl")]
        public string FileUrl { get; set; }
		[Property("IsAddWatermark", SoType.YesNo, "IsAddWatermark", "IsAddWatermark")]
        public Nullable<bool> IsAddWatermark { get; set; }
		[Property("CreateBy", SoType.Text, "CreateBy", "CreateBy")]
        public string CreateBy { get; set; }
		[Property("CreatedTime", SoType.DateTime, "CreatedTime", "CreatedTime")]
        public Nullable<System.DateTime> CreatedTime { get; set; }
		[Property("LastUpdateBy", SoType.Text, "LastUpdateBy", "LastUpdateBy")]
        public string LastUpdateBy { get; set; }
		[Property("LastUpdateTime", SoType.DateTime, "LastUpdateTime", "LastUpdateTime")]
        public Nullable<System.DateTime> LastUpdateTime { get; set; }
       
    }

    public partial class CommonAttachmentsSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public CommonAttachmentsSvc()
        { }

        public static CommonAttachmentsSvc GetFromEntity(CommonAttachments entity)
        {
            CommonAttachmentsSvc svc = new CommonAttachmentsSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonAttachments entity)
        {
            			this.AttachmentID = entity.AttachmentID;
			this.RequestGuid = entity.RequestGuid;
			this.AttachmentType = entity.AttachmentType;
			this.AttachmentTypeName = entity.AttachmentTypeName;
			this.Title = entity.Title;
			this.FileName = entity.FileName;
			this.FileUrl = entity.FileUrl;
			this.IsAddWatermark = entity.IsAddWatermark;
			this.CreateBy = entity.CreateBy;
			this.CreatedTime = entity.CreatedTime;
			this.LastUpdateBy = entity.LastUpdateBy;
			this.LastUpdateTime = entity.LastUpdateTime;
		}

        private CommonAttachments ConvertToEntity()
        {
            var entity = new CommonAttachments();
            			entity.AttachmentID = this.AttachmentID;
			entity.RequestGuid = this.RequestGuid;
			entity.AttachmentType = this.AttachmentType;
			entity.AttachmentTypeName = this.AttachmentTypeName;
			entity.Title = this.Title;
			entity.FileName = this.FileName;
			entity.FileUrl = this.FileUrl;
			entity.IsAddWatermark = this.IsAddWatermark;
			entity.CreateBy = this.CreateBy;
			entity.CreatedTime = this.CreatedTime;
			entity.LastUpdateBy = this.LastUpdateBy;
			entity.LastUpdateTime = this.LastUpdateTime;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "AttachmentID" },
            new string[] { "AttachmentID","RequestGuid","AttachmentType","AttachmentTypeName","Title","FileName","FileUrl","IsAddWatermark","CreateBy","CreatedTime","LastUpdateBy","LastUpdateTime"})]
        public CommonAttachmentsSvc Read()
        {
            CommonAttachmentsService service = new CommonAttachmentsService(ConnString);
            var model = service.Read(AttachmentID);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "AttachmentID","RequestGuid","AttachmentType","AttachmentTypeName","Title","FileName","FileUrl","IsAddWatermark","CreateBy","CreatedTime","LastUpdateBy","LastUpdateTime" },
            new string[] { "AttachmentID"})]
        public CommonAttachmentsSvc Create()
        {
            CommonAttachmentsService service = new CommonAttachmentsService(ConnString);
            var entity = ConvertToEntity();
            AttachmentID = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "AttachmentID","RequestGuid","AttachmentType","AttachmentTypeName","Title","FileName","FileUrl","IsAddWatermark","CreateBy","CreatedTime","LastUpdateBy","LastUpdateTime" },
            new string[] { })]
        public void Update()
        {
            CommonAttachmentsService service = new CommonAttachmentsService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "AttachmentID" },
            new string[] { })]
        public void Delete()
        {
            CommonAttachmentsService service = new CommonAttachmentsService(ConnString);
            service.Delete(AttachmentID);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "AttachmentID","RequestGuid","AttachmentType","AttachmentTypeName","Title","FileName","FileUrl","IsAddWatermark","CreateBy","CreatedTime","LastUpdateBy","LastUpdateTime" },
            new string[] { "AttachmentID","RequestGuid","AttachmentType","AttachmentTypeName","Title","FileName","FileUrl","IsAddWatermark","CreateBy","CreatedTime","LastUpdateBy","LastUpdateTime" })]
        public List<CommonAttachmentsSvc> List()
        {
            CommonAttachmentsService service = new CommonAttachmentsService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}