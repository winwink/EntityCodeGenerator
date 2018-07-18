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
    [ServiceObject("RequestCarFleetSvc", "RequestCarFleetSvc", "RequestCarFleetSvc")]
    public partial class RequestCarFleetSvc
    {
		[Property("RequestID", SoType.Number, "RequestID", "RequestID")]
        public long RequestID { get; set; }
		[Property("RequestNo", SoType.Text, "RequestNo", "RequestNo")]
        public string RequestNo { get; set; }
		[Property("RequestType", SoType.Text, "RequestType", "RequestType")]
        public string RequestType { get; set; }
		[Property("RequestTypeName", SoType.Text, "RequestTypeName", "RequestTypeName")]
        public string RequestTypeName { get; set; }
		[Property("Status", SoType.Text, "Status", "Status")]
        public string Status { get; set; }
		[Property("ProcInstID", SoType.Number, "ProcInstID", "ProcInstID")]
        public Nullable<int> ProcInstID { get; set; }
		[Property("InitiatorID", SoType.Text, "InitiatorID", "InitiatorID")]
        public string InitiatorID { get; set; }
		[Property("InitiatorName", SoType.Text, "InitiatorName", "InitiatorName")]
        public string InitiatorName { get; set; }
		[Property("RequestUrl", SoType.Text, "RequestUrl", "RequestUrl")]
        public string RequestUrl { get; set; }
		[Property("CreateBy", SoType.Text, "CreateBy", "CreateBy")]
        public string CreateBy { get; set; }
		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public Nullable<System.DateTime> CreateTime { get; set; }
		[Property("UpdateBy", SoType.Text, "UpdateBy", "UpdateBy")]
        public string UpdateBy { get; set; }
		[Property("UpdateTime", SoType.DateTime, "UpdateTime", "UpdateTime")]
        public Nullable<System.DateTime> UpdateTime { get; set; }
		[Property("CompleteTime", SoType.DateTime, "CompleteTime", "CompleteTime")]
        public Nullable<System.DateTime> CompleteTime { get; set; }
		[Property("FormFields", SoType.Text, "FormFields", "FormFields")]
        public string FormFields { get; set; }
       
    }

    public partial class RequestCarFleetSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public RequestCarFleetSvc()
        { }

        public static RequestCarFleetSvc GetFromEntity(RequestCarFleet entity)
        {
            RequestCarFleetSvc svc = new RequestCarFleetSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(RequestCarFleet entity)
        {
            			this.RequestID = entity.RequestID;
			this.RequestNo = entity.RequestNo;
			this.RequestType = entity.RequestType;
			this.RequestTypeName = entity.RequestTypeName;
			this.Status = entity.Status;
			this.ProcInstID = entity.ProcInstID;
			this.InitiatorID = entity.InitiatorID;
			this.InitiatorName = entity.InitiatorName;
			this.RequestUrl = entity.RequestUrl;
			this.CreateBy = entity.CreateBy;
			this.CreateTime = entity.CreateTime;
			this.UpdateBy = entity.UpdateBy;
			this.UpdateTime = entity.UpdateTime;
			this.CompleteTime = entity.CompleteTime;
			this.FormFields = entity.FormFields;
		}

        private RequestCarFleet ConvertToEntity()
        {
            var entity = new RequestCarFleet();
            			entity.RequestID = this.RequestID;
			entity.RequestNo = this.RequestNo;
			entity.RequestType = this.RequestType;
			entity.RequestTypeName = this.RequestTypeName;
			entity.Status = this.Status;
			entity.ProcInstID = this.ProcInstID;
			entity.InitiatorID = this.InitiatorID;
			entity.InitiatorName = this.InitiatorName;
			entity.RequestUrl = this.RequestUrl;
			entity.CreateBy = this.CreateBy;
			entity.CreateTime = this.CreateTime;
			entity.UpdateBy = this.UpdateBy;
			entity.UpdateTime = this.UpdateTime;
			entity.CompleteTime = this.CompleteTime;
			entity.FormFields = this.FormFields;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "RequestID" },
            new string[] { "RequestID","RequestNo","RequestType","RequestTypeName","Status","ProcInstID","InitiatorID","InitiatorName","RequestUrl","CreateBy","CreateTime","UpdateBy","UpdateTime","CompleteTime","FormFields"})]
        public RequestCarFleetSvc Read()
        {
            RequestCarFleetService service = new RequestCarFleetService(ConnString);
            var model = service.Read(RequestID);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "RequestID","RequestNo","RequestType","RequestTypeName","Status","ProcInstID","InitiatorID","InitiatorName","RequestUrl","CreateBy","CreateTime","UpdateBy","UpdateTime","CompleteTime","FormFields" },
            new string[] { "RequestID"})]
        public RequestCarFleetSvc Create()
        {
            RequestCarFleetService service = new RequestCarFleetService(ConnString);
            var entity = ConvertToEntity();
            RequestID = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "RequestID","RequestNo","RequestType","RequestTypeName","Status","ProcInstID","InitiatorID","InitiatorName","RequestUrl","CreateBy","CreateTime","UpdateBy","UpdateTime","CompleteTime","FormFields" },
            new string[] { })]
        public void Update()
        {
            RequestCarFleetService service = new RequestCarFleetService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "RequestID" },
            new string[] { })]
        public void Delete()
        {
            RequestCarFleetService service = new RequestCarFleetService(ConnString);
            service.Delete(RequestID);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "RequestID","RequestNo","RequestType","RequestTypeName","Status","ProcInstID","InitiatorID","InitiatorName","RequestUrl","CreateBy","CreateTime","UpdateBy","UpdateTime","CompleteTime","FormFields" },
            new string[] { "RequestID","RequestNo","RequestType","RequestTypeName","Status","ProcInstID","InitiatorID","InitiatorName","RequestUrl","CreateBy","CreateTime","UpdateBy","UpdateTime","CompleteTime","FormFields" })]
        public List<RequestCarFleetSvc> List()
        {
            RequestCarFleetService service = new RequestCarFleetService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}