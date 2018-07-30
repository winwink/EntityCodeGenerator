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

		[Property("CreateBy", SoType.Text, "CreateBy", "CreateBy")]
        public string CreateBy { get; set; }

		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public System.DateTime CreateTime { get; set; }

		[Property("UpdateBy", SoType.Text, "UpdateBy", "UpdateBy")]
        public string UpdateBy { get; set; }

		[Property("UpdateTime", SoType.DateTime, "UpdateTime", "UpdateTime")]
        public System.DateTime UpdateTime { get; set; }

    }

    public partial class CommonOrgBusinessLineSvc : SvcBase
    {
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
			this.CreateBy = entity.CreateBy;
			this.CreateTime = entity.CreateTime;
			this.UpdateBy = entity.UpdateBy;
			this.UpdateTime = entity.UpdateTime;
		}

        public CommonOrgBusinessLine ToEntity()
        {
            var entity = new CommonOrgBusinessLine();
			entity.ID = this.ID;
			entity.BACode = this.BACode;
			entity.BLCode = this.BLCode;
			entity.BLNameCN = this.BLNameCN;
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
            new string[] { "ID" },
            new string[] { "ID","BACode","BLCode","BLNameCN","OrderId","IsActive","CreateBy","CreateTime","UpdateBy","UpdateTime"})]
        public CommonOrgBusinessLineSvc Read()
        {
			try
			{
				CommonOrgBusinessLineService service = new CommonOrgBusinessLineService(ConnString);
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
                Logger.Write(RequestID, CurrentUser, "CommonOrgBusinessLineSvc.Read", SvcLogLevel, variables);
                throw ex;
			}
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "ID","BACode","BLCode","BLNameCN","OrderId","IsActive","CreateBy","CreateTime","UpdateBy","UpdateTime" },
            new string[] { "ID"})]
        public CommonOrgBusinessLineSvc Create()
        {
			try
			{
				CommonOrgBusinessLineService service = new CommonOrgBusinessLineService(ConnString);
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
                Logger.Write(RequestID, CurrentUser, "CommonOrgBusinessLineSvc.Create", SvcLogLevel, variables);
                throw ex;
			}
            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "ID","BACode","BLCode","BLNameCN","OrderId","IsActive","CreateBy","CreateTime","UpdateBy","UpdateTime" },
            new string[] { })]
        public void Update()
        {
			try
			{
				CommonOrgBusinessLineService service = new CommonOrgBusinessLineService(ConnString);
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
                Logger.Write(RequestID, CurrentUser, "CommonOrgBusinessLineSvc.Update", SvcLogLevel, variables);
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
				CommonOrgBusinessLineService service = new CommonOrgBusinessLineService(ConnString);
				service.Delete(ID);
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonOrgBusinessLineSvc.Delete", SvcLogLevel, variables);
                throw ex;
			}
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "ID","BACode","BLCode","BLNameCN","OrderId","IsActive","CreateBy","CreateTime","UpdateBy","UpdateTime" },
            new string[] { "ID","BACode","BLCode","BLNameCN","OrderId","IsActive","CreateBy","CreateTime","UpdateBy","UpdateTime" })]
        public List<CommonOrgBusinessLineSvc> List()
        {
			List<CommonOrgBusinessLine> entityList = new List<CommonOrgBusinessLine>();
			List<CommonOrgBusinessLineSvc> result = new List<CommonOrgBusinessLineSvc>();
			try
			{
				var conditions = BuildConditions();
				QueryDescriptor descriptor = new QueryDescriptor() { Conditions = conditions };
				using (RDCN_CSWF_DataContext db = new RDCN_CSWF_DataContext(ConnString))
				{
					entityList = db.CommonOrgBusinessLine.Query(descriptor).ToList() ;
				}

				result = entityList.Select(m => GetFromEntity(m)).ToList();
			}
			catch(Exception ex)
			{
				Dictionary<string, object> variables = new Dictionary<string, object>() { };
                variables.Add("ID", ID);
                variables.Add("Msg", ex.Message);
				Logger.ServiceConfiguration = ServiceConfiguration;
                Logger.Write(RequestID, CurrentUser, "CommonOrgBusinessLineSvc.List", SvcLogLevel, variables);
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
