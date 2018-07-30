using System;
using System.Collections.Generic;

namespace Common.CSWF.Entity
{
    public  class CommonOrgFunctionRegion :IRecordEntity
    {
        public int ID { get; set; }
        public string BACode { get; set; }
        public string BLCode { get; set; }
        public string Function { get; set; }
        public string Region { get; set; }
        public int OrderId { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}

