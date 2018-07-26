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
    [ServiceObject("CommonOrgBusinessLineSvc", "CommonOrgBusinessLineSvc", "CommonOrgBusinessLineSvc")]
    public partial class CommonOrgBusinessLineSvc
    {
		[Property("ID", SoType.Number, "ID", "ID")]
        public int ID { get; set; }

		[Property("BACode", SoType.Text, "BACode", "BACode")]
        public string BACode { get; set; }

		[Property("BLCode", SoType.Text, "BLCode", "BLCode")]
        public string BLCode { get; set; }

		[Property("BLNameCN", SoType.Text, "BLNameCN", "BLNameCN")]
        public string BLNameCN { get; set; }

		[Property("OrderId", SoType.Number, "OrderId", "OrderId")]
        public int OrderId { get; set; }

		[Property("IsActive", SoType.YesNo, "IsActive", "IsActive")]
        public Nullable<bool> IsActive { get; set; }

       
    }

    public partial class CommonOrgBusinessLineSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public CommonOrgBusinessLineSvc()
        { }

        public static CommonOrgBusinessLineSvc GetFromEntity(CommonOrgBusinessLine entity)
        {
            CommonOrgBusinessLineSvc svc = new CommonOrgBusinessLineSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonOrgBusinessLine entity)
        {
			if (entity == null) return;

			this.ID = entity.ID;
			this.BACode = entity.BACode;
			this.BLCode = entity.BLCode;
			this.BLNameCN = entity.BLNameCN;
			this.OrderId = entity.OrderId;
			this.IsActive = entity.IsActive;
		}

        public CommonOrgBusinessLine ConvertToEntity()
        {
            var entity = new CommonOrgBusinessLine();
			entity.ID = this.ID;
			entity.BACode = this.BACode;
			entity.BLCode = this.BLCode;
			entity.BLNameCN = this.BLNameCN;
			entity.OrderId = this.OrderId;
			entity.IsActive = this.IsActive;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "ID" },
            new string[] { "ID","BACode","BLCode","BLNameCN","OrderId","IsActive"})]
        public CommonOrgBusinessLineSvc Read()
        {
            CommonOrgBusinessLineService service = new CommonOrgBusinessLineService(ConnString);
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
            new string[] { "ID","BACode","BLCode","BLNameCN","OrderId","IsActive" },
            new string[] { "ID"})]
        public CommonOrgBusinessLineSvc Create()
        {
            CommonOrgBusinessLineService service = new CommonOrgBusinessLineService(ConnString);
            var entity = ConvertToEntity();
            ID = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "ID","BACode","BLCode","BLNameCN","OrderId","IsActive" },
            new string[] { })]
        public void Update()
        {
            CommonOrgBusinessLineService service = new CommonOrgBusinessLineService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "ID" },
            new string[] { })]
        public void Delete()
        {
            CommonOrgBusinessLineService service = new CommonOrgBusinessLineService(ConnString);
            service.Delete(ID);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "ID","BACode","BLCode","BLNameCN","OrderId","IsActive" },
            new string[] { "ID","BACode","BLCode","BLNameCN","OrderId","IsActive" })]
        public List<CommonOrgBusinessLineSvc> List()
        {
			var conditions = BuildConditions();
            List<CommonOrgBusinessLine> entityList = new List<CommonOrgBusinessLine>();
			QueryDescriptor descriptor = new QueryDescriptor() { Conditions = conditions };
            using (RDCN_CSWF_DataContext db = new RDCN_CSWF_DataContext(ConnString))
            {
                entityList = db.CommonOrgBusinessLine.Query(descriptor).ToList() ;
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
			if (BACode != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "BACode";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = BACode;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (BLCode != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "BLCode";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = BLCode;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (BLNameCN != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "BLNameCN";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = BLNameCN;
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
