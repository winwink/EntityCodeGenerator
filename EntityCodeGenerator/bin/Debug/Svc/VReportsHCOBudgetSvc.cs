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
    [ServiceObject("VReportsHCOBudgetSvc", "VReportsHCOBudgetSvc", "VReportsHCOBudgetSvc")]
    public partial class VReportsHCOBudgetSvc
    {
		[Property("RequestGuid", SoType.Text, "RequestGuid", "RequestGuid")]
        public string RequestGuid { get; set; }
		[Property("RequestNo", SoType.Text, "RequestNo", "RequestNo")]
        public string RequestNo { get; set; }
		[Property("BA", SoType.Text, "BA", "BA")]
        public string BA { get; set; }
		[Property("BL", SoType.Text, "BL", "BL")]
        public string BL { get; set; }
		[Property("Function", SoType.Text, "Function", "Function")]
        public string Function { get; set; }
		[Property("Region", SoType.Text, "Region", "Region")]
        public string Region { get; set; }
		[Property("InstitutionCode", SoType.Text, "InstitutionCode", "InstitutionCode")]
        public string InstitutionCode { get; set; }
		[Property("InstitutionName", SoType.Text, "InstitutionName", "InstitutionName")]
        public string InstitutionName { get; set; }
		[Property("BudgetAmount", SoType.Decimal, "BudgetAmount", "BudgetAmount")]
        public Nullable<decimal> BudgetAmount { get; set; }
		[Property("EventName", SoType.Text, "EventName", "EventName")]
        public string EventName { get; set; }
		[Property("RequestDescription", SoType.Text, "RequestDescription", "RequestDescription")]
        public string RequestDescription { get; set; }
		[Property("RequestSubTypeCode", SoType.Text, "RequestSubTypeCode", "RequestSubTypeCode")]
        public string RequestSubTypeCode { get; set; }
		[Property("RequestSubTypeName", SoType.Text, "RequestSubTypeName", "RequestSubTypeName")]
        public string RequestSubTypeName { get; set; }
		[Property("State", SoType.Text, "State", "State")]
        public string State { get; set; }
		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public Nullable<System.DateTime> CreateTime { get; set; }
		[Property("EventStartDate", SoType.DateTime, "EventStartDate", "EventStartDate")]
        public Nullable<System.DateTime> EventStartDate { get; set; }
		[Property("EventEndDate", SoType.DateTime, "EventEndDate", "EventEndDate")]
        public Nullable<System.DateTime> EventEndDate { get; set; }
		[Property("CompletedTime", SoType.DateTime, "CompletedTime", "CompletedTime")]
        public Nullable<System.DateTime> CompletedTime { get; set; }
       
    }

    public partial class VReportsHCOBudgetSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public VReportsHCOBudgetSvc()
        { }

        public static VReportsHCOBudgetSvc GetFromEntity(VReportsHCOBudget entity)
        {
            VReportsHCOBudgetSvc svc = new VReportsHCOBudgetSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(VReportsHCOBudget entity)
        {
            			this.RequestGuid = entity.RequestGuid;
			this.RequestNo = entity.RequestNo;
			this.BA = entity.BA;
			this.BL = entity.BL;
			this.Function = entity.Function;
			this.Region = entity.Region;
			this.InstitutionCode = entity.InstitutionCode;
			this.InstitutionName = entity.InstitutionName;
			this.BudgetAmount = entity.BudgetAmount;
			this.EventName = entity.EventName;
			this.RequestDescription = entity.RequestDescription;
			this.RequestSubTypeCode = entity.RequestSubTypeCode;
			this.RequestSubTypeName = entity.RequestSubTypeName;
			this.State = entity.State;
			this.CreateTime = entity.CreateTime;
			this.EventStartDate = entity.EventStartDate;
			this.EventEndDate = entity.EventEndDate;
			this.CompletedTime = entity.CompletedTime;
		}

        private VReportsHCOBudget ConvertToEntity()
        {
            var entity = new VReportsHCOBudget();
            			entity.RequestGuid = this.RequestGuid;
			entity.RequestNo = this.RequestNo;
			entity.BA = this.BA;
			entity.BL = this.BL;
			entity.Function = this.Function;
			entity.Region = this.Region;
			entity.InstitutionCode = this.InstitutionCode;
			entity.InstitutionName = this.InstitutionName;
			entity.BudgetAmount = this.BudgetAmount;
			entity.EventName = this.EventName;
			entity.RequestDescription = this.RequestDescription;
			entity.RequestSubTypeCode = this.RequestSubTypeCode;
			entity.RequestSubTypeName = this.RequestSubTypeName;
			entity.State = this.State;
			entity.CreateTime = this.CreateTime;
			entity.EventStartDate = this.EventStartDate;
			entity.EventEndDate = this.EventEndDate;
			entity.CompletedTime = this.CompletedTime;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "RequestGuid" },
            new string[] { "RequestGuid","RequestNo","BA","BL","Function","Region","InstitutionCode","InstitutionName","BudgetAmount","EventName","RequestDescription","RequestSubTypeCode","RequestSubTypeName","State","CreateTime","EventStartDate","EventEndDate","CompletedTime"})]
        public VReportsHCOBudgetSvc Read()
        {
            VReportsHCOBudgetService service = new VReportsHCOBudgetService(ConnString);
            var model = service.Read(RequestGuid);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "RequestGuid","RequestNo","BA","BL","Function","Region","InstitutionCode","InstitutionName","BudgetAmount","EventName","RequestDescription","RequestSubTypeCode","RequestSubTypeName","State","CreateTime","EventStartDate","EventEndDate","CompletedTime" },
            new string[] { "RequestGuid"})]
        public VReportsHCOBudgetSvc Create()
        {
            VReportsHCOBudgetService service = new VReportsHCOBudgetService(ConnString);
            var entity = ConvertToEntity();
            RequestGuid = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "RequestGuid","RequestNo","BA","BL","Function","Region","InstitutionCode","InstitutionName","BudgetAmount","EventName","RequestDescription","RequestSubTypeCode","RequestSubTypeName","State","CreateTime","EventStartDate","EventEndDate","CompletedTime" },
            new string[] { })]
        public void Update()
        {
            VReportsHCOBudgetService service = new VReportsHCOBudgetService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "RequestGuid" },
            new string[] { })]
        public void Delete()
        {
            VReportsHCOBudgetService service = new VReportsHCOBudgetService(ConnString);
            service.Delete(RequestGuid);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "RequestGuid","RequestNo","BA","BL","Function","Region","InstitutionCode","InstitutionName","BudgetAmount","EventName","RequestDescription","RequestSubTypeCode","RequestSubTypeName","State","CreateTime","EventStartDate","EventEndDate","CompletedTime" },
            new string[] { "RequestGuid","RequestNo","BA","BL","Function","Region","InstitutionCode","InstitutionName","BudgetAmount","EventName","RequestDescription","RequestSubTypeCode","RequestSubTypeName","State","CreateTime","EventStartDate","EventEndDate","CompletedTime" })]
        public List<VReportsHCOBudgetSvc> List()
        {
            VReportsHCOBudgetService service = new VReportsHCOBudgetService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}