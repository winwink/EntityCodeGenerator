using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Models
{
    public partial class EventRequestSchedule
    {
        public string Guid { get; set; }
        public string RequestGuid { get; set; }
        public Nullable<System.DateTime> PlannedDate { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public string PlannedTopic { get; set; }
        public string PlannedSpeaker { get; set; }
        public string PlannedChairman { get; set; }
        public Nullable<bool> HasOffLabel { get; set; }
        public string Remark { get; set; }
        public Nullable<int> OrderId { get; set; }
    }
}
