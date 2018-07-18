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
    [ServiceObject("EventRequestBudgetSvc", "EventRequestBudgetSvc", "EventRequestBudgetSvc")]
    public partial class EventRequestBudgetSvc
    {
		[Property("Guid", SoType.Text, "Guid", "Guid")]
        public string Guid { get; set; }
		[Property("RequestGuid", SoType.Text, "RequestGuid", "RequestGuid")]
        public string RequestGuid { get; set; }
		[Property("Name", SoType.Text, "Name", "Name")]
        public string Name { get; set; }
		[Property("ParticipantNumber", SoType.Number, "ParticipantNumber", "ParticipantNumber")]
        public Nullable<int> ParticipantNumber { get; set; }
		[Property("Number", SoType.Number, "Number", "Number")]
        public Nullable<int> Number { get; set; }
		[Property("SinglePrice", SoType.Decimal, "SinglePrice", "SinglePrice")]
        public Nullable<decimal> SinglePrice { get; set; }
		[Property("TotalPrice", SoType.Decimal, "TotalPrice", "TotalPrice")]
        public Nullable<decimal> TotalPrice { get; set; }
		[Property("Remark", SoType.Text, "Remark", "Remark")]
        public string Remark { get; set; }
		[Property("OrderId", SoType.Number, "OrderId", "OrderId")]
        public Nullable<int> OrderId { get; set; }
		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public Nullable<System.DateTime> CreateTime { get; set; }
       
    }

    public partial class EventRequestBudgetSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public EventRequestBudgetSvc()
        { }

        public static EventRequestBudgetSvc GetFromEntity(EventRequestBudget entity)
        {
            EventRequestBudgetSvc svc = new EventRequestBudgetSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(EventRequestBudget entity)
        {
            			this.Guid = entity.Guid;
			this.RequestGuid = entity.RequestGuid;
			this.Name = entity.Name;
			this.ParticipantNumber = entity.ParticipantNumber;
			this.Number = entity.Number;
			this.SinglePrice = entity.SinglePrice;
			this.TotalPrice = entity.TotalPrice;
			this.Remark = entity.Remark;
			this.OrderId = entity.OrderId;
			this.CreateTime = entity.CreateTime;
		}

        private EventRequestBudget ConvertToEntity()
        {
            var entity = new EventRequestBudget();
            			entity.Guid = this.Guid;
			entity.RequestGuid = this.RequestGuid;
			entity.Name = this.Name;
			entity.ParticipantNumber = this.ParticipantNumber;
			entity.Number = this.Number;
			entity.SinglePrice = this.SinglePrice;
			entity.TotalPrice = this.TotalPrice;
			entity.Remark = this.Remark;
			entity.OrderId = this.OrderId;
			entity.CreateTime = this.CreateTime;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "Guid" },
            new string[] { "Guid","RequestGuid","Name","ParticipantNumber","Number","SinglePrice","TotalPrice","Remark","OrderId","CreateTime"})]
        public EventRequestBudgetSvc Read()
        {
            EventRequestBudgetService service = new EventRequestBudgetService(ConnString);
            var model = service.Read(Guid);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "Guid","RequestGuid","Name","ParticipantNumber","Number","SinglePrice","TotalPrice","Remark","OrderId","CreateTime" },
            new string[] { "Guid"})]
        public EventRequestBudgetSvc Create()
        {
            EventRequestBudgetService service = new EventRequestBudgetService(ConnString);
            var entity = ConvertToEntity();
            Guid = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "Guid","RequestGuid","Name","ParticipantNumber","Number","SinglePrice","TotalPrice","Remark","OrderId","CreateTime" },
            new string[] { })]
        public void Update()
        {
            EventRequestBudgetService service = new EventRequestBudgetService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "Guid" },
            new string[] { })]
        public void Delete()
        {
            EventRequestBudgetService service = new EventRequestBudgetService(ConnString);
            service.Delete(Guid);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "Guid","RequestGuid","Name","ParticipantNumber","Number","SinglePrice","TotalPrice","Remark","OrderId","CreateTime" },
            new string[] { "Guid","RequestGuid","Name","ParticipantNumber","Number","SinglePrice","TotalPrice","Remark","OrderId","CreateTime" })]
        public List<EventRequestBudgetSvc> List()
        {
            EventRequestBudgetService service = new EventRequestBudgetService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}