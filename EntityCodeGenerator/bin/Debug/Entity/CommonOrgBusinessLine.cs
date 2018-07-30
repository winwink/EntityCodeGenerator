using System;
using System.Collections.Generic;

namespace Common.CSWF.Entity
{
    public  class CommonOrgBusinessLine :IRecordEntity
    {
        public int ID { get; set; }
        public string BACode { get; set; }
        public string BLCode { get; set; }
        public string BLNameCN { get; set; }
        public int OrderId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}

