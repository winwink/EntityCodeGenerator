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
    [ServiceObject("CommonOrgFunctionRegionSvc", "CommonOrgFunctionRegionSvc", "CommonOrgFunctionRegionSvc")]
    public partial class CommonOrgFunctionRegionSvc
    {
		[Property("ID", SoType.Number, "ID", "ID")]
        public int ID { get; set; }

		[Property("BACode", SoType.Text, "BACode", "BACode")]
        public string BACode { get; set; }

		[Property("BLCode", SoType.Text, "BLCode", "BLCode")]
        public string BLCode { get; set; }

		[Property("Function", SoType.Text, "Function", "Function")]
        public string Function { get; set; }

		[Property("Region", SoType.Text, "Region", "Region")]
        public string Region { get; set; }

		[Property("OrderId", SoType.Number, "OrderId", "OrderId")]
        public int OrderId { get; set; }

		[Property("CreateBy", SoType.Text, "CreateBy", "CreateBy")]
        public string CreateBy { get; set; }

		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public System.DateTime CreateTime { get; set; }

		[Property("UpdateBy", SoType.Text, "UpdateBy", "UpdateBy")]
        public string UpdateBy { get; set; }

		[Property("UpdateTime", SoType.DateTime, "UpdateTime", "UpdateTime")]
        public System.DateTime UpdateTime { get; set; }

		[Property("IsActive", SoType.YesNo, "IsActive", "IsActive")]
        public Nullable<bool> IsActive { get; set; }

    }

    public partial class CommonOrgFunctionRegionSvc : SvcBase
    {
        public CommonOrgFunctionRegionSvc()
        { }

        public static CommonOrgFunctionRegionSvc GetFromEntity(CommonOrgFunctionRegion entity)
        {
            CommonOrgFunctionRegionSvc svc = new CommonOrgFunctionRegionSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonOrgFunctionRegion entity)
        {
			if (entity == null) return;

			this.ID = entity.ID;
			this.BACode = entity.BACode;
			this.BLCode = entity.BLCode;
			this.Function = entity.Function;
			this.Region = entity.Region;
			this.OrderId = entity.OrderId;
			this.CreateBy = entity.CreateBy;
			this.CreateTime = entity.CreateTime;
			this.UpdateBy = entity.UpdateBy;
			this.UpdateTime = entity.UpdateTime;
			this.IsActive = entity.IsActive;
		}

        public CommonOrgFunctionRegion ToEntity()
        {
            var entity = new CommonOrgFunctionRegion();
			entity.ID = this.ID;
			entity.BACode = this.BACode;
			entity.BLCode = this.BLCode;
			entity.Function = this.Function;
			entity.Region = this.Region;
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
            new string[] { "ID","BACode","BLCode","Function","Region","OrderId","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive"})]
        public CommonOrgFunctionRegionSvc Read()
        {
			try
			{
				CommonOrgFunctionRegionService service = new CommonOrgFunctionRegionService(ConnString);
				var model = service.Read(ID);
				if (model == null)
				{
					return null;
				}

				ParseFromEntity(model);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonOrgFunctionRegionSvc.Read", SvcLogLevel, variables);
                throw ex;
			}
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "ID","BACode","BLCode","Function","Region","OrderId","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive" },
            new string[] { "ID"})]
        public CommonOrgFunctionRegionSvc Create()
        {
			try
			{
				CommonOrgFunctionRegionService service = new CommonOrgFunctionRegionService(ConnString);
				var entity = ToEntity();
                entity.CreateBy = CurrentUser;
                entity.CreateTime = DateTime.Now;
                entity.UpdateBy = CurrentUser;
                entity.UpdateTime = DateTime.Now;
				
                entity.CreateBy = CurrentUser;
                entity.CreateTime = DateTime.Now;
				ID = service.Create(entity);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonOrgFunctionRegionSvc.Create", SvcLogLevel, variables);
                throw ex;
			}
            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "ID","BACode","BLCode","Function","Region","OrderId","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive" },
            new string[] { })]
        public void Update()
        {
			try
			{
				CommonOrgFunctionRegionService service = new CommonOrgFunctionRegionService(ConnString);
				var entity = ToEntity();
                entity.UpdateBy = CurrentUser;
                entity.UpdateTime = DateTime.Now;
				service.Update(entity);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonOrgFunctionRegionSvc.Update", SvcLogLevel, variables);
                throw ex;
			}
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "ID" },
            new string[] { })]
        public void Delete()
        {
			try
			{
				CommonOrgFunctionRegionService service = new CommonOrgFunctionRegionService(ConnString);
				service.Delete(ID);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonOrgFunctionRegionSvc.Delete", SvcLogLevel, variables);
                throw ex;
			}
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "ID","BACode","BLCode","Function","Region","OrderId","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive" },
            new string[] { "ID","BACode","BLCode","Function","Region","OrderId","CreateBy","CreateTime","UpdateBy","UpdateTime","IsActive" })]
        public List<CommonOrgFunctionRegionSvc> List()
        {
			List<CommonOrgFunctionRegion> entityList = new List<CommonOrgFunctionRegion>();
			List<CommonOrgFunctionRegionSvc> result = new List<CommonOrgFunctionRegionSvc>();
			try
			{
				var conditions = BuildConditions();
				QueryDescriptor descriptor = new QueryDescriptor() { Conditions = conditions };
				using (RDCN_CSWF_DataContext db = new RDCN_CSWF_DataContext(ConnString))
				{
					entityList = db.CommonOrgFunctionRegion.Query(descriptor).ToList() ;
				}

				result = entityList.Select(m => GetFromEntity(m)).ToList();
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonOrgFunctionRegionSvc.List", SvcLogLevel, variables);
                throw ex;
			}
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
			if (Function != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "Function";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = Function;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (Region != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "Region";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = Region;
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
