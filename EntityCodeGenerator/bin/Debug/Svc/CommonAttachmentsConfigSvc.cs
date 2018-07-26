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
    [ServiceObject("CommonAttachmentsConfigSvc", "CommonAttachmentsConfigSvc", "CommonAttachmentsConfigSvc")]
    public partial class CommonAttachmentsConfigSvc
    {
		[Property("ID", SoType.Number, "ID", "ID")]
        public int ID { get; set; }

		[Property("ProcessCode", SoType.Text, "ProcessCode", "ProcessCode")]
        public string ProcessCode { get; set; }

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
        public int OrderId { get; set; }

		[Property("CreateBy", SoType.Text, "CreateBy", "CreateBy")]
        public string CreateBy { get; set; }

		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public Nullable<System.DateTime> CreateTime { get; set; }

		[Property("UpdateBy", SoType.Text, "UpdateBy", "UpdateBy")]
        public string UpdateBy { get; set; }

		[Property("UpdateTime", SoType.DateTime, "UpdateTime", "UpdateTime")]
        public Nullable<System.DateTime> UpdateTime { get; set; }

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
			if (entity == null) return;

			this.ID = entity.ID;
			this.ProcessCode = entity.ProcessCode;
			this.RequestType = entity.RequestType;
			this.RequestSubType = entity.RequestSubType;
			this.AttachmentType = entity.AttachmentType;
			this.AttachmentTypeName = entity.AttachmentTypeName;
			this.IsMandatory = entity.IsMandatory;
			this.IsAddWatermark = entity.IsAddWatermark;
			this.Condition = entity.Condition;
			this.OrderId = entity.OrderId;
			this.CreateBy = entity.CreateBy;
			this.CreateTime = entity.CreateTime;
			this.UpdateBy = entity.UpdateBy;
			this.UpdateTime = entity.UpdateTime;
			this.IsActive = entity.IsActive;
		}

        public CommonAttachmentsConfig ConvertToEntity()
        {
            var entity = new CommonAttachmentsConfig();
			entity.ID = this.ID;
			entity.ProcessCode = this.ProcessCode;
			entity.RequestType = this.RequestType;
			entity.RequestSubType = this.RequestSubType;
			entity.AttachmentType = this.AttachmentType;
			entity.AttachmentTypeName = this.AttachmentTypeName;
			entity.IsMandatory = this.IsMandatory;
			entity.IsAddWatermark = this.IsAddWatermark;
			entity.Condition = this.Condition;
			entity.OrderId = this.OrderId;
			entity.CreateBy = this.CreateBy;
			entity.CreateTime = this.CreateTime;
			entity.UpdateBy = this.UpdateBy;
			entity.UpdateTime = this.UpdateTime;
			entity.IsActive = this.IsActive;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "ID" },
            new string[] { "ID","ProcessCode","RequestType","RequestSubType","AttachmentType","AttachmentTypeName","IsMandatory","IsAddWatermark","Condition","OrderId","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive"})]
        public CommonAttachmentsConfigSvc Read()
        {
            CommonAttachmentsConfigService service = new CommonAttachmentsConfigService(ConnString);
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
            new string[] { "ID","ProcessCode","RequestType","RequestSubType","AttachmentType","AttachmentTypeName","IsMandatory","IsAddWatermark","Condition","OrderId","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive" },
            new string[] { "ID"})]
        public CommonAttachmentsConfigSvc Create()
        {
            CommonAttachmentsConfigService service = new CommonAttachmentsConfigService(ConnString);
            var entity = ConvertToEntity();
            ID = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "ID","ProcessCode","RequestType","RequestSubType","AttachmentType","AttachmentTypeName","IsMandatory","IsAddWatermark","Condition","OrderId","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive" },
            new string[] { })]
        public void Update()
        {
            CommonAttachmentsConfigService service = new CommonAttachmentsConfigService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "ID" },
            new string[] { })]
        public void Delete()
        {
            CommonAttachmentsConfigService service = new CommonAttachmentsConfigService(ConnString);
            service.Delete(ID);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "ID","ProcessCode","RequestType","RequestSubType","AttachmentType","AttachmentTypeName","IsMandatory","IsAddWatermark","Condition","OrderId","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive" },
            new string[] { "ID","ProcessCode","RequestType","RequestSubType","AttachmentType","AttachmentTypeName","IsMandatory","IsAddWatermark","Condition","OrderId","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive" })]
        public List<CommonAttachmentsConfigSvc> List()
        {
			var conditions = BuildConditions();
            List<CommonAttachmentsConfig> entityList = new List<CommonAttachmentsConfig>();
			QueryDescriptor descriptor = new QueryDescriptor() { Conditions = conditions };
            using (RDCN_CSWF_DataContext db = new RDCN_CSWF_DataContext(ConnString))
            {
                entityList = db.CommonAttachmentsConfig.Query(descriptor).ToList() ;
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
			if (ProcessCode != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "ProcessCode";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = ProcessCode;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (RequestType != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "RequestType";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = RequestType;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (RequestSubType != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "RequestSubType";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = RequestSubType;
				condition.ValueType = typeof(string).GetTypeName();
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
			if (IsMandatory != default(Nullable<bool>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "IsMandatory";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = IsMandatory;
				condition.ValueType = typeof(Nullable<bool>).GetTypeName();
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
			if (Condition != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "Condition";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = Condition;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (OrderId != default(int))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "OrderId";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = OrderId;
				condition.ValueType = typeof(int).GetTypeName();
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
