using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Entity
{
    public  class EventList
    {
        public string EventID { get; set; }
        public string EventName { get; set; }
        public Nullable<System.DateTime> EventStartDate { get; set; }
        public Nullable<System.DateTime> EventEndDate { get; set; }
        public string EventLocation { get; set; }
        public string EventProvince { get; set; }
        public string EventCity { get; set; }
        public string EventOtherLocation { get; set; }
        public string EventSummary { get; set; }
        public string EventFirstRequestGuid { get; set; }
    }
}