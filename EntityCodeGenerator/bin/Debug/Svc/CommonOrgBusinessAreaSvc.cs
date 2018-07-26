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
    [ServiceObject("CommonOrgBusinessAreaSvc", "CommonOrgBusinessAreaSvc", "CommonOrgBusinessAreaSvc")]
    public partial class CommonOrgBusinessAreaSvc
    {
		[Property("BACode", SoType.Text, "BACode", "BACode")]
        public string BACode { get; set; }

		[Property("BANameCN", SoType.Text, "BANameCN", "BANameCN")]
        public string BANameCN { get; set; }

		[Property("OrderId", SoType.Number, "OrderId", "OrderId")]
        public int OrderId { get; set; }

		[Property("IsActive", SoType.YesNo, "IsActive", "IsActive")]
        public Nullable<bool> IsActive { get; set; }

       
    }

    public partial class CommonOrgBusinessAreaSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public CommonOrgBusinessAreaSvc()
        { }

        public static CommonOrgBusinessAreaSvc GetFromEntity(CommonOrgBusinessArea entity)
        {
            CommonOrgBusinessAreaSvc svc = new CommonOrgBusinessAreaSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonOrgBusinessArea entity)
        {
			if (entity == null) return;

			this.BACode = entity.BACode;
			this.BANameCN = entity.BANameCN;
			this.OrderId = entity.OrderId;
			this.IsActive = entity.IsActive;
		}

        public CommonOrgBusinessArea ConvertToEntity()
        {
            var entity = new CommonOrgBusinessArea();
			entity.BACode = this.BACode;
			entity.BANameCN = this.BANameCN;
			entity.OrderId = this.OrderId;
			entity.IsActive = this.IsActive;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "BACode" },
            new string[] { "BACode","BANameCN","OrderId","IsActive"})]
        public CommonOrgBusinessAreaSvc Read()
        {
            CommonOrgBusinessAreaService service = new CommonOrgBusinessAreaService(ConnString);
            var model = service.Read(BACode);
			if (model == null)
            {
                return null;
            }

            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "BACode","BANameCN","OrderId","IsActive" },
            new string[] { "BACode"})]
        public CommonOrgBusinessAreaSvc Create()
        {
            CommonOrgBusinessAreaService service = new CommonOrgBusinessAreaService(ConnString);
            var entity = ConvertToEntity();
            BACode = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "BACode","BANameCN","OrderId","IsActive" },
            new string[] { })]
        public void Update()
        {
            CommonOrgBusinessAreaService service = new CommonOrgBusinessAreaService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "BACode" },
            new string[] { })]
        public void Delete()
        {
            CommonOrgBusinessAreaService service = new CommonOrgBusinessAreaService(ConnString);
            service.Delete(BACode);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "BACode","BANameCN","OrderId","IsActive" },
            new string[] { "BACode","BANameCN","OrderId","IsActive" })]
        public List<CommonOrgBusinessAreaSvc> List()
        {
			var conditions = BuildConditions();
            List<CommonOrgBusinessArea> entityList = new List<CommonOrgBusinessArea>();
			QueryDescriptor descriptor = new QueryDescriptor() { Conditions = conditions };
            using (RDCN_CSWF_DataContext db = new RDCN_CSWF_DataContext(ConnString))
            {
                entityList = db.CommonOrgBusinessArea.Query(descriptor).ToList() ;
            }

            var result = entityList.Select(m => GetFromEntity(m)).ToList();
            return result;
        }

		private List<QueryCondition> BuildConditions()
        {
            List<QueryCondition> list = new List<QueryCondition>();
			if (BACode != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "BACode";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = BACode;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (BANameCN != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "BANameCN";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = BANameCN;
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
