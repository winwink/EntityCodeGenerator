using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Models
{
    public partial class VReportsProcessingTime
    {
        public string RequestNo { get; set; }
        public string BACode { get; set; }
        public string BAName { get; set; }
        public string BLCode { get; set; }
        public string BLName { get; set; }
        public string RequestSubTypeCode { get; set; }
        public string RequestSubTypeName { get; set; }
        public string RequestTypeCode { get; set; }
        public string RequestTypeName { get; set; }
        public string InitiatorName { get; set; }
        public string InitiatorID { get; set; }
        public string EventName { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> ProcInstID { get; set; }
        public string ActivityName { get; set; }
        public string Action { get; set; }
        public string Department { get; set; }
    }
}
