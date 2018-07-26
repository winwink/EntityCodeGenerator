using System;
using System.Collections.Generic;

namespace Common.CSWF.Entity
{
    public  class CommonConfig
    {
        public string ConfigKey { get; set; }
        public string ProcessCode { get; set; }
        public string ConfigValue { get; set; }
        public string Remark { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
