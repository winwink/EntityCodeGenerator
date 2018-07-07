using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Models
{
    public partial class VReportsWorkLog
    {
        public string Approver { get; set; }
        public string RequestNo { get; set; }
        public Nullable<int> IsHaveContract { get; set; }
        public string BACode { get; set; }
        public string BAName { get; set; }
        public string BLName { get; set; }
        public string InitiatorID { get; set; }
        public string InitiatorName { get; set; }
        public string OwnerID { get; set; }
        public string OwnerName { get; set; }
        public string EventName { get; set; }
        public string IsHCO { get; set; }
        public string EventLocationName { get; set; }
        public string RequestSubTypeCode { get; set; }
        public string RequestSubTypeName { get; set; }
        public Nullable<decimal> BudgetAmount { get; set; }
        public Nullable<System.DateTime> EventStartDate { get; set; }
        public Nullable<System.DateTime> EventEndDate { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public string IsAfterFact { get; set; }
        public Nullable<System.DateTime> SubmitTime { get; set; }
        public string Action { get; set; }
    }
}
