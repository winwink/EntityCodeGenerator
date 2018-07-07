using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Models
{
    public partial class CommonConfig
    {
        public string ConfigKey { get; set; }
        public string ConfigValue { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Remark { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string LastUpdateBy { get; set; }
        public Nullable<System.DateTime> LastUpdateTime { get; set; }
    }
}
