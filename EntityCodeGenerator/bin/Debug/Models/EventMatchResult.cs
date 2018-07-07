using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Models
{
    public partial class EventMatchResult
    {
        public string MatchResultID { get; set; }
        public string RequestGuid { get; set; }
        public string EventID { get; set; }
        public string EventName { get; set; }
        public Nullable<System.DateTime> EventStartDate { get; set; }
        public Nullable<System.DateTime> EventEndDate { get; set; }
        public string EventLocation { get; set; }
        public string EventProvince { get; set; }
        public string EventCity { get; set; }
        public string EventOtherLocation { get; set; }
        public Nullable<bool> IsSelected { get; set; }
        public string EventSummary { get; set; }
        public string EventFirstRequestGuid { get; set; }
    }
}
