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

		[Property("CreateBy", SoType.Text, "CreateBy", "CreateBy")]
        public string CreateBy { get; set; }

		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public System.DateTime CreateTime { get; set; }

		[Property("UpdateBy", SoType.Text, "UpdateBy", "UpdateBy")]
        public string UpdateBy { get; set; }

		[Property("UpdateTime", SoType.DateTime, "UpdateTime", "UpdateTime")]
        public System.DateTime UpdateTime { get; set; }

    }

    public partial class CommonOrgBusinessAreaSvc : SvcBase
    {
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
			this.CreateBy = entity.CreateBy;
			this.CreateTime = entity.CreateTime;
			this.UpdateBy = entity.UpdateBy;
			this.UpdateTime = entity.UpdateTime;
		}

        public CommonOrgBusinessArea ToEntity()
        {
            var entity = new CommonOrgBusinessArea();
			entity.BACode = this.BACode;
			entity.BANameCN = this.BANameCN;
			entity.OrderId = this.OrderId;
			entity.IsActive = this.IsActive;
			entity.CreateBy = this.CreateBy;
			entity.CreateTime = this.CreateTime;
			entity.UpdateBy = this.UpdateBy;
			entity.UpdateTime = this.UpdateTime;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "BACode" },
            new string[] { "BACode","BANameCN","OrderId","IsActive","CreateBy","CreateTime","UpdateBy","UpdateTime"})]
        public CommonOrgBusinessAreaSvc Read()
        {
			try
			{
				CommonOrgBusinessAreaService service = new CommonOrgBusinessAreaService(ConnString);
				var model = service.Read(BACode);
				if (model == null)
				{
					return null;
				}

				ParseFromEntity(model);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("BACode", BACode);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonOrgBusinessAreaSvc.Read", SvcLogLevel, variables);
                throw ex;
			}
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "BACode","BANameCN","OrderId","IsActive","CreateBy","CreateTime","UpdateBy","UpdateTime" },
            new string[] { "BACode"})]
        public CommonOrgBusinessAreaSvc Create()
        {
			try
			{
				CommonOrgBusinessAreaService service = new CommonOrgBusinessAreaService(ConnString);
				var entity = ToEntity();
                entity.CreateBy = CurrentUser;
                entity.CreateTime = DateTime.Now;
                entity.UpdateBy = CurrentUser;
                entity.UpdateTime = DateTime.Now;
				
                entity.CreateBy = CurrentUser;
                entity.CreateTime = DateTime.Now;
				BACode = service.Create(entity);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("BACode", BACode);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonOrgBusinessAreaSvc.Create", SvcLogLevel, variables);
                throw ex;
			}
            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "BACode","BANameCN","OrderId","IsActive","CreateBy","CreateTime","UpdateBy","UpdateTime" },
            new string[] { })]
        public void Update()
        {
			try
			{
				CommonOrgBusinessAreaService service = new CommonOrgBusinessAreaService(ConnString);
				var entity = ToEntity();
                entity.UpdateBy = CurrentUser;
                entity.UpdateTime = DateTime.Now;
				service.Update(entity);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("BACode", BACode);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonOrgBusinessAreaSvc.Update", SvcLogLevel, variables);
                throw ex;
			}
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "BACode" },
            new string[] { })]
        public void Delete()
        {
			try
			{
				CommonOrgBusinessAreaService service = new CommonOrgBusinessAreaService(ConnString);
				service.Delete(BACode);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("BACode", BACode);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonOrgBusinessAreaSvc.Delete", SvcLogLevel, variables);
                throw ex;
			}
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "BACode","BANameCN","OrderId","IsActive","CreateBy","CreateTime","UpdateBy","UpdateTime" },
            new string[] { "BACode","BANameCN","OrderId","IsActive","CreateBy","CreateTime","UpdateBy","UpdateTime" })]
        public List<CommonOrgBusinessAreaSvc> List()
        {
			List<CommonOrgBusinessArea> entityList = new List<CommonOrgBusinessArea>();
			List<CommonOrgBusinessAreaSvc> result = new List<CommonOrgBusinessAreaSvc>();
			try
			{
				var conditions = BuildConditions();
				QueryDescriptor descriptor = new QueryDescriptor() { Conditions = conditions };
				using (RDCN_CSWF_DataContext db = new RDCN_CSWF_DataContext(ConnString))
				{
					entityList = db.CommonOrgBusinessArea.Query(descriptor).ToList() ;
				}

				result = entityList.Select(m => GetFromEntity(m)).ToList();
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("BACode", BACode);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonOrgBusinessAreaSvc.List", SvcLogLevel, variables);
                throw ex;
			}
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
			if (UpdateTime != default(System.DateTime))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "UpdateTime";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = UpdateTime;
				condition.ValueType = typeof(System.DateTime).GetTypeName();
				list.Add(condition);
			}
            return list;
        }
    }
}
