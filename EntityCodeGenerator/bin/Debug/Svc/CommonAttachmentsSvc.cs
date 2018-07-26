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
    [ServiceObject("CommonAttachmentsSvc", "CommonAttachmentsSvc", "CommonAttachmentsSvc")]
    public partial class CommonAttachmentsSvc
    {
		[Property("ID", SoType.Number, "ID", "ID")]
        public int ID { get; set; }

		[Property("RequestID", SoType.Number, "RequestID", "RequestID")]
        public long RequestID { get; set; }

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

		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public System.DateTime CreateTime { get; set; }

		[Property("UpdateBy", SoType.Text, "UpdateBy", "UpdateBy")]
        public string UpdateBy { get; set; }

		[Property("UpdateTime", SoType.DateTime, "UpdateTime", "UpdateTime")]
        public Nullable<System.DateTime> UpdateTime { get; set; }

       
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
			if (entity == null) return;

			this.ID = entity.ID;
			this.RequestID = entity.RequestID;
			this.AttachmentType = entity.AttachmentType;
			this.AttachmentTypeName = entity.AttachmentTypeName;
			this.Title = entity.Title;
			this.FileName = entity.FileName;
			this.FileUrl = entity.FileUrl;
			this.IsAddWatermark = entity.IsAddWatermark;
			this.CreateBy = entity.CreateBy;
			this.CreateTime = entity.CreateTime;
			this.UpdateBy = entity.UpdateBy;
			this.UpdateTime = entity.UpdateTime;
		}

        public CommonAttachments ConvertToEntity()
        {
            var entity = new CommonAttachments();
			entity.ID = this.ID;
			entity.RequestID = this.RequestID;
			entity.AttachmentType = this.AttachmentType;
			entity.AttachmentTypeName = this.AttachmentTypeName;
			entity.Title = this.Title;
			entity.FileName = this.FileName;
			entity.FileUrl = this.FileUrl;
			entity.IsAddWatermark = this.IsAddWatermark;
			entity.CreateBy = this.CreateBy;
			entity.CreateTime = this.CreateTime;
			entity.UpdateBy = this.UpdateBy;
			entity.UpdateTime = this.UpdateTime;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "ID" },
            new string[] { "ID","RequestID","AttachmentType","AttachmentTypeName","Title","FileName","FileUrl","IsAddWatermark","CreateBy","CreateTime","UpdateBy","UpdateTime"})]
        public CommonAttachmentsSvc Read()
        {
            CommonAttachmentsService service = new CommonAttachmentsService(ConnString);
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
            new string[] { "ID","RequestID","AttachmentType","AttachmentTypeName","Title","FileName","FileUrl","IsAddWatermark","CreateBy","CreateTime","UpdateBy","UpdateTime" },
            new string[] { "ID"})]
        public CommonAttachmentsSvc Create()
        {
            CommonAttachmentsService service = new CommonAttachmentsService(ConnString);
            var entity = ConvertToEntity();
            ID = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "ID","RequestID","AttachmentType","AttachmentTypeName","Title","FileName","FileUrl","IsAddWatermark","CreateBy","CreateTime","UpdateBy","UpdateTime" },
            new string[] { })]
        public void Update()
        {
            CommonAttachmentsService service = new CommonAttachmentsService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "ID" },
            new string[] { })]
        public void Delete()
        {
            CommonAttachmentsService service = new CommonAttachmentsService(ConnString);
            service.Delete(ID);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "ID","RequestID","AttachmentType","AttachmentTypeName","Title","FileName","FileUrl","IsAddWatermark","CreateBy","CreateTime","UpdateBy","UpdateTime" },
            new string[] { "ID","RequestID","AttachmentType","AttachmentTypeName","Title","FileName","FileUrl","IsAddWatermark","CreateBy","CreateTime","UpdateBy","UpdateTime" })]
        public List<CommonAttachmentsSvc> List()
        {
			var conditions = BuildConditions();
            List<CommonAttachments> entityList = new List<CommonAttachments>();
			QueryDescriptor descriptor = new QueryDescriptor() { Conditions = conditions };
            using (RDCN_CSWF_DataContext db = new RDCN_CSWF_DataContext(ConnString))
            {
                entityList = db.CommonAttachments.Query(descriptor).ToList() ;
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
			if (RequestID != default(long))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "RequestID";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = RequestID;
				condition.ValueType = typeof(long).GetTypeName();
				list.Add(condition);
			}
			if (AttachmentType != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "AttachmentType";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = AttachmentType;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (AttachmentTypeName != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "AttachmentTypeName";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = AttachmentTypeName;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (Title != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "Title";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = Title;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (FileName != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "FileName";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = FileName;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (FileUrl != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "FileUrl";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = FileUrl;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (IsAddWatermark != default(Nullable<bool>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "IsAddWatermark";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = IsAddWatermark;
				condition.ValueType = typeof(Nullable<bool>).GetTypeName();
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
			if (UpdateTime != default(Nullable<System.DateTime>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "UpdateTime";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = UpdateTime;
				condition.ValueType = typeof(Nullable<System.DateTime>).GetTypeName();
				list.Add(condition);
			}
            return list;
        }
    }
}
