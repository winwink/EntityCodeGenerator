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
    [ServiceObject("EventRequestSvc", "EventRequestSvc", "EventRequestSvc")]
    public partial class EventRequestSvc
    {
		[Property("RequestGuid", SoType.Text, "RequestGuid", "RequestGuid")]
        public string RequestGuid { get; set; }
		[Property("RequestNo", SoType.Text, "RequestNo", "RequestNo")]
        public string RequestNo { get; set; }
		[Property("FormFields", SoType.Text, "FormFields", "FormFields")]
        public string FormFields { get; set; }
		[Property("RequestDate", SoType.DateTime, "RequestDate", "RequestDate")]
        public Nullable<System.DateTime> RequestDate { get; set; }
		[Property("InitiatorID", SoType.Text, "InitiatorID", "InitiatorID")]
        public string InitiatorID { get; set; }
		[Property("InitiatorName", SoType.Text, "InitiatorName", "InitiatorName")]
        public string InitiatorName { get; set; }
		[Property("InitiatorPhoneNo", SoType.Text, "InitiatorPhoneNo", "InitiatorPhoneNo")]
        public string InitiatorPhoneNo { get; set; }
		[Property("OwnerID", SoType.Text, "OwnerID", "OwnerID")]
        public string OwnerID { get; set; }
		[Property("OwnerName", SoType.Text, "OwnerName", "OwnerName")]
        public string OwnerName { get; set; }
		[Property("OwnerPhoneNo", SoType.Text, "OwnerPhoneNo", "OwnerPhoneNo")]
        public string OwnerPhoneNo { get; set; }
		[Property("BAName", SoType.Text, "BAName", "BAName")]
        public string BAName { get; set; }
		[Property("BACode", SoType.Text, "BACode", "BACode")]
        public string BACode { get; set; }
		[Property("BLName", SoType.Text, "BLName", "BLName")]
        public string BLName { get; set; }
		[Property("BLCode", SoType.Text, "BLCode", "BLCode")]
        public string BLCode { get; set; }
		[Property("FunctionRegionName", SoType.Text, "FunctionRegionName", "FunctionRegionName")]
        public string FunctionRegionName { get; set; }
		[Property("FunctionRegionCode", SoType.Text, "FunctionRegionCode", "FunctionRegionCode")]
        public string FunctionRegionCode { get; set; }
		[Property("RequestTypeName", SoType.Text, "RequestTypeName", "RequestTypeName")]
        public string RequestTypeName { get; set; }
		[Property("RequestTypeCode", SoType.Text, "RequestTypeCode", "RequestTypeCode")]
        public string RequestTypeCode { get; set; }
		[Property("RequestSubTypeName", SoType.Text, "RequestSubTypeName", "RequestSubTypeName")]
        public string RequestSubTypeName { get; set; }
		[Property("RequestSubTypeCode", SoType.Text, "RequestSubTypeCode", "RequestSubTypeCode")]
        public string RequestSubTypeCode { get; set; }
		[Property("InstitutionCode", SoType.Text, "InstitutionCode", "InstitutionCode")]
        public string InstitutionCode { get; set; }
		[Property("InstitutionName", SoType.Text, "InstitutionName", "InstitutionName")]
        public string InstitutionName { get; set; }
		[Property("InstitutionIsNoRisk", SoType.YesNo, "InstitutionIsNoRisk", "InstitutionIsNoRisk")]
        public Nullable<bool> InstitutionIsNoRisk { get; set; }
		[Property("EventRefID", SoType.Text, "EventRefID", "EventRefID")]
        public string EventRefID { get; set; }
		[Property("EventRefName", SoType.Text, "EventRefName", "EventRefName")]
        public string EventRefName { get; set; }
		[Property("EventName", SoType.Text, "EventName", "EventName")]
        public string EventName { get; set; }
		[Property("EventStartDate", SoType.DateTime, "EventStartDate", "EventStartDate")]
        public Nullable<System.DateTime> EventStartDate { get; set; }
		[Property("EventEndDate", SoType.DateTime, "EventEndDate", "EventEndDate")]
        public Nullable<System.DateTime> EventEndDate { get; set; }
		[Property("EventLocation", SoType.Text, "EventLocation", "EventLocation")]
        public string EventLocation { get; set; }
		[Property("EventLocationName", SoType.Text, "EventLocationName", "EventLocationName")]
        public string EventLocationName { get; set; }
		[Property("EventProvince", SoType.Text, "EventProvince", "EventProvince")]
        public string EventProvince { get; set; }
		[Property("EventProvinceName", SoType.Text, "EventProvinceName", "EventProvinceName")]
        public string EventProvinceName { get; set; }
		[Property("EventCity", SoType.Text, "EventCity", "EventCity")]
        public string EventCity { get; set; }
		[Property("EventCityName", SoType.Text, "EventCityName", "EventCityName")]
        public string EventCityName { get; set; }
		[Property("EventCounty", SoType.Text, "EventCounty", "EventCounty")]
        public string EventCounty { get; set; }
		[Property("EventCountyName", SoType.Text, "EventCountyName", "EventCountyName")]
        public string EventCountyName { get; set; }
		[Property("EventOtherLocation", SoType.Text, "EventOtherLocation", "EventOtherLocation")]
        public string EventOtherLocation { get; set; }
		[Property("State", SoType.Text, "State", "State")]
        public string State { get; set; }
		[Property("RequestUrl", SoType.Text, "RequestUrl", "RequestUrl")]
        public string RequestUrl { get; set; }
		[Property("ProcInstID", SoType.Number, "ProcInstID", "ProcInstID")]
        public Nullable<int> ProcInstID { get; set; }
		[Property("DiseaseArea", SoType.Text, "DiseaseArea", "DiseaseArea")]
        public string DiseaseArea { get; set; }
		[Property("BudgetAmount", SoType.Decimal, "BudgetAmount", "BudgetAmount")]
        public Nullable<decimal> BudgetAmount { get; set; }
		[Property("IsInitiatorGuarantee", SoType.YesNo, "IsInitiatorGuarantee", "IsInitiatorGuarantee")]
        public Nullable<bool> IsInitiatorGuarantee { get; set; }
		[Property("InitiatorGuaranteeContent", SoType.Text, "InitiatorGuaranteeContent", "InitiatorGuaranteeContent")]
        public string InitiatorGuaranteeContent { get; set; }
		[Property("IsOwnerGuarantee", SoType.YesNo, "IsOwnerGuarantee", "IsOwnerGuarantee")]
        public Nullable<bool> IsOwnerGuarantee { get; set; }
		[Property("OwnerGuaranteeContent", SoType.Text, "OwnerGuaranteeContent", "OwnerGuaranteeContent")]
        public string OwnerGuaranteeContent { get; set; }
		[Property("IsBAApproverGuarantee", SoType.YesNo, "IsBAApproverGuarantee", "IsBAApproverGuarantee")]
        public Nullable<bool> IsBAApproverGuarantee { get; set; }
		[Property("BAApproverGuaranteeContent", SoType.Text, "BAApproverGuaranteeContent", "BAApproverGuaranteeContent")]
        public string BAApproverGuaranteeContent { get; set; }
		[Property("CopyRequestType", SoType.Text, "CopyRequestType", "CopyRequestType")]
        public string CopyRequestType { get; set; }
		[Property("CopyRequestNo", SoType.Text, "CopyRequestNo", "CopyRequestNo")]
        public string CopyRequestNo { get; set; }
		[Property("CopyRequestGuid", SoType.Text, "CopyRequestGuid", "CopyRequestGuid")]
        public string CopyRequestGuid { get; set; }
		[Property("ReqeustVenue", SoType.Text, "ReqeustVenue", "ReqeustVenue")]
        public string ReqeustVenue { get; set; }
		[Property("RequestDescription", SoType.Text, "RequestDescription", "RequestDescription")]
        public string RequestDescription { get; set; }
		[Property("RequestMainDescription", SoType.Text, "RequestMainDescription", "RequestMainDescription")]
        public string RequestMainDescription { get; set; }
		[Property("RequestPurpose", SoType.Text, "RequestPurpose", "RequestPurpose")]
        public string RequestPurpose { get; set; }
		[Property("RequestPurposeRemark", SoType.Text, "RequestPurposeRemark", "RequestPurposeRemark")]
        public string RequestPurposeRemark { get; set; }
		[Property("RequestHCPNo", SoType.Number, "RequestHCPNo", "RequestHCPNo")]
        public Nullable<int> RequestHCPNo { get; set; }
		[Property("RequestRocheNo", SoType.Number, "RequestRocheNo", "RequestRocheNo")]
        public Nullable<int> RequestRocheNo { get; set; }
		[Property("RequestOtherNo", SoType.Number, "RequestOtherNo", "RequestOtherNo")]
        public Nullable<int> RequestOtherNo { get; set; }
		[Property("RequestTotalNo", SoType.Number, "RequestTotalNo", "RequestTotalNo")]
        public Nullable<int> RequestTotalNo { get; set; }
		[Property("RequestMainTotalNo", SoType.Number, "RequestMainTotalNo", "RequestMainTotalNo")]
        public Nullable<int> RequestMainTotalNo { get; set; }
		[Property("RequestSupportNo", SoType.Number, "RequestSupportNo", "RequestSupportNo")]
        public Nullable<int> RequestSupportNo { get; set; }
		[Property("AdditionalApproverID", SoType.Text, "AdditionalApproverID", "AdditionalApproverID")]
        public string AdditionalApproverID { get; set; }
		[Property("AdditionalApproverName", SoType.Text, "AdditionalApproverName", "AdditionalApproverName")]
        public string AdditionalApproverName { get; set; }
		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public Nullable<System.DateTime> CreateTime { get; set; }
		[Property("RatingNo", SoType.Decimal, "RatingNo", "RatingNo")]
        public Nullable<decimal> RatingNo { get; set; }
		[Property("CanCallback", SoType.YesNo, "CanCallback", "CanCallback")]
        public Nullable<bool> CanCallback { get; set; }
		[Property("InstitutionIsNoRiskForOwner", SoType.YesNo, "InstitutionIsNoRiskForOwner", "InstitutionIsNoRiskForOwner")]
        public Nullable<bool> InstitutionIsNoRiskForOwner { get; set; }
		[Property("CCID", SoType.Text, "CCID", "CCID")]
        public string CCID { get; set; }
		[Property("CCName", SoType.Text, "CCName", "CCName")]
        public string CCName { get; set; }
		[Property("FunctionName", SoType.Text, "FunctionName", "FunctionName")]
        public string FunctionName { get; set; }
		[Property("FunctionCode", SoType.Text, "FunctionCode", "FunctionCode")]
        public string FunctionCode { get; set; }
		[Property("RegionName", SoType.Text, "RegionName", "RegionName")]
        public string RegionName { get; set; }
		[Property("RegionCode", SoType.Text, "RegionCode", "RegionCode")]
        public string RegionCode { get; set; }
		[Property("BLSingleCode", SoType.Text, "BLSingleCode", "BLSingleCode")]
        public string BLSingleCode { get; set; }
		[Property("CompletedTime", SoType.DateTime, "CompletedTime", "CompletedTime")]
        public Nullable<System.DateTime> CompletedTime { get; set; }
       
    }

    public partial class EventRequestSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public EventRequestSvc()
        { }

        public static EventRequestSvc GetFromEntity(EventRequest entity)
        {
            EventRequestSvc svc = new EventRequestSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(EventRequest entity)
        {
            			this.RequestGuid = entity.RequestGuid;
			this.RequestNo = entity.RequestNo;
			this.FormFields = entity.FormFields;
			this.RequestDate = entity.RequestDate;
			this.InitiatorID = entity.InitiatorID;
			this.InitiatorName = entity.InitiatorName;
			this.InitiatorPhoneNo = entity.InitiatorPhoneNo;
			this.OwnerID = entity.OwnerID;
			this.OwnerName = entity.OwnerName;
			this.OwnerPhoneNo = entity.OwnerPhoneNo;
			this.BAName = entity.BAName;
			this.BACode = entity.BACode;
			this.BLName = entity.BLName;
			this.BLCode = entity.BLCode;
			this.FunctionRegionName = entity.FunctionRegionName;
			this.FunctionRegionCode = entity.FunctionRegionCode;
			this.RequestTypeName = entity.RequestTypeName;
			this.RequestTypeCode = entity.RequestTypeCode;
			this.RequestSubTypeName = entity.RequestSubTypeName;
			this.RequestSubTypeCode = entity.RequestSubTypeCode;
			this.InstitutionCode = entity.InstitutionCode;
			this.InstitutionName = entity.InstitutionName;
			this.InstitutionIsNoRisk = entity.InstitutionIsNoRisk;
			this.EventRefID = entity.EventRefID;
			this.EventRefName = entity.EventRefName;
			this.EventName = entity.EventName;
			this.EventStartDate = entity.EventStartDate;
			this.EventEndDate = entity.EventEndDate;
			this.EventLocation = entity.EventLocation;
			this.EventLocationName = entity.EventLocationName;
			this.EventProvince = entity.EventProvince;
			this.EventProvinceName = entity.EventProvinceName;
			this.EventCity = entity.EventCity;
			this.EventCityName = entity.EventCityName;
			this.EventCounty = entity.EventCounty;
			this.EventCountyName = entity.EventCountyName;
			this.EventOtherLocation = entity.EventOtherLocation;
			this.State = entity.State;
			this.RequestUrl = entity.RequestUrl;
			this.ProcInstID = entity.ProcInstID;
			this.DiseaseArea = entity.DiseaseArea;
			this.BudgetAmount = entity.BudgetAmount;
			this.IsInitiatorGuarantee = entity.IsInitiatorGuarantee;
			this.InitiatorGuaranteeContent = entity.InitiatorGuaranteeContent;
			this.IsOwnerGuarantee = entity.IsOwnerGuarantee;
			this.OwnerGuaranteeContent = entity.OwnerGuaranteeContent;
			this.IsBAApproverGuarantee = entity.IsBAApproverGuarantee;
			this.BAApproverGuaranteeContent = entity.BAApproverGuaranteeContent;
			this.CopyRequestType = entity.CopyRequestType;
			this.CopyRequestNo = entity.CopyRequestNo;
			this.CopyRequestGuid = entity.CopyRequestGuid;
			this.ReqeustVenue = entity.ReqeustVenue;
			this.RequestDescription = entity.RequestDescription;
			this.RequestMainDescription = entity.RequestMainDescription;
			this.RequestPurpose = entity.RequestPurpose;
			this.RequestPurposeRemark = entity.RequestPurposeRemark;
			this.RequestHCPNo = entity.RequestHCPNo;
			this.RequestRocheNo = entity.RequestRocheNo;
			this.RequestOtherNo = entity.RequestOtherNo;
			this.RequestTotalNo = entity.RequestTotalNo;
			this.RequestMainTotalNo = entity.RequestMainTotalNo;
			this.RequestSupportNo = entity.RequestSupportNo;
			this.AdditionalApproverID = entity.AdditionalApproverID;
			this.AdditionalApproverName = entity.AdditionalApproverName;
			this.CreateTime = entity.CreateTime;
			this.RatingNo = entity.RatingNo;
			this.CanCallback = entity.CanCallback;
			this.InstitutionIsNoRiskForOwner = entity.InstitutionIsNoRiskForOwner;
			this.CCID = entity.CCID;
			this.CCName = entity.CCName;
			this.FunctionName = entity.FunctionName;
			this.FunctionCode = entity.FunctionCode;
			this.RegionName = entity.RegionName;
			this.RegionCode = entity.RegionCode;
			this.BLSingleCode = entity.BLSingleCode;
			this.CompletedTime = entity.CompletedTime;
		}

        private EventRequest ConvertToEntity()
        {
            var entity = new EventRequest();
            			entity.RequestGuid = this.RequestGuid;
			entity.RequestNo = this.RequestNo;
			entity.FormFields = this.FormFields;
			entity.RequestDate = this.RequestDate;
			entity.InitiatorID = this.InitiatorID;
			entity.InitiatorName = this.InitiatorName;
			entity.InitiatorPhoneNo = this.InitiatorPhoneNo;
			entity.OwnerID = this.OwnerID;
			entity.OwnerName = this.OwnerName;
			entity.OwnerPhoneNo = this.OwnerPhoneNo;
			entity.BAName = this.BAName;
			entity.BACode = this.BACode;
			entity.BLName = this.BLName;
			entity.BLCode = this.BLCode;
			entity.FunctionRegionName = this.FunctionRegionName;
			entity.FunctionRegionCode = this.FunctionRegionCode;
			entity.RequestTypeName = this.RequestTypeName;
			entity.RequestTypeCode = this.RequestTypeCode;
			entity.RequestSubTypeName = this.RequestSubTypeName;
			entity.RequestSubTypeCode = this.RequestSubTypeCode;
			entity.InstitutionCode = this.InstitutionCode;
			entity.InstitutionName = this.InstitutionName;
			entity.InstitutionIsNoRisk = this.InstitutionIsNoRisk;
			entity.EventRefID = this.EventRefID;
			entity.EventRefName = this.EventRefName;
			entity.EventName = this.EventName;
			entity.EventStartDate = this.EventStartDate;
			entity.EventEndDate = this.EventEndDate;
			entity.EventLocation = this.EventLocation;
			entity.EventLocationName = this.EventLocationName;
			entity.EventProvince = this.EventProvince;
			entity.EventProvinceName = this.EventProvinceName;
			entity.EventCity = this.EventCity;
			entity.EventCityName = this.EventCityName;
			entity.EventCounty = this.EventCounty;
			entity.EventCountyName = this.EventCountyName;
			entity.EventOtherLocation = this.EventOtherLocation;
			entity.State = this.State;
			entity.RequestUrl = this.RequestUrl;
			entity.ProcInstID = this.ProcInstID;
			entity.DiseaseArea = this.DiseaseArea;
			entity.BudgetAmount = this.BudgetAmount;
			entity.IsInitiatorGuarantee = this.IsInitiatorGuarantee;
			entity.InitiatorGuaranteeContent = this.InitiatorGuaranteeContent;
			entity.IsOwnerGuarantee = this.IsOwnerGuarantee;
			entity.OwnerGuaranteeContent = this.OwnerGuaranteeContent;
			entity.IsBAApproverGuarantee = this.IsBAApproverGuarantee;
			entity.BAApproverGuaranteeContent = this.BAApproverGuaranteeContent;
			entity.CopyRequestType = this.CopyRequestType;
			entity.CopyRequestNo = this.CopyRequestNo;
			entity.CopyRequestGuid = this.CopyRequestGuid;
			entity.ReqeustVenue = this.ReqeustVenue;
			entity.RequestDescription = this.RequestDescription;
			entity.RequestMainDescription = this.RequestMainDescription;
			entity.RequestPurpose = this.RequestPurpose;
			entity.RequestPurposeRemark = this.RequestPurposeRemark;
			entity.RequestHCPNo = this.RequestHCPNo;
			entity.RequestRocheNo = this.RequestRocheNo;
			entity.RequestOtherNo = this.RequestOtherNo;
			entity.RequestTotalNo = this.RequestTotalNo;
			entity.RequestMainTotalNo = this.RequestMainTotalNo;
			entity.RequestSupportNo = this.RequestSupportNo;
			entity.AdditionalApproverID = this.AdditionalApproverID;
			entity.AdditionalApproverName = this.AdditionalApproverName;
			entity.CreateTime = this.CreateTime;
			entity.RatingNo = this.RatingNo;
			entity.CanCallback = this.CanCallback;
			entity.InstitutionIsNoRiskForOwner = this.InstitutionIsNoRiskForOwner;
			entity.CCID = this.CCID;
			entity.CCName = this.CCName;
			entity.FunctionName = this.FunctionName;
			entity.FunctionCode = this.FunctionCode;
			entity.RegionName = this.RegionName;
			entity.RegionCode = this.RegionCode;
			entity.BLSingleCode = this.BLSingleCode;
			entity.CompletedTime = this.CompletedTime;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "RequestGuid" },
            new string[] { "RequestGuid","RequestNo","FormFields","RequestDate","InitiatorID","InitiatorName","InitiatorPhoneNo","OwnerID","OwnerName","OwnerPhoneNo","BAName","BACode","BLName","BLCode","FunctionRegionName","FunctionRegionCode","RequestTypeName","RequestTypeCode","RequestSubTypeName","RequestSubTypeCode","InstitutionCode","InstitutionName","InstitutionIsNoRisk","EventRefID","EventRefName","EventName","EventStartDate","EventEndDate","EventLocation","EventLocationName","EventProvince","EventProvinceName","EventCity","EventCityName","EventCounty","EventCountyName","EventOtherLocation","State","RequestUrl","ProcInstID","DiseaseArea","BudgetAmount","IsInitiatorGuarantee","InitiatorGuaranteeContent","IsOwnerGuarantee","OwnerGuaranteeContent","IsBAApproverGuarantee","BAApproverGuaranteeContent","CopyRequestType","CopyRequestNo","CopyRequestGuid","ReqeustVenue","RequestDescription","RequestMainDescription","RequestPurpose","RequestPurposeRemark","RequestHCPNo","RequestRocheNo","RequestOtherNo","RequestTotalNo","RequestMainTotalNo","RequestSupportNo","AdditionalApproverID","AdditionalApproverName","CreateTime","RatingNo","CanCallback","InstitutionIsNoRiskForOwner","CCID","CCName","FunctionName","FunctionCode","RegionName","RegionCode","BLSingleCode","CompletedTime"})]
        public EventRequestSvc Read()
        {
            EventRequestService service = new EventRequestService(ConnString);
            var model = service.Read(RequestGuid);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "RequestGuid","RequestNo","FormFields","RequestDate","InitiatorID","InitiatorName","InitiatorPhoneNo","OwnerID","OwnerName","OwnerPhoneNo","BAName","BACode","BLName","BLCode","FunctionRegionName","FunctionRegionCode","RequestTypeName","RequestTypeCode","RequestSubTypeName","RequestSubTypeCode","InstitutionCode","InstitutionName","InstitutionIsNoRisk","EventRefID","EventRefName","EventName","EventStartDate","EventEndDate","EventLocation","EventLocationName","EventProvince","EventProvinceName","EventCity","EventCityName","EventCounty","EventCountyName","EventOtherLocation","State","RequestUrl","ProcInstID","DiseaseArea","BudgetAmount","IsInitiatorGuarantee","InitiatorGuaranteeContent","IsOwnerGuarantee","OwnerGuaranteeContent","IsBAApproverGuarantee","BAApproverGuaranteeContent","CopyRequestType","CopyRequestNo","CopyRequestGuid","ReqeustVenue","RequestDescription","RequestMainDescription","RequestPurpose","RequestPurposeRemark","RequestHCPNo","RequestRocheNo","RequestOtherNo","RequestTotalNo","RequestMainTotalNo","RequestSupportNo","AdditionalApproverID","AdditionalApproverName","CreateTime","RatingNo","CanCallback","InstitutionIsNoRiskForOwner","CCID","CCName","FunctionName","FunctionCode","RegionName","RegionCode","BLSingleCode","CompletedTime" },
            new string[] { "RequestGuid"})]
        public EventRequestSvc Create()
        {
            EventRequestService service = new EventRequestService(ConnString);
            var entity = ConvertToEntity();
            RequestGuid = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "RequestGuid","RequestNo","FormFields","RequestDate","InitiatorID","InitiatorName","InitiatorPhoneNo","OwnerID","OwnerName","OwnerPhoneNo","BAName","BACode","BLName","BLCode","FunctionRegionName","FunctionRegionCode","RequestTypeName","RequestTypeCode","RequestSubTypeName","RequestSubTypeCode","InstitutionCode","InstitutionName","InstitutionIsNoRisk","EventRefID","EventRefName","EventName","EventStartDate","EventEndDate","EventLocation","EventLocationName","EventProvince","EventProvinceName","EventCity","EventCityName","EventCounty","EventCountyName","EventOtherLocation","State","RequestUrl","ProcInstID","DiseaseArea","BudgetAmount","IsInitiatorGuarantee","InitiatorGuaranteeContent","IsOwnerGuarantee","OwnerGuaranteeContent","IsBAApproverGuarantee","BAApproverGuaranteeContent","CopyRequestType","CopyRequestNo","CopyRequestGuid","ReqeustVenue","RequestDescription","RequestMainDescription","RequestPurpose","RequestPurposeRemark","RequestHCPNo","RequestRocheNo","RequestOtherNo","RequestTotalNo","RequestMainTotalNo","RequestSupportNo","AdditionalApproverID","AdditionalApproverName","CreateTime","RatingNo","CanCallback","InstitutionIsNoRiskForOwner","CCID","CCName","FunctionName","FunctionCode","RegionName","RegionCode","BLSingleCode","CompletedTime" },
            new string[] { })]
        public void Update()
        {
            EventRequestService service = new EventRequestService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "RequestGuid" },
            new string[] { })]
        public void Delete()
        {
            EventRequestService service = new EventRequestService(ConnString);
            service.Delete(RequestGuid);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "RequestGuid","RequestNo","FormFields","RequestDate","InitiatorID","InitiatorName","InitiatorPhoneNo","OwnerID","OwnerName","OwnerPhoneNo","BAName","BACode","BLName","BLCode","FunctionRegionName","FunctionRegionCode","RequestTypeName","RequestTypeCode","RequestSubTypeName","RequestSubTypeCode","InstitutionCode","InstitutionName","InstitutionIsNoRisk","EventRefID","EventRefName","EventName","EventStartDate","EventEndDate","EventLocation","EventLocationName","EventProvince","EventProvinceName","EventCity","EventCityName","EventCounty","EventCountyName","EventOtherLocation","State","RequestUrl","ProcInstID","DiseaseArea","BudgetAmount","IsInitiatorGuarantee","InitiatorGuaranteeContent","IsOwnerGuarantee","OwnerGuaranteeContent","IsBAApproverGuarantee","BAApproverGuaranteeContent","CopyRequestType","CopyRequestNo","CopyRequestGuid","ReqeustVenue","RequestDescription","RequestMainDescription","RequestPurpose","RequestPurposeRemark","RequestHCPNo","RequestRocheNo","RequestOtherNo","RequestTotalNo","RequestMainTotalNo","RequestSupportNo","AdditionalApproverID","AdditionalApproverName","CreateTime","RatingNo","CanCallback","InstitutionIsNoRiskForOwner","CCID","CCName","FunctionName","FunctionCode","RegionName","RegionCode","BLSingleCode","CompletedTime" },
            new string[] { "RequestGuid","RequestNo","FormFields","RequestDate","InitiatorID","InitiatorName","InitiatorPhoneNo","OwnerID","OwnerName","OwnerPhoneNo","BAName","BACode","BLName","BLCode","FunctionRegionName","FunctionRegionCode","RequestTypeName","RequestTypeCode","RequestSubTypeName","RequestSubTypeCode","InstitutionCode","InstitutionName","InstitutionIsNoRisk","EventRefID","EventRefName","EventName","EventStartDate","EventEndDate","EventLocation","EventLocationName","EventProvince","EventProvinceName","EventCity","EventCityName","EventCounty","EventCountyName","EventOtherLocation","State","RequestUrl","ProcInstID","DiseaseArea","BudgetAmount","IsInitiatorGuarantee","InitiatorGuaranteeContent","IsOwnerGuarantee","OwnerGuaranteeContent","IsBAApproverGuarantee","BAApproverGuaranteeContent","CopyRequestType","CopyRequestNo","CopyRequestGuid","ReqeustVenue","RequestDescription","RequestMainDescription","RequestPurpose","RequestPurposeRemark","RequestHCPNo","RequestRocheNo","RequestOtherNo","RequestTotalNo","RequestMainTotalNo","RequestSupportNo","AdditionalApproverID","AdditionalApproverName","CreateTime","RatingNo","CanCallback","InstitutionIsNoRiskForOwner","CCID","CCName","FunctionName","FunctionCode","RegionName","RegionCode","BLSingleCode","CompletedTime" })]
        public List<EventRequestSvc> List()
        {
            EventRequestService service = new EventRequestService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}