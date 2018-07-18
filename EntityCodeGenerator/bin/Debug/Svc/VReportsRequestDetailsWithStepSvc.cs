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
    [ServiceObject("VReportsRequestDetailsWithStepSvc", "VReportsRequestDetailsWithStepSvc", "VReportsRequestDetailsWithStepSvc")]
    public partial class VReportsRequestDetailsWithStepSvc
    {
		[Property("RequestType", SoType.Text, "RequestType", "RequestType")]
        public string RequestType { get; set; }
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
		[Property("EventProvinceName", SoType.Text, "EventProvinceName", "EventProvinceName")]
        public string EventProvinceName { get; set; }
		[Property("EventCityName", SoType.Text, "EventCityName", "EventCityName")]
        public string EventCityName { get; set; }
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
		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public Nullable<System.DateTime> CreateTime { get; set; }
		[Property("RatingNo", SoType.Decimal, "RatingNo", "RatingNo")]
        public Nullable<decimal> RatingNo { get; set; }
		[Property("CCID", SoType.Text, "CCID", "CCID")]
        public string CCID { get; set; }
		[Property("CCName", SoType.Text, "CCName", "CCName")]
        public string CCName { get; set; }
		[Property("ContractProcInstID", SoType.Number, "ContractProcInstID", "ContractProcInstID")]
        public Nullable<int> ContractProcInstID { get; set; }
		[Property("IsSameContent", SoType.Text, "IsSameContent", "IsSameContent")]
        public string IsSameContent { get; set; }
		[Property("IsStandardContract", SoType.Text, "IsStandardContract", "IsStandardContract")]
        public string IsStandardContract { get; set; }
		[Property("IsStandardCompliance", SoType.Text, "IsStandardCompliance", "IsStandardCompliance")]
        public string IsStandardCompliance { get; set; }
		[Property("IsBigChange", SoType.Text, "IsBigChange", "IsBigChange")]
        public string IsBigChange { get; set; }
		[Property("IsInvoiceAfterDays", SoType.Text, "IsInvoiceAfterDays", "IsInvoiceAfterDays")]
        public string IsInvoiceAfterDays { get; set; }
		[Property("IsXR2R", SoType.YesNo, "IsXR2R", "IsXR2R")]
        public Nullable<bool> IsXR2R { get; set; }
		[Property("PONo", SoType.Text, "PONo", "PONo")]
        public string PONo { get; set; }
		[Property("ActivityName", SoType.Text, "ActivityName", "ActivityName")]
        public string ActivityName { get; set; }
		[Property("Approver", SoType.Text, "Approver", "Approver")]
        public string Approver { get; set; }
		[Property("Action", SoType.Text, "Action", "Action")]
        public string Action { get; set; }
		[Property("ActionTo", SoType.Text, "ActionTo", "ActionTo")]
        public string ActionTo { get; set; }
		[Property("Comment", SoType.Text, "Comment", "Comment")]
        public string Comment { get; set; }
		[Property("SubmitTime", SoType.DateTime, "SubmitTime", "SubmitTime")]
        public Nullable<System.DateTime> SubmitTime { get; set; }
		[Property("ApproverName", SoType.Text, "ApproverName", "ApproverName")]
        public string ApproverName { get; set; }
		[Property("ActionToName", SoType.Text, "ActionToName", "ActionToName")]
        public string ActionToName { get; set; }
       
    }

    public partial class VReportsRequestDetailsWithStepSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public VReportsRequestDetailsWithStepSvc()
        { }

        public static VReportsRequestDetailsWithStepSvc GetFromEntity(VReportsRequestDetailsWithStep entity)
        {
            VReportsRequestDetailsWithStepSvc svc = new VReportsRequestDetailsWithStepSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(VReportsRequestDetailsWithStep entity)
        {
            			this.RequestType = entity.RequestType;
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
			this.EventRefID = entity.EventRefID;
			this.EventRefName = entity.EventRefName;
			this.EventName = entity.EventName;
			this.EventStartDate = entity.EventStartDate;
			this.EventEndDate = entity.EventEndDate;
			this.EventLocation = entity.EventLocation;
			this.EventLocationName = entity.EventLocationName;
			this.EventProvinceName = entity.EventProvinceName;
			this.EventCityName = entity.EventCityName;
			this.EventCountyName = entity.EventCountyName;
			this.EventOtherLocation = entity.EventOtherLocation;
			this.State = entity.State;
			this.RequestUrl = entity.RequestUrl;
			this.ProcInstID = entity.ProcInstID;
			this.DiseaseArea = entity.DiseaseArea;
			this.BudgetAmount = entity.BudgetAmount;
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
			this.CreateTime = entity.CreateTime;
			this.RatingNo = entity.RatingNo;
			this.CCID = entity.CCID;
			this.CCName = entity.CCName;
			this.ContractProcInstID = entity.ContractProcInstID;
			this.IsSameContent = entity.IsSameContent;
			this.IsStandardContract = entity.IsStandardContract;
			this.IsStandardCompliance = entity.IsStandardCompliance;
			this.IsBigChange = entity.IsBigChange;
			this.IsInvoiceAfterDays = entity.IsInvoiceAfterDays;
			this.IsXR2R = entity.IsXR2R;
			this.PONo = entity.PONo;
			this.ActivityName = entity.ActivityName;
			this.Approver = entity.Approver;
			this.Action = entity.Action;
			this.ActionTo = entity.ActionTo;
			this.Comment = entity.Comment;
			this.SubmitTime = entity.SubmitTime;
			this.ApproverName = entity.ApproverName;
			this.ActionToName = entity.ActionToName;
		}

        private VReportsRequestDetailsWithStep ConvertToEntity()
        {
            var entity = new VReportsRequestDetailsWithStep();
            			entity.RequestType = this.RequestType;
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
			entity.EventRefID = this.EventRefID;
			entity.EventRefName = this.EventRefName;
			entity.EventName = this.EventName;
			entity.EventStartDate = this.EventStartDate;
			entity.EventEndDate = this.EventEndDate;
			entity.EventLocation = this.EventLocation;
			entity.EventLocationName = this.EventLocationName;
			entity.EventProvinceName = this.EventProvinceName;
			entity.EventCityName = this.EventCityName;
			entity.EventCountyName = this.EventCountyName;
			entity.EventOtherLocation = this.EventOtherLocation;
			entity.State = this.State;
			entity.RequestUrl = this.RequestUrl;
			entity.ProcInstID = this.ProcInstID;
			entity.DiseaseArea = this.DiseaseArea;
			entity.BudgetAmount = this.BudgetAmount;
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
			entity.CreateTime = this.CreateTime;
			entity.RatingNo = this.RatingNo;
			entity.CCID = this.CCID;
			entity.CCName = this.CCName;
			entity.ContractProcInstID = this.ContractProcInstID;
			entity.IsSameContent = this.IsSameContent;
			entity.IsStandardContract = this.IsStandardContract;
			entity.IsStandardCompliance = this.IsStandardCompliance;
			entity.IsBigChange = this.IsBigChange;
			entity.IsInvoiceAfterDays = this.IsInvoiceAfterDays;
			entity.IsXR2R = this.IsXR2R;
			entity.PONo = this.PONo;
			entity.ActivityName = this.ActivityName;
			entity.Approver = this.Approver;
			entity.Action = this.Action;
			entity.ActionTo = this.ActionTo;
			entity.Comment = this.Comment;
			entity.SubmitTime = this.SubmitTime;
			entity.ApproverName = this.ApproverName;
			entity.ActionToName = this.ActionToName;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "RequestType" },
            new string[] { "RequestType","RequestGuid","RequestNo","FormFields","RequestDate","InitiatorID","InitiatorName","InitiatorPhoneNo","OwnerID","OwnerName","OwnerPhoneNo","BAName","BACode","BLName","BLCode","FunctionRegionName","FunctionRegionCode","RequestTypeName","RequestTypeCode","RequestSubTypeName","RequestSubTypeCode","InstitutionCode","InstitutionName","EventRefID","EventRefName","EventName","EventStartDate","EventEndDate","EventLocation","EventLocationName","EventProvinceName","EventCityName","EventCountyName","EventOtherLocation","State","RequestUrl","ProcInstID","DiseaseArea","BudgetAmount","ReqeustVenue","RequestDescription","RequestMainDescription","RequestPurpose","RequestPurposeRemark","RequestHCPNo","RequestRocheNo","RequestOtherNo","RequestTotalNo","RequestMainTotalNo","RequestSupportNo","CreateTime","RatingNo","CCID","CCName","ContractProcInstID","IsSameContent","IsStandardContract","IsStandardCompliance","IsBigChange","IsInvoiceAfterDays","IsXR2R","PONo","ActivityName","Approver","Action","ActionTo","Comment","SubmitTime","ApproverName","ActionToName"})]
        public VReportsRequestDetailsWithStepSvc Read()
        {
            VReportsRequestDetailsWithStepService service = new VReportsRequestDetailsWithStepService(ConnString);
            var model = service.Read(RequestType);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "RequestType","RequestGuid","RequestNo","FormFields","RequestDate","InitiatorID","InitiatorName","InitiatorPhoneNo","OwnerID","OwnerName","OwnerPhoneNo","BAName","BACode","BLName","BLCode","FunctionRegionName","FunctionRegionCode","RequestTypeName","RequestTypeCode","RequestSubTypeName","RequestSubTypeCode","InstitutionCode","InstitutionName","EventRefID","EventRefName","EventName","EventStartDate","EventEndDate","EventLocation","EventLocationName","EventProvinceName","EventCityName","EventCountyName","EventOtherLocation","State","RequestUrl","ProcInstID","DiseaseArea","BudgetAmount","ReqeustVenue","RequestDescription","RequestMainDescription","RequestPurpose","RequestPurposeRemark","RequestHCPNo","RequestRocheNo","RequestOtherNo","RequestTotalNo","RequestMainTotalNo","RequestSupportNo","CreateTime","RatingNo","CCID","CCName","ContractProcInstID","IsSameContent","IsStandardContract","IsStandardCompliance","IsBigChange","IsInvoiceAfterDays","IsXR2R","PONo","ActivityName","Approver","Action","ActionTo","Comment","SubmitTime","ApproverName","ActionToName" },
            new string[] { "RequestType"})]
        public VReportsRequestDetailsWithStepSvc Create()
        {
            VReportsRequestDetailsWithStepService service = new VReportsRequestDetailsWithStepService(ConnString);
            var entity = ConvertToEntity();
            RequestType = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "RequestType","RequestGuid","RequestNo","FormFields","RequestDate","InitiatorID","InitiatorName","InitiatorPhoneNo","OwnerID","OwnerName","OwnerPhoneNo","BAName","BACode","BLName","BLCode","FunctionRegionName","FunctionRegionCode","RequestTypeName","RequestTypeCode","RequestSubTypeName","RequestSubTypeCode","InstitutionCode","InstitutionName","EventRefID","EventRefName","EventName","EventStartDate","EventEndDate","EventLocation","EventLocationName","EventProvinceName","EventCityName","EventCountyName","EventOtherLocation","State","RequestUrl","ProcInstID","DiseaseArea","BudgetAmount","ReqeustVenue","RequestDescription","RequestMainDescription","RequestPurpose","RequestPurposeRemark","RequestHCPNo","RequestRocheNo","RequestOtherNo","RequestTotalNo","RequestMainTotalNo","RequestSupportNo","CreateTime","RatingNo","CCID","CCName","ContractProcInstID","IsSameContent","IsStandardContract","IsStandardCompliance","IsBigChange","IsInvoiceAfterDays","IsXR2R","PONo","ActivityName","Approver","Action","ActionTo","Comment","SubmitTime","ApproverName","ActionToName" },
            new string[] { })]
        public void Update()
        {
            VReportsRequestDetailsWithStepService service = new VReportsRequestDetailsWithStepService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "RequestType" },
            new string[] { })]
        public void Delete()
        {
            VReportsRequestDetailsWithStepService service = new VReportsRequestDetailsWithStepService(ConnString);
            service.Delete(RequestType);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "RequestType","RequestGuid","RequestNo","FormFields","RequestDate","InitiatorID","InitiatorName","InitiatorPhoneNo","OwnerID","OwnerName","OwnerPhoneNo","BAName","BACode","BLName","BLCode","FunctionRegionName","FunctionRegionCode","RequestTypeName","RequestTypeCode","RequestSubTypeName","RequestSubTypeCode","InstitutionCode","InstitutionName","EventRefID","EventRefName","EventName","EventStartDate","EventEndDate","EventLocation","EventLocationName","EventProvinceName","EventCityName","EventCountyName","EventOtherLocation","State","RequestUrl","ProcInstID","DiseaseArea","BudgetAmount","ReqeustVenue","RequestDescription","RequestMainDescription","RequestPurpose","RequestPurposeRemark","RequestHCPNo","RequestRocheNo","RequestOtherNo","RequestTotalNo","RequestMainTotalNo","RequestSupportNo","CreateTime","RatingNo","CCID","CCName","ContractProcInstID","IsSameContent","IsStandardContract","IsStandardCompliance","IsBigChange","IsInvoiceAfterDays","IsXR2R","PONo","ActivityName","Approver","Action","ActionTo","Comment","SubmitTime","ApproverName","ActionToName" },
            new string[] { "RequestType","RequestGuid","RequestNo","FormFields","RequestDate","InitiatorID","InitiatorName","InitiatorPhoneNo","OwnerID","OwnerName","OwnerPhoneNo","BAName","BACode","BLName","BLCode","FunctionRegionName","FunctionRegionCode","RequestTypeName","RequestTypeCode","RequestSubTypeName","RequestSubTypeCode","InstitutionCode","InstitutionName","EventRefID","EventRefName","EventName","EventStartDate","EventEndDate","EventLocation","EventLocationName","EventProvinceName","EventCityName","EventCountyName","EventOtherLocation","State","RequestUrl","ProcInstID","DiseaseArea","BudgetAmount","ReqeustVenue","RequestDescription","RequestMainDescription","RequestPurpose","RequestPurposeRemark","RequestHCPNo","RequestRocheNo","RequestOtherNo","RequestTotalNo","RequestMainTotalNo","RequestSupportNo","CreateTime","RatingNo","CCID","CCName","ContractProcInstID","IsSameContent","IsStandardContract","IsStandardCompliance","IsBigChange","IsInvoiceAfterDays","IsXR2R","PONo","ActivityName","Approver","Action","ActionTo","Comment","SubmitTime","ApproverName","ActionToName" })]
        public List<VReportsRequestDetailsWithStepSvc> List()
        {
            VReportsRequestDetailsWithStepService service = new VReportsRequestDetailsWithStepService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}