using System;
using System.Collections.Generic;

namespace CSWF.CommonService.Entity
{
    public  class RequestCarFleet :IRecordEntity
    {
        public long RequestID { get; set; }
        public string RequestNo { get; set; }
        public string RequestTypeCode { get; set; }
        public string RequestTypeName { get; set; }
        public string Status { get; set; }
        public int ProcInstID { get; set; }
        public string InitiatorID { get; set; }
        public string InitiatorName { get; set; }
        public string RequestUrl { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<System.DateTime> CompleteTime { get; set; }
        public string FormFields { get; set; }
        public string BACode { get; set; }
        public string BAName { get; set; }
        public string BLCode { get; set; }
        public string BLName { get; set; }
        public string FunctionRegionCode { get; set; }
        public string FunctionRegionName { get; set; }
        public string DriverLicenseCode { get; set; }
        public string DriverLicenseType { get; set; }
        public Nullable<System.DateTime> DriverLicenseStartDate { get; set; }
        public Nullable<System.DateTime> DriverLicenseEndDate { get; set; }
        public string VehicleLicenseCode { get; set; }
        public Nullable<System.DateTime> CompulsoryInsuranceStartDate { get; set; }
        public Nullable<System.DateTime> CompulsoryInsuranceEndDate { get; set; }
        public Nullable<System.DateTime> YearlyInspectionDate { get; set; }
        public string RentingTypeCode { get; set; }
        public string RentingTypeName { get; set; }
        public Nullable<bool> HasDriver { get; set; }
        public string DriverName { get; set; }
        public string RentingCompany { get; set; }
        public string ActualUser { get; set; }
    }
}

