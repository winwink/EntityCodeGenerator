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
    [ServiceObject("EventRequestScheduleSvc", "EventRequestScheduleSvc", "EventRequestScheduleSvc")]
    public partial class EventRequestScheduleSvc
    {
		[Property("Guid", SoType.Text, "Guid", "Guid")]
        public string Guid { get; set; }
		[Property("RequestGuid", SoType.Text, "RequestGuid", "RequestGuid")]
        public string RequestGuid { get; set; }
		[Property("PlannedDate", SoType.DateTime, "PlannedDate", "PlannedDate")]
        public Nullable<System.DateTime> PlannedDate { get; set; }
		[Property("StartTime", SoType.Time, "StartTime", "StartTime")]
        public Nullable<System.TimeSpan> StartTime { get; set; }
		[Property("EndTime", SoType.Time, "EndTime", "EndTime")]
        public Nullable<System.TimeSpan> EndTime { get; set; }
		[Property("PlannedTopic", SoType.Text, "PlannedTopic", "PlannedTopic")]
        public string PlannedTopic { get; set; }
		[Property("PlannedSpeaker", SoType.Text, "PlannedSpeaker", "PlannedSpeaker")]
        public string PlannedSpeaker { get; set; }
		[Property("PlannedChairman", SoType.Text, "PlannedChairman", "PlannedChairman")]
        public string PlannedChairman { get; set; }
		[Property("HasOffLabel", SoType.YesNo, "HasOffLabel", "HasOffLabel")]
        public Nullable<bool> HasOffLabel { get; set; }
		[Property("Remark", SoType.Text, "Remark", "Remark")]
        public string Remark { get; set; }
		[Property("OrderId", SoType.Number, "OrderId", "OrderId")]
        public Nullable<int> OrderId { get; set; }
       
    }

    public partial class EventRequestScheduleSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public EventRequestScheduleSvc()
        { }

        public static EventRequestScheduleSvc GetFromEntity(EventRequestSchedule entity)
        {
            EventRequestScheduleSvc svc = new EventRequestScheduleSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(EventRequestSchedule entity)
        {
            			this.Guid = entity.Guid;
			this.RequestGuid = entity.RequestGuid;
			this.PlannedDate = entity.PlannedDate;
			this.StartTime = entity.StartTime;
			this.EndTime = entity.EndTime;
			this.PlannedTopic = entity.PlannedTopic;
			this.PlannedSpeaker = entity.PlannedSpeaker;
			this.PlannedChairman = entity.PlannedChairman;
			this.HasOffLabel = entity.HasOffLabel;
			this.Remark = entity.Remark;
			this.OrderId = entity.OrderId;
		}

        private EventRequestSchedule ConvertToEntity()
        {
            var entity = new EventRequestSchedule();
            			entity.Guid = this.Guid;
			entity.RequestGuid = this.RequestGuid;
			entity.PlannedDate = this.PlannedDate;
			entity.StartTime = this.StartTime;
			entity.EndTime = this.EndTime;
			entity.PlannedTopic = this.PlannedTopic;
			entity.PlannedSpeaker = this.PlannedSpeaker;
			entity.PlannedChairman = this.PlannedChairman;
			entity.HasOffLabel = this.HasOffLabel;
			entity.Remark = this.Remark;
			entity.OrderId = this.OrderId;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "Guid" },
            new string[] { "Guid","RequestGuid","PlannedDate","StartTime","EndTime","PlannedTopic","PlannedSpeaker","PlannedChairman","HasOffLabel","Remark","OrderId"})]
        public EventRequestScheduleSvc Read()
        {
            EventRequestScheduleService service = new EventRequestScheduleService(ConnString);
            var model = service.Read(Guid);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "Guid","RequestGuid","PlannedDate","StartTime","EndTime","PlannedTopic","PlannedSpeaker","PlannedChairman","HasOffLabel","Remark","OrderId" },
            new string[] { "Guid"})]
        public EventRequestScheduleSvc Create()
        {
            EventRequestScheduleService service = new EventRequestScheduleService(ConnString);
            var entity = ConvertToEntity();
            Guid = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "Guid","RequestGuid","PlannedDate","StartTime","EndTime","PlannedTopic","PlannedSpeaker","PlannedChairman","HasOffLabel","Remark","OrderId" },
            new string[] { })]
        public void Update()
        {
            EventRequestScheduleService service = new EventRequestScheduleService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "Guid" },
            new string[] { })]
        public void Delete()
        {
            EventRequestScheduleService service = new EventRequestScheduleService(ConnString);
            service.Delete(Guid);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "Guid","RequestGuid","PlannedDate","StartTime","EndTime","PlannedTopic","PlannedSpeaker","PlannedChairman","HasOffLabel","Remark","OrderId" },
            new string[] { "Guid","RequestGuid","PlannedDate","StartTime","EndTime","PlannedTopic","PlannedSpeaker","PlannedChairman","HasOffLabel","Remark","OrderId" })]
        public List<EventRequestScheduleSvc> List()
        {
            EventRequestScheduleService service = new EventRequestScheduleService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}