using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Entity
{
    public  class CommonInitiatorConfig
    {
        public int ID { get; set; }
        public string RequestType { get; set; }
        public string RequestSubType { get; set; }
        public string UserAccount { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
