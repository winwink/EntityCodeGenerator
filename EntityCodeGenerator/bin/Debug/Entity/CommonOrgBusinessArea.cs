using System;
using System.Collections.Generic;

namespace CSWF.CommonService.Entity
{
    public  class CommonOrgBusinessArea :IRecordEntity
    {
        public string BACode { get; set; }
        public string BANameCN { get; set; }
        public int OrderId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}

