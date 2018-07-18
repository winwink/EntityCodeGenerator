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
    [ServiceObject("VReportsWorkLogSvc", "VReportsWorkLogSvc", "VReportsWorkLogSvc")]
    public partial class VReportsWorkLogSvc
    {
		[Property("Approver", SoType.Text, "Approver", "Approver")]
        public string Approver { get; set; }
		[Property("RequestNo", SoType.Text, "RequestNo", "RequestNo")]
        public string RequestNo { get; set; }
		[Property("IsHaveContract", SoType.Number, "IsHaveContract", "IsHaveContract")]
        public Nullable<int> IsHaveContract { get; set; }
		[Property("BACode", SoType.Text, "BACode", "BACode")]
        public string BACode { get; set; }
		[Property("BAName", SoType.Text, "BAName", "BAName")]
        public string BAName { get; set; }
		[Property("BLName", SoType.Text, "BLName", "BLName")]
        public string BLName { get; set; }
		[Property("InitiatorID", SoType.Text, "InitiatorID", "InitiatorID")]
        public string InitiatorID { get; set; }
		[Property("InitiatorName", SoType.Text, "InitiatorName", "InitiatorName")]
        public string InitiatorName { get; set; }
		[Property("OwnerID", SoType.Text, "OwnerID", "OwnerID")]
        public string OwnerID { get; set; }
		[Property("OwnerName", SoType.Text, "OwnerName", "OwnerName")]
        public string OwnerName { get; set; }
		[Property("EventName", SoType.Text, "EventName", "EventName")]
        public string EventName { get; set; }
		[Property("IsHCO", SoType.Text, "IsHCO", "IsHCO")]
        public string IsHCO { get; set; }
		[Property("EventLocationName", SoType.Text, "EventLocationName", "EventLocationName")]
        public string EventLocationName { get; set; }
		[Property("RequestSubTypeCode", SoType.Text, "RequestSubTypeCode", "RequestSubTypeCode")]
        public string RequestSubTypeCode { get; set; }
		[Property("RequestSubTypeName", SoType.Text, "RequestSubTypeName", "RequestSubTypeName")]
        public string RequestSubTypeName { get; set; }
		[Property("BudgetAmount", SoType.Decimal, "BudgetAmount", "BudgetAmount")]
        public Nullable<decimal> BudgetAmount { get; set; }
		[Property("EventStartDate", SoType.DateTime, "EventStartDate", "EventStartDate")]
        public Nullable<System.DateTime> EventStartDate { get; set; }
		[Property("EventEndDate", SoType.DateTime, "EventEndDate", "EventEndDate")]
        public Nullable<System.DateTime> EventEndDate { get; set; }
		[Property("RequestDate", SoType.DateTime, "RequestDate", "RequestDate")]
        public Nullable<System.DateTime> RequestDate { get; set; }
		[Property("IsAfterFact", SoType.Text, "IsAfterFact", "IsAfterFact")]
        public string IsAfterFact { get; set; }
		[Property("SubmitTime", SoType.DateTime, "SubmitTime", "SubmitTime")]
        public Nullable<System.DateTime> SubmitTime { get; set; }
		[Property("Action", SoType.Text, "Action", "Action")]
        public string Action { get; set; }
       
    }

    public partial class VReportsWorkLogSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public VReportsWorkLogSvc()
        { }

        public static VReportsWorkLogSvc GetFromEntity(VReportsWorkLog entity)
        {
            VReportsWorkLogSvc svc = new VReportsWorkLogSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(VReportsWorkLog entity)
        {
            			this.Approver = entity.Approver;
			this.RequestNo = entity.RequestNo;
			this.IsHaveContract = entity.IsHaveContract;
			this.BACode = entity.BACode;
			this.BAName = entity.BAName;
			this.BLName = entity.BLName;
			this.InitiatorID = entity.InitiatorID;
			this.InitiatorName = entity.InitiatorName;
			this.OwnerID = entity.OwnerID;
			this.OwnerName = entity.OwnerName;
			this.EventName = entity.EventName;
			this.IsHCO = entity.IsHCO;
			this.EventLocationName = entity.EventLocationName;
			this.RequestSubTypeCode = entity.RequestSubTypeCode;
			this.RequestSubTypeName = entity.RequestSubTypeName;
			this.BudgetAmount = entity.BudgetAmount;
			this.EventStartDate = entity.EventStartDate;
			this.EventEndDate = entity.EventEndDate;
			this.RequestDate = entity.RequestDate;
			this.IsAfterFact = entity.IsAfterFact;
			this.SubmitTime = entity.SubmitTime;
			this.Action = entity.Action;
		}

        private VReportsWorkLog ConvertToEntity()
        {
            var entity = new VReportsWorkLog();
            			entity.Approver = this.Approver;
			entity.RequestNo = this.RequestNo;
			entity.IsHaveContract = this.IsHaveContract;
			entity.BACode = this.BACode;
			entity.BAName = this.BAName;
			entity.BLName = this.BLName;
			entity.InitiatorID = this.InitiatorID;
			entity.InitiatorName = this.InitiatorName;
			entity.OwnerID = this.OwnerID;
			entity.OwnerName = this.OwnerName;
			entity.EventName = this.EventName;
			entity.IsHCO = this.IsHCO;
			entity.EventLocationName = this.EventLocationName;
			entity.RequestSubTypeCode = this.RequestSubTypeCode;
			entity.RequestSubTypeName = this.RequestSubTypeName;
			entity.BudgetAmount = this.BudgetAmount;
			entity.EventStartDate = this.EventStartDate;
			entity.EventEndDate = this.EventEndDate;
			entity.RequestDate = this.RequestDate;
			entity.IsAfterFact = this.IsAfterFact;
			entity.SubmitTime = this.SubmitTime;
			entity.Action = this.Action;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "IsHCO" },
            new string[] { "Approver","RequestNo","IsHaveContract","BACode","BAName","BLName","InitiatorID","InitiatorName","OwnerID","OwnerName","EventName","IsHCO","EventLocationName","RequestSubTypeCode","RequestSubTypeName","BudgetAmount","EventStartDate","EventEndDate","RequestDate","IsAfterFact","SubmitTime","Action"})]
        public VReportsWorkLogSvc Read()
        {
            VReportsWorkLogService service = new VReportsWorkLogService(ConnString);
            var model = service.Read(IsHCO);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "Approver","RequestNo","IsHaveContract","BACode","BAName","BLName","InitiatorID","InitiatorName","OwnerID","OwnerName","EventName","IsHCO","EventLocationName","RequestSubTypeCode","RequestSubTypeName","BudgetAmount","EventStartDate","EventEndDate","RequestDate","IsAfterFact","SubmitTime","Action" },
            new string[] { "IsHCO"})]
        public VReportsWorkLogSvc Create()
        {
            VReportsWorkLogService service = new VReportsWorkLogService(ConnString);
            var entity = ConvertToEntity();
            IsHCO = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "Approver","RequestNo","IsHaveContract","BACode","BAName","BLName","InitiatorID","InitiatorName","OwnerID","OwnerName","EventName","IsHCO","EventLocationName","RequestSubTypeCode","RequestSubTypeName","BudgetAmount","EventStartDate","EventEndDate","RequestDate","IsAfterFact","SubmitTime","Action" },
            new string[] { })]
        public void Update()
        {
            VReportsWorkLogService service = new VReportsWorkLogService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "IsHCO" },
            new string[] { })]
        public void Delete()
        {
            VReportsWorkLogService service = new VReportsWorkLogService(ConnString);
            service.Delete(IsHCO);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "Approver","RequestNo","IsHaveContract","BACode","BAName","BLName","InitiatorID","InitiatorName","OwnerID","OwnerName","EventName","IsHCO","EventLocationName","RequestSubTypeCode","RequestSubTypeName","BudgetAmount","EventStartDate","EventEndDate","RequestDate","IsAfterFact","SubmitTime","Action" },
            new string[] { "Approver","RequestNo","IsHaveContract","BACode","BAName","BLName","InitiatorID","InitiatorName","OwnerID","OwnerName","EventName","IsHCO","EventLocationName","RequestSubTypeCode","RequestSubTypeName","BudgetAmount","EventStartDate","EventEndDate","RequestDate","IsAfterFact","SubmitTime","Action" })]
        public List<VReportsWorkLogSvc> List()
        {
            VReportsWorkLogService service = new VReportsWorkLogService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}