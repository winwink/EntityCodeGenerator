using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Models
{
    public partial class EventSelfCheckResult
    {
        public int SelfCheckID { get; set; }
        public string RequestGuid { get; set; }
        public Nullable<int> OrderId { get; set; }
        public string CheckContent { get; set; }
        public string CheckResult { get; set; }
        public string Reason { get; set; }
        public string OwnerID { get; set; }
        public string OwnerName { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
    }
}
