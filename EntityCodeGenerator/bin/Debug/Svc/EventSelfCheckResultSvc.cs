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
    [ServiceObject("EventSelfCheckResultSvc", "EventSelfCheckResultSvc", "EventSelfCheckResultSvc")]
    public partial class EventSelfCheckResultSvc
    {
		[Property("SelfCheckID", SoType.Number, "SelfCheckID", "SelfCheckID")]
        public int SelfCheckID { get; set; }
		[Property("RequestGuid", SoType.Text, "RequestGuid", "RequestGuid")]
        public string RequestGuid { get; set; }
		[Property("OrderId", SoType.Number, "OrderId", "OrderId")]
        public Nullable<int> OrderId { get; set; }
		[Property("CheckContent", SoType.Text, "CheckContent", "CheckContent")]
        public string CheckContent { get; set; }
		[Property("CheckResult", SoType.Text, "CheckResult", "CheckResult")]
        public string CheckResult { get; set; }
		[Property("Reason", SoType.Text, "Reason", "Reason")]
        public string Reason { get; set; }
		[Property("OwnerID", SoType.Text, "OwnerID", "OwnerID")]
        public string OwnerID { get; set; }
		[Property("OwnerName", SoType.Text, "OwnerName", "OwnerName")]
        public string OwnerName { get; set; }
		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public Nullable<System.DateTime> CreateTime { get; set; }
       
    }

    public partial class EventSelfCheckResultSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public EventSelfCheckResultSvc()
        { }

        public static EventSelfCheckResultSvc GetFromEntity(EventSelfCheckResult entity)
        {
            EventSelfCheckResultSvc svc = new EventSelfCheckResultSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(EventSelfCheckResult entity)
        {
            			this.SelfCheckID = entity.SelfCheckID;
			this.RequestGuid = entity.RequestGuid;
			this.OrderId = entity.OrderId;
			this.CheckContent = entity.CheckContent;
			this.CheckResult = entity.CheckResult;
			this.Reason = entity.Reason;
			this.OwnerID = entity.OwnerID;
			this.OwnerName = entity.OwnerName;
			this.CreateTime = entity.CreateTime;
		}

        private EventSelfCheckResult ConvertToEntity()
        {
            var entity = new EventSelfCheckResult();
            			entity.SelfCheckID = this.SelfCheckID;
			entity.RequestGuid = this.RequestGuid;
			entity.OrderId = this.OrderId;
			entity.CheckContent = this.CheckContent;
			entity.CheckResult = this.CheckResult;
			entity.Reason = this.Reason;
			entity.OwnerID = this.OwnerID;
			entity.OwnerName = this.OwnerName;
			entity.CreateTime = this.CreateTime;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "SelfCheckID" },
            new string[] { "SelfCheckID","RequestGuid","OrderId","CheckContent","CheckResult","Reason","OwnerID","OwnerName","CreateTime"})]
        public EventSelfCheckResultSvc Read()
        {
            EventSelfCheckResultService service = new EventSelfCheckResultService(ConnString);
            var model = service.Read(SelfCheckID);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "SelfCheckID","RequestGuid","OrderId","CheckContent","CheckResult","Reason","OwnerID","OwnerName","CreateTime" },
            new string[] { "SelfCheckID"})]
        public EventSelfCheckResultSvc Create()
        {
            EventSelfCheckResultService service = new EventSelfCheckResultService(ConnString);
            var entity = ConvertToEntity();
            SelfCheckID = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "SelfCheckID","RequestGuid","OrderId","CheckContent","CheckResult","Reason","OwnerID","OwnerName","CreateTime" },
            new string[] { })]
        public void Update()
        {
            EventSelfCheckResultService service = new EventSelfCheckResultService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "SelfCheckID" },
            new string[] { })]
        public void Delete()
        {
            EventSelfCheckResultService service = new EventSelfCheckResultService(ConnString);
            service.Delete(SelfCheckID);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "SelfCheckID","RequestGuid","OrderId","CheckContent","CheckResult","Reason","OwnerID","OwnerName","CreateTime" },
            new string[] { "SelfCheckID","RequestGuid","OrderId","CheckContent","CheckResult","Reason","OwnerID","OwnerName","CreateTime" })]
        public List<EventSelfCheckResultSvc> List()
        {
            EventSelfCheckResultService service = new EventSelfCheckResultService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}