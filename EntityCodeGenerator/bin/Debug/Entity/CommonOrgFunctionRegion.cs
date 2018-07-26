using System;
using System.Collections.Generic;

namespace Common.CSWF.Entity
{
    public  class CommonOrgFunctionRegion
    {
        public int ID { get; set; }
        public string BACode { get; set; }
        public string BLCode { get; set; }
        public string Function { get; set; }
        public string Region { get; set; }
        public int OrderId { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
