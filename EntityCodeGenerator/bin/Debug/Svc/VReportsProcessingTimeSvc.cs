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
    [ServiceObject("VReportsProcessingTimeSvc", "VReportsProcessingTimeSvc", "VReportsProcessingTimeSvc")]
    public partial class VReportsProcessingTimeSvc
    {
		[Property("RequestNo", SoType.Text, "RequestNo", "RequestNo")]
        public string RequestNo { get; set; }
		[Property("BACode", SoType.Text, "BACode", "BACode")]
        public string BACode { get; set; }
		[Property("BAName", SoType.Text, "BAName", "BAName")]
        public string BAName { get; set; }
		[Property("BLCode", SoType.Text, "BLCode", "BLCode")]
        public string BLCode { get; set; }
		[Property("BLName", SoType.Text, "BLName", "BLName")]
        public string BLName { get; set; }
		[Property("RequestSubTypeCode", SoType.Text, "RequestSubTypeCode", "RequestSubTypeCode")]
        public string RequestSubTypeCode { get; set; }
		[Property("RequestSubTypeName", SoType.Text, "RequestSubTypeName", "RequestSubTypeName")]
        public string RequestSubTypeName { get; set; }
		[Property("RequestTypeCode", SoType.Text, "RequestTypeCode", "RequestTypeCode")]
        public string RequestTypeCode { get; set; }
		[Property("RequestTypeName", SoType.Text, "RequestTypeName", "RequestTypeName")]
        public string RequestTypeName { get; set; }
		[Property("InitiatorName", SoType.Text, "InitiatorName", "InitiatorName")]
        public string InitiatorName { get; set; }
		[Property("InitiatorID", SoType.Text, "InitiatorID", "InitiatorID")]
        public string InitiatorID { get; set; }
		[Property("EventName", SoType.Text, "EventName", "EventName")]
        public string EventName { get; set; }
		[Property("StartTime", SoType.DateTime, "StartTime", "StartTime")]
        public Nullable<System.DateTime> StartTime { get; set; }
		[Property("EndTime", SoType.DateTime, "EndTime", "EndTime")]
        public Nullable<System.DateTime> EndTime { get; set; }
		[Property("ProcInstID", SoType.Number, "ProcInstID", "ProcInstID")]
        public Nullable<int> ProcInstID { get; set; }
		[Property("ActivityName", SoType.Text, "ActivityName", "ActivityName")]
        public string ActivityName { get; set; }
		[Property("Action", SoType.Text, "Action", "Action")]
        public string Action { get; set; }
		[Property("Department", SoType.Text, "Department", "Department")]
        public string Department { get; set; }
       
    }

    public partial class VReportsProcessingTimeSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public VReportsProcessingTimeSvc()
        { }

        public static VReportsProcessingTimeSvc GetFromEntity(VReportsProcessingTime entity)
        {
            VReportsProcessingTimeSvc svc = new VReportsProcessingTimeSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(VReportsProcessingTime entity)
        {
            			this.RequestNo = entity.RequestNo;
			this.BACode = entity.BACode;
			this.BAName = entity.BAName;
			this.BLCode = entity.BLCode;
			this.BLName = entity.BLName;
			this.RequestSubTypeCode = entity.RequestSubTypeCode;
			this.RequestSubTypeName = entity.RequestSubTypeName;
			this.RequestTypeCode = entity.RequestTypeCode;
			this.RequestTypeName = entity.RequestTypeName;
			this.InitiatorName = entity.InitiatorName;
			this.InitiatorID = entity.InitiatorID;
			this.EventName = entity.EventName;
			this.StartTime = entity.StartTime;
			this.EndTime = entity.EndTime;
			this.ProcInstID = entity.ProcInstID;
			this.ActivityName = entity.ActivityName;
			this.Action = entity.Action;
			this.Department = entity.Department;
		}

        private VReportsProcessingTime ConvertToEntity()
        {
            var entity = new VReportsProcessingTime();
            			entity.RequestNo = this.RequestNo;
			entity.BACode = this.BACode;
			entity.BAName = this.BAName;
			entity.BLCode = this.BLCode;
			entity.BLName = this.BLName;
			entity.RequestSubTypeCode = this.RequestSubTypeCode;
			entity.RequestSubTypeName = this.RequestSubTypeName;
			entity.RequestTypeCode = this.RequestTypeCode;
			entity.RequestTypeName = this.RequestTypeName;
			entity.InitiatorName = this.InitiatorName;
			entity.InitiatorID = this.InitiatorID;
			entity.EventName = this.EventName;
			entity.StartTime = this.StartTime;
			entity.EndTime = this.EndTime;
			entity.ProcInstID = this.ProcInstID;
			entity.ActivityName = this.ActivityName;
			entity.Action = this.Action;
			entity.Department = this.Department;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "RequestTypeName" },
            new string[] { "RequestNo","BACode","BAName","BLCode","BLName","RequestSubTypeCode","RequestSubTypeName","RequestTypeCode","RequestTypeName","InitiatorName","InitiatorID","EventName","StartTime","EndTime","ProcInstID","ActivityName","Action","Department"})]
        public VReportsProcessingTimeSvc Read()
        {
            VReportsProcessingTimeService service = new VReportsProcessingTimeService(ConnString);
            var model = service.Read(RequestTypeName);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "RequestNo","BACode","BAName","BLCode","BLName","RequestSubTypeCode","RequestSubTypeName","RequestTypeCode","RequestTypeName","InitiatorName","InitiatorID","EventName","StartTime","EndTime","ProcInstID","ActivityName","Action","Department" },
            new string[] { "RequestTypeName"})]
        public VReportsProcessingTimeSvc Create()
        {
            VReportsProcessingTimeService service = new VReportsProcessingTimeService(ConnString);
            var entity = ConvertToEntity();
            RequestTypeName = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "RequestNo","BACode","BAName","BLCode","BLName","RequestSubTypeCode","RequestSubTypeName","RequestTypeCode","RequestTypeName","InitiatorName","InitiatorID","EventName","StartTime","EndTime","ProcInstID","ActivityName","Action","Department" },
            new string[] { })]
        public void Update()
        {
            VReportsProcessingTimeService service = new VReportsProcessingTimeService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "RequestTypeName" },
            new string[] { })]
        public void Delete()
        {
            VReportsProcessingTimeService service = new VReportsProcessingTimeService(ConnString);
            service.Delete(RequestTypeName);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "RequestNo","BACode","BAName","BLCode","BLName","RequestSubTypeCode","RequestSubTypeName","RequestTypeCode","RequestTypeName","InitiatorName","InitiatorID","EventName","StartTime","EndTime","ProcInstID","ActivityName","Action","Department" },
            new string[] { "RequestNo","BACode","BAName","BLCode","BLName","RequestSubTypeCode","RequestSubTypeName","RequestTypeCode","RequestTypeName","InitiatorName","InitiatorID","EventName","StartTime","EndTime","ProcInstID","ActivityName","Action","Department" })]
        public List<VReportsProcessingTimeSvc> List()
        {
            VReportsProcessingTimeService service = new VReportsProcessingTimeService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}