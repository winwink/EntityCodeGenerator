using System;
using System.Collections.Generic;

namespace CSWF.CommonService.Entity
{
    public  class CommonConfig :IRecordEntity
    {
        public string ConfigKey { get; set; }
        public string ProcessCode { get; set; }
        public string ConfigValue { get; set; }
        public string Remark { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}

