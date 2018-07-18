using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Entity
{
    public  class CommonLog
    {
        public int ID { get; set; }
        public string ActionUserAccount { get; set; }
        public string ActionUserName { get; set; }
        public string Module { get; set; }
        public string Action { get; set; }
        public Nullable<System.DateTime> ActionTime { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string Comments { get; set; }
    }
}
