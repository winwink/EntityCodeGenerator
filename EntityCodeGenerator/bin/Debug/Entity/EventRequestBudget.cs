using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Entity
{
    public  class EventRequestBudget
    {
        public string Guid { get; set; }
        public string RequestGuid { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParticipantNumber { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<decimal> SinglePrice { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public string Remark { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
    }
}
