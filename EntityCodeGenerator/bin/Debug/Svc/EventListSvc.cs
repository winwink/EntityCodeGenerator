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
    [ServiceObject("EventListSvc", "EventListSvc", "EventListSvc")]
    public partial class EventListSvc
    {
		[Property("EventID", SoType.Text, "EventID", "EventID")]
        public string EventID { get; set; }
		[Property("EventName", SoType.Text, "EventName", "EventName")]
        public string EventName { get; set; }
		[Property("EventStartDate", SoType.DateTime, "EventStartDate", "EventStartDate")]
        public Nullable<System.DateTime> EventStartDate { get; set; }
		[Property("EventEndDate", SoType.DateTime, "EventEndDate", "EventEndDate")]
        public Nullable<System.DateTime> EventEndDate { get; set; }
		[Property("EventLocation", SoType.Text, "EventLocation", "EventLocation")]
        public string EventLocation { get; set; }
		[Property("EventProvince", SoType.Text, "EventProvince", "EventProvince")]
        public string EventProvince { get; set; }
		[Property("EventCity", SoType.Text, "EventCity", "EventCity")]
        public string EventCity { get; set; }
		[Property("EventOtherLocation", SoType.Text, "EventOtherLocation", "EventOtherLocation")]
        public string EventOtherLocation { get; set; }
		[Property("EventSummary", SoType.Text, "EventSummary", "EventSummary")]
        public string EventSummary { get; set; }
		[Property("EventFirstRequestGuid", SoType.Text, "EventFirstRequestGuid", "EventFirstRequestGuid")]
        public string EventFirstRequestGuid { get; set; }
       
    }

    public partial class EventListSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public EventListSvc()
        { }

        public static EventListSvc GetFromEntity(EventList entity)
        {
            EventListSvc svc = new EventListSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(EventList entity)
        {
            			this.EventID = entity.EventID;
			this.EventName = entity.EventName;
			this.EventStartDate = entity.EventStartDate;
			this.EventEndDate = entity.EventEndDate;
			this.EventLocation = entity.EventLocation;
			this.EventProvince = entity.EventProvince;
			this.EventCity = entity.EventCity;
			this.EventOtherLocation = entity.EventOtherLocation;
			this.EventSummary = entity.EventSummary;
			this.EventFirstRequestGuid = entity.EventFirstRequestGuid;
		}

        private EventList ConvertToEntity()
        {
            var entity = new EventList();
            			entity.EventID = this.EventID;
			entity.EventName = this.EventName;
			entity.EventStartDate = this.EventStartDate;
			entity.EventEndDate = this.EventEndDate;
			entity.EventLocation = this.EventLocation;
			entity.EventProvince = this.EventProvince;
			entity.EventCity = this.EventCity;
			entity.EventOtherLocation = this.EventOtherLocation;
			entity.EventSummary = this.EventSummary;
			entity.EventFirstRequestGuid = this.EventFirstRequestGuid;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "EventID" },
            new string[] { "EventID","EventName","EventStartDate","EventEndDate","EventLocation","EventProvince","EventCity","EventOtherLocation","EventSummary","EventFirstRequestGuid"})]
        public EventListSvc Read()
        {
            EventListService service = new EventListService(ConnString);
            var model = service.Read(EventID);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "EventID","EventName","EventStartDate","EventEndDate","EventLocation","EventProvince","EventCity","EventOtherLocation","EventSummary","EventFirstRequestGuid" },
            new string[] { "EventID"})]
        public EventListSvc Create()
        {
            EventListService service = new EventListService(ConnString);
            var entity = ConvertToEntity();
            EventID = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "EventID","EventName","EventStartDate","EventEndDate","EventLocation","EventProvince","EventCity","EventOtherLocation","EventSummary","EventFirstRequestGuid" },
            new string[] { })]
        public void Update()
        {
            EventListService service = new EventListService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "EventID" },
            new string[] { })]
        public void Delete()
        {
            EventListService service = new EventListService(ConnString);
            service.Delete(EventID);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "EventID","EventName","EventStartDate","EventEndDate","EventLocation","EventProvince","EventCity","EventOtherLocation","EventSummary","EventFirstRequestGuid" },
            new string[] { "EventID","EventName","EventStartDate","EventEndDate","EventLocation","EventProvince","EventCity","EventOtherLocation","EventSummary","EventFirstRequestGuid" })]
        public List<EventListSvc> List()
        {
            EventListService service = new EventListService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}