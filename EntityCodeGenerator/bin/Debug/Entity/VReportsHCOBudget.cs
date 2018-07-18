using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Entity
{
    public  class VReportsHCOBudget
    {
        public string RequestGuid { get; set; }
        public string RequestNo { get; set; }
        public string BA { get; set; }
        public string BL { get; set; }
        public string Function { get; set; }
        public string Region { get; set; }
        public string InstitutionCode { get; set; }
        public string InstitutionName { get; set; }
        public Nullable<decimal> BudgetAmount { get; set; }
        public string EventName { get; set; }
        public string RequestDescription { get; set; }
        public string RequestSubTypeCode { get; set; }
        public string RequestSubTypeName { get; set; }
        public string State { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> EventStartDate { get; set; }
        public Nullable<System.DateTime> EventEndDate { get; set; }
        public Nullable<System.DateTime> CompletedTime { get; set; }
    }
}
