using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Models
{
    public partial class VReportsRequestDetailsWithStep
    {
        public string RequestType { get; set; }
        public string RequestGuid { get; set; }
        public string RequestNo { get; set; }
        public string FormFields { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public string InitiatorID { get; set; }
        public string InitiatorName { get; set; }
        public string InitiatorPhoneNo { get; set; }
        public string OwnerID { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhoneNo { get; set; }
        public string BAName { get; set; }
        public string BACode { get; set; }
        public string BLName { get; set; }
        public string BLCode { get; set; }
        public string FunctionRegionName { get; set; }
        public string FunctionRegionCode { get; set; }
        public string RequestTypeName { get; set; }
        public string RequestTypeCode { get; set; }
        public string RequestSubTypeName { get; set; }
        public string RequestSubTypeCode { get; set; }
        public string InstitutionCode { get; set; }
        public string InstitutionName { get; set; }
        public string EventRefID { get; set; }
        public string EventRefName { get; set; }
        public string EventName { get; set; }
        public Nullable<System.DateTime> EventStartDate { get; set; }
        public Nullable<System.DateTime> EventEndDate { get; set; }
        public string EventLocation { get; set; }
        public string EventLocationName { get; set; }
        public string EventProvinceName { get; set; }
        public string EventCityName { get; set; }
        public string EventCountyName { get; set; }
        public string EventOtherLocation { get; set; }
        public string State { get; set; }
        public string RequestUrl { get; set; }
        public Nullable<int> ProcInstID { get; set; }
        public string DiseaseArea { get; set; }
        public Nullable<decimal> BudgetAmount { get; set; }
        public string ReqeustVenue { get; set; }
        public string RequestDescription { get; set; }
        public string RequestMainDescription { get; set; }
        public string RequestPurpose { get; set; }
        public string RequestPurposeRemark { get; set; }
        public Nullable<int> RequestHCPNo { get; set; }
        public Nullable<int> RequestRocheNo { get; set; }
        public Nullable<int> RequestOtherNo { get; set; }
        public Nullable<int> RequestTotalNo { get; set; }
        public Nullable<int> RequestMainTotalNo { get; set; }
        public Nullable<int> RequestSupportNo { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<decimal> RatingNo { get; set; }
        public string CCID { get; set; }
        public string CCName { get; set; }
        public Nullable<int> ContractProcInstID { get; set; }
        public string IsSameContent { get; set; }
        public string IsStandardContract { get; set; }
        public string IsStandardCompliance { get; set; }
        public string IsBigChange { get; set; }
        public string IsInvoiceAfterDays { get; set; }
        public Nullable<bool> IsXR2R { get; set; }
        public string PONo { get; set; }
        public string ActivityName { get; set; }
        public string Approver { get; set; }
        public string Action { get; set; }
        public string ActionTo { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> SubmitTime { get; set; }
        public string ApproverName { get; set; }
        public string ActionToName { get; set; }
    }
}
