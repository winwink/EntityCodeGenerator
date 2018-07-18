using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Entity
{
    public  class RequestCarFleet
    {
        public long RequestID { get; set; }
        public string RequestNo { get; set; }
        public string RequestType { get; set; }
        public string RequestTypeName { get; set; }
        public string Status { get; set; }
        public Nullable<int> ProcInstID { get; set; }
        public string InitiatorID { get; set; }
        public string InitiatorName { get; set; }
        public string RequestUrl { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<System.DateTime> CompleteTime { get; set; }
        public string FormFields { get; set; }
    }
}
